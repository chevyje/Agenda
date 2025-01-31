using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agenda.Classes.Objects;
using Agenda.Properties;

namespace Agenda.Classes.Querys
{
    internal class GiftCardQuery
    {
        public static string connecionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Properties.Settings.Default.dbPath};Jet OLEDB:Database Password={Properties.Settings.Default.Password};Persist Security Info=False;";

        public static async Task<List<GiftCard>> GetGiftCards()
        {
            Debug.WriteLine(connecionString);
            await Task.Delay(1);
            List<GiftCard> bonnen = new List<GiftCard>();

            string query = "SELECT * FROM CadeauBonnen ORDER BY Id ASC";
            using (OleDbConnection connection = new OleDbConnection(AppointmentQuery.connecionString))
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
                                    int BonId = Convert.ToInt32(reader[1]);
                                    float Waarde = Convert.ToSingle(reader[2]);
                                    bool isGebruikt = Convert.ToBoolean(reader[3]);

                                    GiftCard bon = new GiftCard(Id, BonId, Waarde, isGebruikt);
                                    bonnen.Add(bon);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                        }
                    }
                    return bonnen;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task InsertGiftCard(int BonId, float Waarde)
        {
            await Task.Delay(1);
            string insertQuery = "INSERT INTO CadeauBonnen (BonId, Waarden, Gebruikt, DatumAangemaakt) " + "VALUES (@BonId, @Waarde, @Gebruikt, @DatumAangemaakt); ";
            string selectIdQuery = "SELECT @@IDENTITY;";
            bool rowsAffected = false;
            using (OleDbConnection connection = new OleDbConnection(connecionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BonId", BonId);
                        command.Parameters.AddWithValue("@Waarde", Waarde);
                        command.Parameters.AddWithValue("@Gebruikt", false);
                        command.Parameters.AddWithValue("@DatumAangemaakt", DateTime.Today);

                        int amountRowsAffected = command.ExecuteNonQuery();
                        if (amountRowsAffected > 0) { rowsAffected = true; }
                    }

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        int insertedId = Convert.ToInt32(command.ExecuteScalar());
                        Debug.WriteLine(insertedId);
                        if (rowsAffected)
                        {
                            HomePageForm.Bonnen.Add(new GiftCard(insertedId, BonId, Waarde, false));
                            HomePageForm.UC_bonnen.LoadInfo();
                        }
                    }
                    }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static async Task UpdateGiftCard(int id)
        {
            await Task.Delay(1);
            string query = @"UPDATE CadeauBonnen SET Gebruikt = @Gebruikt WHERE Id = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connecionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Gebruikt", true);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }

                int index = HomePageForm.Bonnen.FindIndex(person => person.Id == id);
                if (index != -1)
                {
                    HomePageForm.Bonnen[index].isGebruikt = true;
                    HomePageForm.UC_bonnen.LoadInfo();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
