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
        string CONNECTION_STR = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                "uid=team12admin@cosc3380-02-team12;" +
                                "pwd=Team 12 is the very best team.;" +
                                "database=zoo";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Create listMemberType by data binding
                listMemberType.DataSource = CreateDataSource(listMemberType);
                listMemberType.DataTextField = "MemberTypeName";
                listMemberType.DataValueField = "MemberTypeID";
                listMemberType.DataBind();

                // Create listState
                listState.DataSource = CreateDataSource(listState);
                listState.DataTextField = "StateName";
                listState.DataValueField = "StateID";
                listState.DataBind();
            }
        }

        protected void Add_Member(object sender, EventArgs e)
        {
            // Get user input
            int memberType = Convert.ToInt32(listMemberType.SelectedValue);
            string firstName = inFirstName.Text.Trim();
            string lastName = inLastName.Text.Trim();
            string phone = inPhone.Text.Trim();
            string email = inEmail.Text.Trim();
            string street = inStreet.Text.Trim();
            string city = inCity.Text.Trim();
            string state = listState.SelectedValue;
            string zip = inZIP.Text.Trim();

            string registrationDate = System.DateTime.Now.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    // Generate new contact ID
                    string query = "SELECT MAX(contact_id) FROM contact";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    int contactID = 1;

                    if (result != DBNull.Value)
                    {
                        contactID += Convert.ToInt32(result);
                    }

                    // Add new contact
                    cmd.CommandText = "INSERT INTO contact VALUES " +
                                          "(@contact_id, @phone_no, @email_addr, @addr_line, @city, @state, @zip_code);";
                    cmd.Parameters.AddWithValue("@contact_id", contactID);
                    cmd.Parameters.AddWithValue("@phone_no", phone);
                    cmd.Parameters.AddWithValue("@email_addr", email);
                    cmd.Parameters.AddWithValue("@addr_line", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@zip_code", zip);
                    cmd.ExecuteNonQuery();

                    // Generate new member ID
                    cmd.CommandText = "SELECT MAX(member_id) FROM membership;";
                    result = cmd.ExecuteScalar();
                    int memberID = 1;

                    if (result != DBNull.Value)
                    {
                        memberID += Convert.ToInt32(result);
                    }

                    cmd.CommandText = "SELECT member_status_id " +
                                      "FROM enum_membership_status " +
                                      "WHERE member_status_name = 'active';";
                    int memberStatusID = Convert.ToInt32(cmd.ExecuteScalar());
                    
                    // Add new member
                    cmd.CommandText = "INSERT INTO membership VALUES " +
                                          "(@member_id, @member_type, @first_name, @last_name, @primary_contact, @registration_date, @member_status);";
                    cmd.Parameters.AddWithValue("@member_id", memberID);
                    cmd.Parameters.AddWithValue("@member_type", memberType);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@primary_contact", contactID);
                    cmd.Parameters.AddWithValue("@registration_date", registrationDate);
                    cmd.Parameters.AddWithValue("@member_status", memberStatusID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }

        protected void Search_Member(object sender, EventArgs e)
        {
            // Get user input
            int memberID = Convert.ToInt32(inMemberID.Text.Trim());

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    string query = "SELECT * FROM membership WHERE member_id = @member_id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@member_id", memberID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    memberInfo.DataSource = table;
                    memberInfo.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }

        ICollection CreateDataSource(DropDownList list)
        {
            // Create/configure a DataTable to store data for the DropDownList
            DataTable table = new DataTable();

            string query = "";

            if (list.ID.Equals("listMemberType"))
            {
                table.Columns.Add(new DataColumn("MemberTypeID", typeof(int)));
                table.Columns.Add(new DataColumn("MemberTypeName", typeof(string)));

                query = "SELECT member_type_id, member_type_name FROM enum_membership_type;";
            }
            
            if (list.ID.Equals("listState"))
            {
                table.Columns.Add(new DataColumn("StateID", typeof(string)));
                table.Columns.Add(new DataColumn("StateName", typeof(string)));

                query = "SELECT state_id, state_name FROM enum_state;";
            }

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Execute command
                    System.Diagnostics.Debug.WriteLine("Executing command...");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Read query output
                        System.Diagnostics.Debug.WriteLine("Reading query output...");

                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            row[0] = reader[0];
                            row[1] = reader[1];
                            table.Rows.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            // Return a new DataView based on the DataTable
            return new DataView(table);
        }
    }
}