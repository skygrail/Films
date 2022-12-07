using Films.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Films.Managers
{
    public class Authorization
    {
        public Response Registration(Registration registration, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmdUser = new SqlCommand("INSERT INTO Users(UserName, Email) " +
                                                "VALUES('" + registration.UserName + "','" + registration.Email + "');" +
                                                "INSERT INTO UsersLogins(ID, Password, Login)" +
                                                "VALUES((SELECT MAX(ID) FROM Users),'" + registration.Password + "','" + registration.Login + "');", connection);
            
            if (registration.UserName == "" || registration.Email == "" || registration.Password == "" || registration.Login == "")
            {
                response.StatusCode = 100;
                response.StatusMessage = "Invalid data! Check the fields!";

                return response;
            }
            
            connection.Open();
            int _users = cmdUser.ExecuteNonQuery();
            connection.Close();

            if (_users > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Registration Successeful!";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "An error occurred!";
            }

            return response;
        }

        public Response Login(UsersLogins usersLogins, SqlConnection connection)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users WHERE ID = " +
                                                   "( SELECT ID FROM UsersLogins WHERE " +
                                                   "Login = '" + usersLogins.Login + "' AND Password = '" + usersLogins.Password + "') ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Login Successeful";
                Users user = new Users();
                user.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                user.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                user.BirthDay = Convert.ToString(dt.Rows[0]["BirthDay"]);
                user.ProfilePic = Convert.ToString(dt.Rows[0]["ProfilePic"]);
                user.Email = Convert.ToString(dt.Rows[0]["Email"]);
                response.Users = user;
            }
            else
            {
                response.StatusCode = 400;
                response.StatusMessage = "Error";
                response.Users = null;
            }

            return response;
        }
    }
}