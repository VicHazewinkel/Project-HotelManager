using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerV5
{
    internal class Persoon
    {
        public static List<Persoon> LijstPersoon = new List<Persoon>();
        private int Id;
        private string FirstName;
        private string LastName;
        private string Email;

        public Persoon(string firstName, string lastName, string email)
        {
            Id = LijstPersoon.Count + 1;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public void AddPersoonToDataBase()
        {
            string dataConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DotNetAdv2\\Project_HotelManagement_V5\\HotelManagerV5\\HotelManagerV5\\Gastenlijst.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dataConnection);
            SqlCommand command = new SqlCommand("INSERT INTO Gastenlijst_Table (Id, FirstName, LastName, Email) VALUES(@Id,@FirstName,@LastName,@Email)", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Id", this.Id);
            command.Parameters.AddWithValue("@FirstName", this.FirstName);
            command.Parameters.AddWithValue("@LastName", this.LastName);
            command.Parameters.AddWithValue("@Email", this.Email);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
