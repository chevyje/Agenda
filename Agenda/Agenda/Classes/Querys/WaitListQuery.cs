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
    internal class WaitListQuery
    {
        public static string connecionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Properties.Settings.Default.dbPath};Jet OLEDB:Database Password={Properties.Settings.Default.Password};Persist Security Info=False;";

        public static async Task<List<WaitList>> GetWaitList()
        {
            Debug.WriteLine(connecionString);
            List<WaitList> waitinglist = new List<WaitList>();

            // SQL query to select data from a table
            string query = "SELECT * FROM Wachtlijst";
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
                                Debug.WriteLine($"Wachtlijst has rows. with id: {Convert.ToInt32(reader[0])}");
                                while (reader.Read())
                                {
                                    int Id = Convert.ToInt32(reader[0]);
                                    string Name = reader[1].ToString();
                                    string Voorkeur = reader[2].ToString();

                                    WaitList list = new WaitList(Id, Name, Voorkeur);
                                    waitinglist.Add(list);
                                }
                            }
                            else
                            {
                                Debug.WriteLine("No rows found in the Wachtlijst table. check if there is a error in the database or in your code =)");
                            }
                        }
                    }
                    return waitinglist;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    await Task.CompletedTask;
                    return null;
                }
            }
        }

        public static async Task InsertWaitList(WaitList w)
        {
            await Task.Delay(1);
            string query = "INSERT INTO Wachtlijst (Naam, Voorkeur)" + "VALUES (@Naam, @Voorkeur)";
            string selectIdQuery = "SELECT @@IDENTITY;";
            bool rowsAffectedbool = false;
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Naam", w.Naam);
                        command.Parameters.AddWithValue("@Voorkeur", w.Voorkeur);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0) { rowsAffectedbool = true; }
                    }

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        int insertedId = Convert.ToInt32(command.ExecuteScalar());
                        if (rowsAffectedbool)
                        {
                            w.Id = insertedId;
                            HomePageForm.WachtLijst.Add(w);
                            HomePageForm.agenda.LoadInfo();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static async Task UpdateWaitList(WaitList w)
        {
            await Task.Delay(1);
            string query = @"UPDATE Wachtlijst SET Naam = @Naam, Voorkeur = @Voorkeur WHERE Id = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connecionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Naam", w.Naam);
                        command.Parameters.AddWithValue("@Voorkeur", w.Voorkeur);
                        command.Parameters.AddWithValue("@id", w.Id);

                        command.ExecuteNonQuery();
                    }
                }

                int index = HomePageForm.WachtLijst.FindIndex(person => person.Id == w.Id);
                if (index != -1)
                {
                    HomePageForm.WachtLijst[index] = w;
                    HomePageForm.agenda.LoadInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static async Task DeleteWaitList(int id)
        {
            await Task.Delay(1);
            string query = "DELETE FROM Wacthlijst WHERE Id = @id";
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
