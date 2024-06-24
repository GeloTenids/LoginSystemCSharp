using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LoginModel;

namespace LoginDL
{
    public class LoginDbData
    {
        string connectionString
      = "Data Source =DESKTOP-L8FR2GU\\SQLEXPRESS; Initial Catalog = db_loginSystem; Integrated Security = True;";

        SqlConnection sqlConnection;

        public LoginDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Accounts> GetUsers()
        {
            string selectStatement = "SELECT accNum, pinNum FROM tbl_loginUser";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Accounts> users = new List<Accounts>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                int username = Convert.ToInt32(reader["accNum"]);
                int pin = Convert.ToInt32(reader["pinNum"]);

                Accounts readUser = new Accounts();
                readUser.accNumber = username;
                readUser.pinNumber = pin;

                users.Add(readUser);
            }

            sqlConnection.Close();

            return users;
        }

        //public int AddUser(string username, Points score)
        //{
        //    int success;

        //    string user = username;
        //    int point = Convert.ToInt32(score.score);

        //    string insertStatement = "INSERT INTO tbl_user VALUES (@username, @score)";

        //    SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

        //    insertCommand.Parameters.AddWithValue("@username", user);
        //    insertCommand.Parameters.AddWithValue("@score", point);
        //    sqlConnection.Open();

        //    success = insertCommand.ExecuteNonQuery();

        //    sqlConnection.Close();

        //    return success;
        //}
    }
}
