using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login(object sender, EventArgs e)
        {
            // Get user input
            string username = inUsername.Text.Trim();
            string password = inPassword.Text.Trim();

            string connectionStr = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                   "uid=team12admin@cosc3380-02-team12;" +
                                   "pwd=Team 12 is the very best team.;" +
                                   "database=zoo";

            using (MySqlConnection conn = new MySqlConnection(connectionStr))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    string query = "SELECT dept_name " +
                                   "FROM enum_department AS d, employee AS e, user_login AS u " +
                                   "WHERE d.dept_id = e.department AND " +
                                         "e.empl_id = u.user_id AND " +
                                         "u.username = @username AND " +
                                         "u.user_password = @password;";

                    // Configure login command
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute command
                    System.Diagnostics.Debug.WriteLine("Authenticating user");
                    object result = cmd.ExecuteScalar();

                    // If user credentials exist in database
                    if (result != null)
                    {
                        System.Diagnostics.Debug.WriteLine("Successfully authenticated user");
                        string department = Convert.ToString(result).Trim().ToLower();

                        if (department == "member services")
                        {
                            Response.Redirect("MemberServices.aspx");
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to authenticate user");
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }
    }
}