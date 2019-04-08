using System;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooDataPRO
{
    public partial class Administrator : Page
    {

        SqlConnection connection = new SqlConnection(@"Data Source = umateam12.database.windows.net; Initial Catalog = UmaTeam12; User ID = Team12; Password = qwerty1!; Connect Timeout = 60; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ClearCreateForm();
                ClearUpdateForm();
            }
            colBox.Visible = false;
        }

        protected void CreateDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dropIndex1 = CreateDropDown.SelectedIndex;
            String selectedTable = CreateDropDown.SelectedValue.ToString();
            createBtn.Visible = true;
            switch (dropIndex1)
            {
                case 0: // ANIMAL
                    PopulateCreateForm(selectedTable);
                    break;
                case 1: // ATTRACTION
                    PopulateCreateForm(selectedTable);
                    break;
                case 2: // CONTACT
                    PopulateCreateForm(selectedTable);
                    break;
                case 3: // DIET
                    PopulateCreateForm(selectedTable);
                    break;
                case 4: // EMPLOYEE
                    PopulateCreateForm(selectedTable);
                    break;
                case 5: // EMPLOYEE_PAY
                    PopulateCreateForm(selectedTable);
                    break;
                case 6: // ENUM_ATTRACTION_STATUS
                    PopulateCreateForm(selectedTable);
                    break;
                case 7: // ENUM_DEPARTMENT
                    PopulateCreateForm(selectedTable);
                    break;
                case 8: // ENUM_ECOSYSTEM
                    PopulateCreateForm(selectedTable);
                    break;
                case 9: // ENUM_MEDICATION
                    PopulateCreateForm(selectedTable);
                    break;
                case 10: // ENUM_MEMBERSHIP_STATUS
                    PopulateCreateForm(selectedTable);
                    break;
                case 11: // ENUM_MEMBERSHIP_TYPE
                    PopulateCreateForm(selectedTable);
                    break;
                case 12: // ENUM_PAY_TYPE
                    PopulateCreateForm(selectedTable);
                    break;
                case 13: // ENUM_SECTION
                    PopulateCreateForm(selectedTable);
                    break;
                case 14:  // ENUM_SPECIES
                    PopulateCreateForm(selectedTable);
                    break;
                case 15: // ENUM_STATE
                    PopulateCreateForm(selectedTable);
                    break;
                case 16: // ENUM_UNIT_MEASURE
                    PopulateCreateForm(selectedTable);
                    break;
                case 17: // EXHIBIT
                    PopulateCreateForm(selectedTable);
                    break;
                case 18: // HEALTH_CONDITION
                    PopulateCreateForm(selectedTable);
                    break;
                case 19: // HEALTH_PROFULE
                    PopulateCreateForm(selectedTable);
                    break;
                case 20: // JOB_POSITION
                    PopulateCreateForm(selectedTable);
                    break;
                case 21: // MEMBERSHIP
                    PopulateCreateForm(selectedTable);
                    break;
                case 22: // PAY_PERIOD
                    PopulateCreateForm(selectedTable);
                    break;
                case 23: // PRESCRIPTION
                    PopulateCreateForm(selectedTable);
                    break;
                case 24: // SCHEDULED_REPAIR
                    PopulateCreateForm(selectedTable);
                    break;
                case 25: // SHIFT
                    PopulateCreateForm(selectedTable);
                    break;
                case 26: // TREATMENT_PLAN
                    PopulateCreateForm(selectedTable);
                    break;
                case 27: // USER_LOGINS
                    PopulateCreateForm(selectedTable);
                    break;
                default:
                    ClearCreateForm();
                    break;
            }
        }

        protected void UpdateDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dropIndex2 = UpdateDropDown.SelectedIndex;
            String selectedTable = UpdateDropDown.SelectedValue.ToString();
            updateBtn.Visible = true;
            switch (dropIndex2)
            {
                case 0: // ANIMAL
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 1: // ATTRACTION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 2: // CONTACT
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 3: // DIET
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 4: // EMPLOYEE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 5: // EMPLOYEE_PAY
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 6: // ENUM_ATTRACTION_STATUS
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 7: // ENUM_DEPARTMENT
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 8: // ENUM_ECOSYSTEM
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 9: // ENUM_MEDICATION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 10: // ENUM_MEMBERSHIP_STATUS
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 11: // ENUM_MEMBERSHIP_TYPE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 12: // ENUM_PAY_TYPE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 13: // ENUM_SECTION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 14:  // ENUM_SPECIES
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 15: // ENUM_STATE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 16: // ENUM_UNIT_MEASURE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 17: // EXHIBIT
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 18: // HEALTH_CONDITION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 19: // HEALTH_PROFULE
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 20: // JOB_POSITION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 21: // MEMBERSHIP
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 22: // PAY_PERIOD
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 23: // PRESCRIPTION
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 24: // SCHEDULED_REPAIR
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 25: // SHIFT
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 26: // TREATMENT_PLAN
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                case 27: // USER_LOGINS
                    PopulateUpdateForm(selectedTable);
                    updateTB10.Text = GetPrimaryKey(selectedTable);
                    break;
                default:
                    ClearUpdateForm();
                    break;
            }
         }

        protected void FindDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dropIndex3 = FindDropDown.SelectedIndex;
            switch (dropIndex3)
            {
                case 0: // ANIMAL

                    break;
                case 1: // ATTRACTION

                    break;
                case 2: // CONTACT

                    break;
                case 3: // DIET

                    break;
                case 4: // EMPLOYEE

                    break;
                case 5: // EMPLOYEE_PAY

                    break;
                case 6: // ENUM_ATTRACTION_STATUS

                    break;
                case 7: // ENUM_DEPARTMENT

                    break;
                case 8: // ENUM_ECOSYSTEM

                    break;
                case 9: // ENUM_MEDICATION

                    break;
                case 10: // ENUM_MEMBERSHIP_STATUS

                    break;
                case 11: // ENUM_MEMBERSHIP_TYPE

                    break;
                case 12: // ENUM_PAY_TYPE

                    break;
                case 13: // ENUM_SECTION

                    break;
                case 14:  // ENUM_SPECIES

                    break;
                case 15: // ENUM_STATE

                    break;
                case 16: // ENUM_UNIT_MEASURE

                    break;
                case 17: // EXHIBIT

                    break;
                case 18: // HEALTH_CONDITION

                    break;
                case 19: // HEALTH_PROFULE

                    break;
                case 20: // JOB_POSITION

                    break;
                case 21: // MEMBERSHIP

                    break;
                case 22: // PAY_PERIOD

                    break;
                case 23: // PRESCRIPTION

                    break;
                case 24: // SCHEDULED_REPAIR

                    break;
                case 25: // SHIFT

                    break;
                case 26: // TREATMENT_PLAN

                    break;
                case 27: // USER_LOGINS

                    break;
                default:

                    break;
            }
        }

        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            String[] textBoxArray = new String[10];
            textBoxArray[0] = CreateDropDown.SelectedValue.ToString();
            textBoxArray[1] = createTB1.Text.Trim();
            textBoxArray[2] = createTB2.Text.Trim();
            textBoxArray[3] = createTB3.Text.Trim();
            textBoxArray[4] = createTB4.Text.Trim();
            textBoxArray[5] = createTB5.Text.Trim();
            textBoxArray[6] = createTB6.Text.Trim();
            textBoxArray[7] = createTB7.Text.Trim();
            textBoxArray[8] = createTB8.Text.Trim();
            textBoxArray[9] = createTB9.Text.Trim();

            String tableName = CreateDropDown.SelectedValue.ToString();
            String q1;
            String q2;

            int dropIndex3 = CreateDropDown.SelectedIndex;
            q1 = GenerateSchemaAttributes(tableName);
            q2 = GenerateQueryAttributes(textBoxArray);
            ExecuteInsertQuery(tableName, q1, q2);
            Response.Redirect("Administrator.aspx");
        }

        protected void ShowBtn_Click(object sender, EventArgs e)
        {
            updateBtn.Visible = true;
            int numColumns = Convert.ToUInt16(colBox.Text);
            String recordID = updateTB10.Text;
            String selectedTable = UpdateDropDown.SelectedValue;
            String recordPK = GetPrimaryKey(selectedTable);
            ShowExistingRecord(selectedTable, recordPK, recordID, numColumns);
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String tableName = UpdateDropDown.SelectedValue.ToString();
            String[] attArray = new String[10];
            String[] inputArray = new String[10];
            int numberCols = Convert.ToUInt16(colBox.Text);
            inputArray[1] = updateTB1.Text;
            inputArray[2] = updateTB2.Text;
            inputArray[3] = updateTB3.Text;
            inputArray[4] = updateTB4.Text;
            inputArray[5] = updateTB5.Text;
            inputArray[6] = updateTB6.Text;
            inputArray[7] = updateTB7.Text;
            inputArray[8] = updateTB8.Text;
            inputArray[9] = updateTB9.Text;
            attArray = GenerateSchemaArray(tableName);
            ExecuteUpdateQuery(tableName, attArray, inputArray, numberCols);
        }

        protected void FindBtn_Click(object sender, EventArgs e)
        {
            String table = FindDropDown.SelectedValue.ToString();
            String keyword = findTB.Text;
            String[] attArray = new String[10];
            attArray = GenerateSchemaArray(table);
            String part1 = "SELECT * FROM " + table + " WHERE ";
            StringBuilder builder = new StringBuilder(part1, 256);
            int i = 1;
            int numColumns = 0;
            while (attArray[i] != null)
            {
                numColumns++;
                builder.Append(attArray[i] + " = '" + keyword + "'");
                if (attArray[(i + 1)] != null)
                {
                    builder.Append(" OR ");
                }
                i++;
            }
            builder.Append(";");
            String query = builder.ToString();
            ExecuteSelectQuery(query, numColumns);
        }

        protected void PopulateCreateForm(String tableName)
        {
            ClearCreateForm();
            int count = 1;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            if (stringArray[1] != null)
            {
                createLbl1.Text = stringArray[1];
                createLbl1.Visible = true;
                createTB1.Visible = true;
            }
            if (stringArray[2] != null)
            {
                createLbl2.Text = stringArray[2];
                createLbl2.Visible = true;
                createTB2.Visible = true;
            }
            if (stringArray[3] != null)
            {
                createLbl3.Text = stringArray[3];
                createLbl3.Visible = true;
                createTB3.Visible = true;
            }
            if (stringArray[4] != null)
            {
                createLbl4.Text = stringArray[4];
                createLbl4.Visible = true;
                createTB4.Visible = true;
            }
            if (stringArray[5] != null)
            {
                createLbl5.Text = stringArray[5];
                createLbl5.Visible = true;
                createTB5.Visible = true;
            }
            if (stringArray[6] != null)
            {
                createLbl6.Text = stringArray[6];
                createLbl6.Visible = true;
                createTB6.Visible = true;
            }
            if (stringArray[7] != null)
            {
                createLbl7.Text = stringArray[7];
                createLbl7.Visible = true;
                createTB7.Visible = true;
            }
            if (stringArray[8] != null)
            {
                createLbl8.Text = stringArray[8];
                createLbl8.Visible = true;
                createTB8.Visible = true;
            }
            if (stringArray[9] != null)
            {
                createLbl9.Text = stringArray[9];
                createLbl9.Visible = true;
                createTB9.Visible = true;
            }
            reader.Close();
            connection.Close();
        }

        protected void PopulateUpdateForm(String tableName)
        {
            ClearUpdateForm();
            int count = 1;
            int columns = 0;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            if (stringArray[1] != null)
            {
                updateLbl1.Text = stringArray[1];
                columns++;
                updateLbl1.Visible = true;
                updateTB1.Visible = true;
            }
            if (stringArray[2] != null)
            {
                updateLbl2.Text = stringArray[2];
                columns++;
                updateLbl2.Visible = true;
                updateTB2.Visible = true;
            }
            if (stringArray[3] != null)
            {
                updateLbl3.Text = stringArray[3];
                columns++;
                updateLbl3.Visible = true;
                updateTB3.Visible = true;
            }
            if (stringArray[4] != null)
            {
                updateLbl4.Text = stringArray[4];
                columns++;
                updateLbl4.Visible = true;
                updateTB4.Visible = true;
            }
            if (stringArray[5] != null)
            {
                updateLbl5.Text = stringArray[5];
                columns++;
                updateLbl5.Visible = true;
                updateTB5.Visible = true;
            }
            if (stringArray[6] != null)
            {
                updateLbl6.Text = stringArray[6];
                columns++;
                updateLbl6.Visible = true;
                updateTB6.Visible = true;
            }
            if (stringArray[7] != null)
            {
                updateLbl7.Text = stringArray[7];
                columns++;
                updateLbl7.Visible = true;
                updateTB7.Visible = true;
            }
            if (stringArray[8] != null)
            {
                updateLbl8.Text = stringArray[8];
                columns++;
                updateLbl8.Visible = true;
                updateTB8.Visible = true;
            }
            if (stringArray[9] != null)
            {
                updateLbl9.Text = stringArray[9];
                columns++;
                updateLbl9.Visible = true;
                updateTB9.Visible = true;
            }
            SaveColumns(columns);
            reader.Close();
            connection.Close();
        }

        protected void ClearCreateForm()
        {
            createLbl1.Visible = false;
            createLbl2.Visible = false;
            createLbl3.Visible = false;
            createLbl4.Visible = false;
            createLbl5.Visible = false;
            createLbl6.Visible = false;
            createLbl7.Visible = false;
            createLbl8.Visible = false;
            createLbl9.Visible = false;
            createTB1.Visible = false;
            createTB2.Visible = false;
            createTB3.Visible = false;
            createTB4.Visible = false;
            createTB5.Visible = false;
            createTB6.Visible = false;
            createTB7.Visible = false;
            createTB8.Visible = false;
            createTB9.Visible = false;
            createBtn.Visible = false;
        }

        protected void ClearUpdateForm()
        {
            updateLbl1.Visible = false;
            updateLbl2.Visible = false;
            updateLbl3.Visible = false;
            updateLbl4.Visible = false;
            updateLbl5.Visible = false;
            updateLbl6.Visible = false;
            updateLbl7.Visible = false;
            updateLbl8.Visible = false;
            updateLbl9.Visible = false;
            updateTB1.Visible = false;
            updateTB2.Visible = false;
            updateTB3.Visible = false;
            updateTB4.Visible = false;
            updateTB5.Visible = false;
            updateTB6.Visible = false;
            updateTB7.Visible = false;
            updateTB8.Visible = false;
            updateTB9.Visible = false;
            updateBtn.Visible = false;
        }

        protected String GenerateSchemaAttributes(String tableName)
        {
            StringBuilder result = new StringBuilder("(", 256);
            int count = 1;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            if (stringArray[1] != null) 
            {
                result = result.Append(stringArray[1]);
            }
            if (stringArray[2] != null)
            {
                result = result.Append(", " + stringArray[2]);
            }
            if (stringArray[3] != null)
            {
                result = result.Append(", " + stringArray[3]);
            }
            if (stringArray[4] != null)
            {
                result = result.Append(", " + stringArray[4]);
            }
            if (stringArray[5] != null)
            {
                result = result.Append(", " + stringArray[5]);
            }
            if (stringArray[6] != null)
            {
                result = result.Append(", " + stringArray[6]);
            }
            if (stringArray[7] != null)
            {
                result = result.Append(", " + stringArray[7]);
            }
            if (stringArray[8] != null)
            {
                result = result.Append(", " + stringArray[8]);
            }
            if (stringArray[9] != null)
            {
                result = result.Append(", " + stringArray[9]);
            }
            result.Append(")");
            connection.Close();
            return result.ToString();
        }

        protected String GenerateQueryAttributes(String[] inputArray)
        {
            StringBuilder result = new StringBuilder("(", 256);
            int count = 1;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + inputArray[0].ToString() + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            if (stringArray[1] != null)
            {
                result = result.Append("'" + inputArray[1] + "'");
            }
            if (stringArray[2] != null)
            {
                result = result.Append(", '" + inputArray[2] + "'");
            }
            if (stringArray[3] != null)
            {
                result = result.Append(", '" + inputArray[3] + "'");
            }
            if (stringArray[4] != null)
            {
                result = result.Append(", '" + inputArray[4] + "'");
            }
            if (stringArray[5] != null)
            {
                result = result.Append(", '" + inputArray[5] + "'");
            }
            if (stringArray[6] != null)
            {
                result = result.Append(", '" + inputArray[6] + "'");
            }
            if (stringArray[7] != null)
            {
                result = result.Append(", '" + inputArray[7] + "'");
            }
            if (stringArray[8] != null)
            {
                result = result.Append(", '" + inputArray[8] + "'");
            }
            if (stringArray[9] != null)
            {
                result = result.Append(", '" + inputArray[9] + "'");
            }
            result.Append(");");
            reader.Close();
            connection.Close();
            return result.ToString();
        }

        protected String[] GenerateSchemaArray(String tableName)
        {
            int count = 1;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            reader.Close();
            connection.Close();
            return stringArray;
        }

        protected void ExecuteInsertQuery(String table, String attributes, String inputs)
        {
            String query = "INSERT INTO " + table + " " + attributes + " VALUES " + inputs;
            connection.Open();
            SqlCommand createEntry = new SqlCommand(query, connection);
            createEntry.ExecuteNonQuery();
            connection.Close();
        }

        protected void ExecuteUpdateQuery(String table, String[] atts, String[] inputs, int num)
        {
            StringBuilder builder = new StringBuilder("UPDATE ", 256);
            builder.Append(table + " SET ");
            if (num > 0)
            {
                builder.Append(atts[1] + " = '" + inputs[1] + "'");
            }
            if (num > 1)
            {
                builder.Append(", " + atts[2] + " = '" + inputs[2] + "'");
            }
            if (num > 2)
            {
                builder.Append(", " + atts[3] + " = '" + inputs[3] + "'");
            }
            if (num > 3)
            {
                builder.Append(", " + atts[4] + " = '" + inputs[4] + "'");
            }
            if (num > 4)
            {
                builder.Append(", " + atts[5] + " = '" + inputs[5] + "'");
            }
            if (num > 5)
            {
                builder.Append(", " + atts[6] + " = '" + inputs[6] + "'");
            }
            if (num > 6)
            {
                builder.Append(", " + atts[7] + " = '" + inputs[7] + "'");
            }
            if (num > 7)
            {
                builder.Append(", " + atts[8] + " = '" + inputs[8] + "'");
            }
            if (num > 8)
            {
                builder.Append(", " + atts[9] + " = '" + inputs[9] + "'");
            }
            builder.Append(" WHERE " + atts[1] + " = '" + inputs[1] + "';");
            String query = builder.ToString();
            connection.Open();
            SqlCommand createEntry = new SqlCommand(query, connection);
            createEntry.ExecuteNonQuery();
            connection.Close();
        }

        protected void ExecuteSelectQuery(String script, int columns)
        {
            String tableName = FindDropDown.SelectedValue.ToString();
            StringBuilder sb = new StringBuilder(tableName + ":\n", 256);
            String query = "SELECT * FROM " + tableName + ";";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(query, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                if (columns > 0) { sb.Append(Convert.ToString(reader.GetValue(0)) + " "); }
                if (columns > 1) { sb.Append(Convert.ToString(reader.GetValue(1)) + " "); }
                if (columns > 2) { sb.Append(Convert.ToString(reader.GetValue(2)) + " "); }
                if (columns > 3) { sb.Append(Convert.ToString(reader.GetValue(3)) + " "); }
                if (columns > 4) { sb.Append(Convert.ToString(reader.GetValue(4)) + " "); }
                if (columns > 5) { sb.Append(Convert.ToString(reader.GetValue(5)) + " "); }
                if (columns > 6) { sb.Append(Convert.ToString(reader.GetValue(6)) + " "); }
                if (columns > 7) { sb.Append(Convert.ToString(reader.GetValue(7)) + " "); }
                if (columns > 8) { sb.Append(Convert.ToString(reader.GetValue(8)) + " "); }
                sb.Append("\n");
            }
            foundTB.Text = sb.ToString();
            reader.Close();
            connection.Close();
        }

        /*protected void ExecuteSelectQuery(String script, int columns)
        {
            StringBuilder sb = new StringBuilder("Matching Records:\n", 256);
            connection.Open();
            SqlCommand runQuery = new SqlCommand(script, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                if (columns > 0) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 1) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 2) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 3) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 4) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 5) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 6) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 7) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                if (columns > 8) { sb.Append(Convert.ToString(reader.GetValue(1))); }
                sb.Append("\n");
            }
            foundTB.Text = sb.ToString();
            reader.Close();
            connection.Close();
        }*/

        protected void ShowExistingRecord(String tableName, String primaryKey, String input, int columns)
        {
            String query = "SELECT * FROM " + tableName + " WHERE " + primaryKey + " = '" + input + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(query, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                if (columns > 0) {updateTB1.Text = Convert.ToString(reader.GetValue(0)); }
                if (columns > 1) {updateTB2.Text = Convert.ToString(reader.GetValue(1)); }
                if (columns > 2) {updateTB3.Text = Convert.ToString(reader.GetValue(2)); }
                if (columns > 3) {updateTB4.Text = Convert.ToString(reader.GetValue(3)); }
                if (columns > 4) {updateTB5.Text = Convert.ToString(reader.GetValue(4)); }
                if (columns > 5) {updateTB6.Text = Convert.ToString(reader.GetValue(5)); }
                if (columns > 6) {updateTB7.Text = Convert.ToString(reader.GetValue(6)); }
                if (columns > 7) {updateTB8.Text = Convert.ToString(reader.GetValue(7)); }
                if (columns > 8) {updateTB9.Text = Convert.ToString(reader.GetValue(8)); }
            }
            reader.Close();
            connection.Close();
        }

        protected String GetPrimaryKey(String tableName)
        {
            int count = 1;
            String[] stringArray = new String[10];
            String testQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
            connection.Open();
            SqlCommand runQuery = new SqlCommand(testQuery, connection);
            SqlDataReader reader = runQuery.ExecuteReader();
            while (reader.Read())
            {
                stringArray[count] = reader.GetString(0);
                count++;
            }
            reader.Close();
            connection.Close();
            return stringArray[1].ToString();
        }

        protected void SaveColumns(int number_of_columns)
        {
            colBox.Text = number_of_columns.ToString();
        }
    }
}