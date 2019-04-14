using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ZooApplication
{
    public partial class Veterinarian : System.Web.UI.Page
    {
        // Azure MySQL Database Credentials
        String connectionString =   "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                    "uid=team12admin@cosc3380-02-team12;" +
                                    "pwd=Team 12 is the very best team.;" +
                                    "database=zoo";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // hide left panel labels until dropdown selected
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                // hide left panel textboxes until dropdown selected
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
                // hide left panel buttons until dropdown selected
                CreateBtn.Visible = false;
                UpdateBtn.Visible = false;
            }
        }
        // left panel dropdown selection change event method
        protected void CreateDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CreateDropDown.SelectedIndex;
            PopulateTransactionLabels(selectedIndex);
            PopulateTextboxes(selectedIndex);
            CreateBtn.Visible = true;
            UpdateBtn.Visible = true;
        }
        // sets label text to table attribute names and unhides labels
        protected void PopulateTransactionLabels(int indexValue)
        {
            switch (indexValue)
            {
                default:
                    break;
                case 1: // DIET
                    Label1.Text = "Diet ID:";
                    Label2.Text = "Diet Type:";
                    Label3.Text = "Portion Size:";
                    Label4.Text = "Units:";
                    Label5.Text = "Times Per Day:";
                    Label6.Text = "";
                    Label7.Text = "";
                    Label8.Text = "";
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    break;
                case 2: // HEALTH CONDITION
                    Label1.Text = "Condition ID:";
                    Label2.Text = "Condition Name:";
                    Label3.Text = "";
                    Label4.Text = "";
                    Label5.Text = "";
                    Label6.Text = "";
                    Label7.Text = "";
                    Label8.Text = "";
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    break;
                case 3: // HEALTH PROFILE
                    Label1.Text = "Profile ID:";
                    Label2.Text = "Gender:";
                    Label3.Text = "Date of Birth:";
                    Label4.Text = "Weight:";
                    Label5.Text = "Unit(s):";
                    Label6.Text = "Height:";
                    Label7.Text = "Unit(s):";
                    Label8.Text = "Health Condition:";
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    break;
                case 4: // MEDICATION
                    Label1.Text = "Medication ID:";
                    Label2.Text = "Medication Name:";
                    Label3.Text = "";
                    Label4.Text = "";
                    Label5.Text = "";
                    Label6.Text = "";
                    Label7.Text = "";
                    Label8.Text = "";
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    Label6.Visible = false;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    break;
                case 5: // PRESCRIPTION
                    Label1.Text = "Prescription ID:";
                    Label2.Text = "Health Profile ID:";
                    Label3.Text = "Medication ID:";
                    Label4.Text = "Dosage Size:";
                    Label5.Text = "Dosage Units:";
                    Label6.Text = "Doses Per Week:";
                    Label7.Text = "";
                    Label8.Text = "";
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = false;
                    Label8.Visible = false;
                    break;
            }
        }
        // unhides textboxes based on number of attributes in table
        protected void PopulateTextboxes(int indexValue)
        {
            switch (indexValue)
            {
                default:
                    break;
                case 1: // DIET
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = false;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    break; 
                case 2: // HEALTH CONDITION
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = false;
                    TextBox4.Visible = false;
                    TextBox5.Visible = false;
                    TextBox6.Visible = false;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    break;
                case 3: // HEALTH PROFILE
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = true;
                    TextBox8.Visible = true;
                    break;
                case 4: // MEDICATION
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = false;
                    TextBox4.Visible = false;
                    TextBox5.Visible = false;
                    TextBox6.Visible = false;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    break;
                case 5: // PRESCRIPTION
                    TextBox1.Visible = true;
                    TextBox2.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    TextBox5.Visible = true;
                    TextBox6.Visible = true;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    break;
            }
        }
        // create new record
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = CreateDropDown.SelectedIndex;
            MySqlConnection connection = new MySqlConnection(connectionString);
            switch (selectedIndex)
            {
                default:
                    break;
                case 1: // DIET                    
                    String diet1 = GenerateRecordID(selectedIndex);
                    String diet2 = TextBox2.Text.Trim();
                    String diet3 = TextBox3.Text.Trim();
                    String diet4 = TextBox4.Text.Trim();
                    String diet5 = TextBox5.Text.Trim();
                    String diet = "INSERT INTO diet VALUES (@diet_id, @diet_type, @feeding_size, @feeding_unit, @feedings_per_day);";
                    connection.Open();
                    MySqlCommand dietCommand = new MySqlCommand(diet, connection);
                    dietCommand.CommandText = diet;
                    dietCommand.Parameters.AddWithValue("@diet_id", diet1);
                    dietCommand.Parameters.AddWithValue("@diet_type", diet2);
                    dietCommand.Parameters.AddWithValue("@feeding_size", diet3);
                    dietCommand.Parameters.AddWithValue("@feeding_unit", diet4);
                    dietCommand.Parameters.AddWithValue("@feedings_per_day", diet5);
                    dietCommand.ExecuteNonQuery();
                    break;
                case 2: // HEALTH CONDITION
                    String cond1 = GenerateRecordID(selectedIndex);
                    String cond2 = TextBox2.Text.Trim();
                    String condition = "INSERT INTO enum_health_condition VALUES(@condition_id, @condition_name);";
                    connection.Open();
                    MySqlCommand condCommand = new MySqlCommand(condition, connection);
                    condCommand.CommandText = condition;
                    condCommand.Parameters.AddWithValue("@condition_id", cond1);
                    condCommand.Parameters.AddWithValue("@condition_name", cond2);
                    condCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 3: // HEALTH PROFILE
                    String profile1 = GenerateRecordID(selectedIndex);
                    String profile2 = TextBox2.Text.Trim();
                    String profile3 = TextBox3.Text.Trim();
                    String profile4 = TextBox4.Text.Trim();
                    String profile5 = TextBox5.Text.Trim();
                    String profile6 = TextBox6.Text.Trim();
                    String profile7 = TextBox7.Text.Trim();
                    String profile8 = TextBox8.Text.Trim();
                    String profile = "INSERT INTO health_profile VALUES (@profile_id, @sex, @DOB, @weight, @weight_unit, @height, @height_unit, @health_condition);";
                    connection.Open();
                    MySqlCommand profileCommand = new MySqlCommand(profile, connection);
                    profileCommand.CommandText = profile;
                    profileCommand.Parameters.AddWithValue("@profile_id", profile1);
                    profileCommand.Parameters.AddWithValue("@sex", profile2);
                    profileCommand.Parameters.AddWithValue("@DOB", profile3);
                    profileCommand.Parameters.AddWithValue("@weight", profile4);
                    profileCommand.Parameters.AddWithValue("@weight_unit", profile5);
                    profileCommand.Parameters.AddWithValue("@height", profile6);
                    profileCommand.Parameters.AddWithValue("@height_unit", profile7);
                    profileCommand.Parameters.AddWithValue("@health_condition", profile8);
                    profileCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 4: // MEDICATION
                    String med1 = GenerateRecordID(selectedIndex);
                    String med2 = TextBox2.Text.Trim();
                    String medication = "INSERT INTO enum_medication VALUES(@med_id, @med_name);";
                    connection.Open();
                    MySqlCommand medCommand = new MySqlCommand(medication, connection);
                    medCommand.CommandText = medication;
                    medCommand.Parameters.AddWithValue("@med_id", med1);
                    medCommand.Parameters.AddWithValue("@med_name", med2);
                    medCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 5: // PRESCRIPTION
                    String prescript1 = GenerateRecordID(selectedIndex);
                    String prescript2 = TextBox2.Text.Trim();
                    String prescript3 = TextBox3.Text.Trim();
                    String prescript4 = TextBox4.Text.Trim();
                    String prescript5 = TextBox5.Text.Trim();
                    String prescript6 = TextBox6.Text.Trim();
                    String prescription = "INSERT INTO prescription VALUES(@prescription_id, @health_profile, @medication, @dosage_size, @dosage_unit, @doses_per_week);";
                    connection.Open();
                    MySqlCommand prescriptCommand = new MySqlCommand(prescription, connection);
                    prescriptCommand.CommandText = prescription;
                    prescriptCommand.Parameters.AddWithValue("@prescription_id", prescript1);
                    prescriptCommand.Parameters.AddWithValue("@health_profile", prescript2);
                    prescriptCommand.Parameters.AddWithValue("@medication", prescript3);
                    prescriptCommand.Parameters.AddWithValue("@dosage_size", prescript4);
                    prescriptCommand.Parameters.AddWithValue("@dosage_unit", prescript5);
                    prescriptCommand.Parameters.AddWithValue("@doses_per_week", prescript6);
                    prescriptCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
            }
        }
        // update existing record
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = CreateDropDown.SelectedIndex;
            MySqlConnection connection = new MySqlConnection(connectionString);
            switch (selectedIndex)
            {
                default:
                    break;
                case 1: // DIET                    
                    String diet1 = TextBox1.Text.Trim();
                    String diet2 = TextBox2.Text.Trim();
                    String diet3 = TextBox3.Text.Trim();
                    String diet4 = TextBox4.Text.Trim();
                    String diet5 = TextBox5.Text.Trim();
                    String diet = "UPDATE diet SET " +
                                    "diet_type = @diet_type, " +
                                    "feeding_size = @feeding_size, " +
                                    "feeding_unit = @feeding_unit, " +
                                    "feedings_per_day = @feedings_per_day " +
                                    "WHERE diet_id = @diet_id;";
                    connection.Open();
                    MySqlCommand dietCommand = new MySqlCommand(diet, connection);
                    dietCommand.CommandText = diet;
                    dietCommand.Parameters.AddWithValue("@diet_id", diet1);
                    dietCommand.Parameters.AddWithValue("@diet_type", diet2);
                    dietCommand.Parameters.AddWithValue("@feeding_size", diet3);
                    dietCommand.Parameters.AddWithValue("@feeding_unit", diet4);
                    dietCommand.Parameters.AddWithValue("@feedings_per_day", diet5);
                    dietCommand.ExecuteNonQuery();
                    break;
                case 2: // HEALTH CONDITION
                    String cond1 = TextBox1.Text.Trim();
                    String cond2 = TextBox2.Text.Trim();
                    String condition = "UPDATE enum_health_condition SET " +
                                        "condition_name = @condition_name " +
                                        "WHERE condition_id = @condition_id;";
                    connection.Open();
                    MySqlCommand condCommand = new MySqlCommand(condition, connection);
                    condCommand.CommandText = condition;
                    condCommand.Parameters.AddWithValue("@condition_id", cond1);
                    condCommand.Parameters.AddWithValue("@condition_name", cond2);
                    condCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 3: // HEALTH PROFILE
                    String profile1 = TextBox1.Text.Trim();
                    String profile2 = TextBox2.Text.Trim();
                    String profile3 = TextBox3.Text.Trim();
                    String profile4 = TextBox4.Text.Trim();
                    String profile5 = TextBox5.Text.Trim();
                    String profile6 = TextBox6.Text.Trim();
                    String profile7 = TextBox7.Text.Trim();
                    String profile8 = TextBox8.Text.Trim();
                    String profile = "UPDATE health_profile SET " +
                                        "sex = @sex, " +
                                        "DOB = @DOB, " +
                                        "weight = @weight, " +
                                        "weight_unit = @weight_unit, " +
                                        "height = @height, " +
                                        "height_unit = @height_unit, " +
                                        "health_condition = @health_condition " +
                                        "WHERE profile_id = @profile_id;";
                    connection.Open();
                    MySqlCommand profileCommand = new MySqlCommand(profile, connection);
                    profileCommand.CommandText = profile;
                    profileCommand.Parameters.AddWithValue("@profile_id", profile1);
                    profileCommand.Parameters.AddWithValue("@sex", profile2);
                    profileCommand.Parameters.AddWithValue("@DOB", profile3);
                    profileCommand.Parameters.AddWithValue("@weight", profile4);
                    profileCommand.Parameters.AddWithValue("@weight_unit", profile5);
                    profileCommand.Parameters.AddWithValue("@height", profile6);
                    profileCommand.Parameters.AddWithValue("@height_unit", profile7);
                    profileCommand.Parameters.AddWithValue("@health_condition", profile8);
                    profileCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 4: // MEDICATION
                    String med1 = TextBox1.Text.Trim();
                    String med2 = TextBox2.Text.Trim();
                    String medication = "UPDATE enum_medication SET " +
                                        "med_name = @med_name " +
                                        "WHERE med_id = @med_id;";
                    connection.Open();
                    MySqlCommand medCommand = new MySqlCommand(medication, connection);
                    medCommand.CommandText = medication;
                    medCommand.Parameters.AddWithValue("@med_id", med1);
                    medCommand.Parameters.AddWithValue("@med_name", med2);
                    medCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
                case 5: // PRESCRIPTION
                    String prescript1 = TextBox1.Text.Trim();
                    String prescript2 = TextBox2.Text.Trim();
                    String prescript3 = TextBox3.Text.Trim();
                    String prescript4 = TextBox4.Text.Trim();
                    String prescript5 = TextBox5.Text.Trim();
                    String prescript6 = TextBox6.Text.Trim();
                    String prescription = "UPDATE prescription SET " +
                                        "health_profile = @health_profile, " +
                                        "medication = @medication, " +
                                        "dosage_size = @dosage_size, " +
                                        "dosage_unit = @dosage_unit, " +
                                        "doses_per_week = @doses_per_week " +
                                        "WHERE prescription_id = @prescription_id;";
                    connection.Open();
                    MySqlCommand prescriptCommand = new MySqlCommand(prescription, connection);
                    prescriptCommand.CommandText = prescription;
                    prescriptCommand.Parameters.AddWithValue("@prescription_id", prescript1);
                    prescriptCommand.Parameters.AddWithValue("@health_profile", prescript2);
                    prescriptCommand.Parameters.AddWithValue("@medication", prescript3);
                    prescriptCommand.Parameters.AddWithValue("@dosage_size", prescript4);
                    prescriptCommand.Parameters.AddWithValue("@dosage_unit", prescript5);
                    prescriptCommand.Parameters.AddWithValue("@doses_per_week", prescript6);
                    prescriptCommand.ExecuteNonQuery();
                    connection.Close();
                    break;
            }
        }
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get user input
            int keyID = Convert.ToInt32(SearchInput.Text.Trim());
            int selectedIndex = SearchDropDown.SelectedIndex;
            String tableName = "health_profile";
            String primaryKey = "profile_id";
            if (selectedIndex == 1)
            {
                tableName = "diet";
                primaryKey = "diet_id";
            }
            else if (selectedIndex == 2)
            {
                tableName = "enum_health_condition";
                primaryKey = "condition_id";
            }
            else if (selectedIndex == 3)
            {
                tableName = "health_profile";
                primaryKey = "profile_id";
            }
            else if (selectedIndex == 4)
            {
                tableName = "enum_medication";
                primaryKey = "med_id";
            }
            else if (selectedIndex == 5)
            {
                tableName = "prescription";
                primaryKey = "prescription_id";
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    string query = "SELECT * FROM " + tableName + " WHERE " + primaryKey + " = @key_id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@key_id", keyID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    SearchOutput.DataSource = table;
                    SearchOutput.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }
        protected String GenerateRecordID(int indexValue)
        {
            String result;
            String query;
            switch (indexValue)
            {
                default:
                    return "0";
                case 1: // DIET
                    query = "SELECT MAX(diet_id) FROM diet;";
                    result = ExecuteIDReader(query);
                    return result;
                case 2: // HEALTH CONDITION
                    query = "SELECT MAX(condition_id) FROM enum_health_condition;";
                    result = ExecuteIDReader(query);
                    return result;
                case 3: // HEALTH PROFILE
                    query = "SELECT MAX(profile_id) FROM health_profile;";
                    result = ExecuteIDReader(query);
                    return result;
                case 4: // MEDICATION
                    query = "SELECT MAX(med_id) FROM enum_medication;";
                    result = ExecuteIDReader(query);
                    return result;
                case 5: // PRESCRIPTION
                    query = "SELECT MAX(prescription_id) FROM prescription;";
                    result = ExecuteIDReader(query);
                    return result;
            }
        }
        protected String ExecuteIDReader(String query)
        {
            String result = "error";
            int response = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;
            MySqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                    while (rdr.Read())
                {
                    response = rdr.GetInt32(0) + 1;
                }
            }
            catch
            {
                response = 1;
            }            
            rdr.Close();
            conn.Close();
            result = response.ToString();
            return result;
        }
    }
}
