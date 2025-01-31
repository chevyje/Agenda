using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Agenda.Classes.Objects;
using Agenda.Properties;

namespace Agenda.Classes.Querys
{
    internal class CustomerQuery
    {
        public static string connecionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Properties.Settings.Default.dbPath};Jet OLEDB:Database Password={Properties.Settings.Default.Password};Persist Security Info=False;";

        public static async Task<List<Customer>> GetCustomers()
        {
            Debug.WriteLine(connecionString);
            await Task.Delay(1);
            List<Customer> klanten = new List<Customer>();

            // SQL query to select data from a table
            string query = "SELECT * FROM Klanten ORDER BY Naam ASC";
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int Id = Convert.ToInt32(reader[0]);
                                    string Name = reader[1].ToString();
                                    string Adres = reader[2].ToString();
                                    string Telefoon = reader[3].ToString();
                                    string Email = reader[4].ToString();
                                    DateTime gbDatum = Convert.ToDateTime(reader[5]);

                                    Customer klant = new Customer(Id, Name, Adres, Telefoon, Email, gbDatum);
                                    klanten.Add(klant);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                    return klanten;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task ÍnsertCustomer(Customer c)
        {
            await Task.Delay(1);
            string query = "INSERT INTO Klanten (Naam, Adress, TelefoonNummer, Email, GeboorteDatum)" + "VALUES (@Naam, @Adress, @TelefoonNummer, @Email, @GeboorteDatum)";
            string selectIdQuery = "SELECT @@IDENTITY;";
            bool rowsAffectedbool = false;
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Naam", c.Naam);
                        command.Parameters.AddWithValue("@Adress", c.Adres);
                        command.Parameters.AddWithValue("@TelefoonNummer", c.TelefoonNummer);
                        command.Parameters.AddWithValue("@Email", c.Email);
                        command.Parameters.AddWithValue("@GeboorteDatum", c.gbDatum);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0) { rowsAffectedbool = true; }
                    }

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        int insertedId = Convert.ToInt32(command.ExecuteScalar());
                        if (rowsAffectedbool)
                        {
                            c.Id = insertedId;
                            HomePageForm.Klanten.Add(c);
                            HomePageForm.klant.LoadInfo();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static async Task UpdateCustomer(Customer c)
        {
            await Task.Delay(1);
            string query = @"UPDATE Klanten SET Naam = @Naam, Adress = @Adress, TelefoonNummer = @TelefoonNummer, Email = @Email, GeboorteDatum = @GeboorteDatum WHERE Id = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connecionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Naam", c.Naam);
                        command.Parameters.AddWithValue("@Adress", c.Adres);
                        command.Parameters.AddWithValue("@TelefoonNummer", c.TelefoonNummer);
                        command.Parameters.AddWithValue("@Email", c.Email);
                        command.Parameters.AddWithValue("@GeboorteDatum", c.gbDatum);
                        command.Parameters.AddWithValue("@id", c.Id);

                        command.ExecuteNonQuery();
                    }
                }

                int index = HomePageForm.Klanten.FindIndex(person => person.Id == c.Id);
                if (index != -1)
                {
                    HomePageForm.Klanten[index] = c;
                    HomePageForm.klant.LoadInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static async Task DeleteCustomer(int id)
        {
            await Task.Delay(1);
            string query = "DELETE FROM Klanten WHERE Id = @id";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connecionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

                int index = HomePageForm.Klanten.FindIndex(person => person.Id == id);
                if (index != -1)
                {
                    HomePageForm.Klanten.RemoveAt(index);
                    HomePageForm.klant.LoadInfo();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
