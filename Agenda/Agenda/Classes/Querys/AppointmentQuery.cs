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
    internal class AppointmentQuery
    {
        public static string connecionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Settings.Default.dbPath};Jet OLEDB:Database Password={Properties.Settings.Default.Password};Persist Security Info=False;";
        
        public static async Task<List<Appointment>> GetAppointments()
        {
            Debug.WriteLine("Connection String: " + connecionString);
            await Task.Delay(1);
            List<Appointment> afspraken = new List<Appointment>();
            DateTime datumFilter = new DateTime(DateTime.Today.AddMonths(-5).Year, DateTime.Today.AddMonths(-5).Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.AddMonths(-5).Month));
            Debug.WriteLine($" Datum filter vanaf wanner afsrpaken worden ingeladen: {datumFilter}");

            string query = "SELECT * FROM Afspraken WHERE Datum >= ? ORDER BY Datum ASC, Tijd ASC";
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", datumFilter);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int id = Convert.ToInt32(reader[0]);
                                    DateTime datum;
                                    if (!reader.IsDBNull(2) && !string.IsNullOrWhiteSpace(reader[2].ToString()))
                                    {
                                        var culture = new System.Globalization.CultureInfo("nl-NL");
                                        if (!DateTime.TryParse(reader[2].ToString(), culture, System.Globalization.DateTimeStyles.None, out datum))
                                        {
                                            Debug.WriteLine($"Invalid date format for Datum: {reader[2]}");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Debug.WriteLine("Datum column is null or empty.");
                                        continue;
                                    }
                                    DateTime tijd;
                                    if (!reader.IsDBNull(3) && !string.IsNullOrWhiteSpace(reader[3].ToString()))
                                    {
                                        if (!DateTime.TryParse(reader[3].ToString(), out tijd))
                                        {
                                            Debug.WriteLine($"Invalid time format for Tijd: {reader[3]}");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Debug.WriteLine("Tijd column is null or empty.");
                                        continue;
                                    }
                                    string lengte = reader[4].ToString();
                                    string naam = reader[5].ToString();
                                    string behandeling = reader[6].ToString();
                                    string beschrijving = reader[7].ToString();

                                    Appointment afspraak = new Appointment(id, datum, tijd, lengte, naam, behandeling, beschrijving);
                                    afspraken.Add(afspraak);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                    return afspraken;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task InsertAppointment(Appointment a)
        {
            await Task.Delay(1);
            string query = "INSERT INTO Afspraken (Aangemaakt, Datum, Tijd, Lengte, Naam, Behandeling, Beschrijving)" + "VALUES (@Aangemaakt, @Datum, @Tijd, @Lengte, @Naam, @Behandeling, @Beschrijving)";
            string selectIdQuery = "SELECT @@IDENTITY;";
            bool rowsAffectedbool = false;
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Aangemaakt", DateTime.Today);
                        command.Parameters.AddWithValue("@Datum", a.Datum);
                        command.Parameters.AddWithValue("@Tijd", a.Tijd);
                        command.Parameters.AddWithValue("@Lengte", a.Lengte);
                        command.Parameters.AddWithValue("@Naam", a.Naam);
                        command.Parameters.AddWithValue("@Behandeling", a.Behandeling);
                        command.Parameters.AddWithValue("@Beschrijving", a.Beschrijving);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0){ rowsAffectedbool = true; }
                    }

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        int insertedId = Convert.ToInt32(command.ExecuteScalar());
                        if (rowsAffectedbool)
                        {
                            a.Id = insertedId;
                            HomePageForm.Afspraken.Add(a);
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

        public static async Task UpdateAppointment(Appointment a)
        {
            await Task.Delay(1);

            string query = @"UPDATE Afspraken SET Datum = @Datum, Tijd = @Tijd, Lengte = @Lengte, Naam = @Naam, Behandeling = @Behandeling, Beschrijving = @Beschrijving WHERE Id = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connecionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Datum", a.Datum);
                        command.Parameters.AddWithValue("@Tijd", a.Tijd);
                        command.Parameters.AddWithValue("@Lengte", a.Lengte);
                        command.Parameters.AddWithValue("@Naam", a.Naam);
                        command.Parameters.AddWithValue("@Behandeling", a.Behandeling);
                        command.Parameters.AddWithValue("@Beschrijving", a.Beschrijving);
                        command.Parameters.AddWithValue("@id", a.Id);

                        command.ExecuteNonQuery();
                    }
                }

                int index = HomePageForm.Afspraken.FindIndex(person => person.Id == a.Id);
                if (index != -1)
                {
                    HomePageForm.Afspraken[index] = a;
                    HomePageForm.agenda.LoadInfo();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static async Task DeleteAppointment(int id)
        {
            await Task.Delay(1);
            string query = "DELETE FROM afspraken WHERE Id = @id";
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

                int index = HomePageForm.Afspraken.FindIndex(person => person.Id == id);
                if (index != -1)
                {
                    HomePageForm.Afspraken.RemoveAt(index);
                    HomePageForm.agenda.LoadInfo();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}