using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooApplication
{
    public partial class MemberServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create listMemberType by data binding
                listMemberType.DataSource = CreateDataSource("SELECT member_type_name FROM enum_membership_type");
                listMemberType.DataBind();

                // Create listState
                listState.DataSource = CreateDataSource("SELECT state_id FROM enum_state");
                listState.DataBind();
            }
        }

        ArrayList CreateDataSource(string query)
        {
            ArrayList dataSource = new ArrayList();

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

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Execute command
                    System.Diagnostics.Debug.WriteLine("Executing command");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataSource.Add(reader[0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            return dataSource;
        }
    }
}