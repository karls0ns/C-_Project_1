using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LD1
{
    public partial class LD1 : Form
    {
        public LD1()
        {
            InitializeComponent();            
        }

        private void btnAddPupil_Click(object sender, EventArgs e)
        {
            labelName.Visible = true;
            textName.Visible = true;

            labelSurname.Visible = true;
            textSurname.Visible = true;

            labelMark1.Visible = true;
            comboMark1.Visible = true;

            labelMark2.Visible = true;
            comboMark2.Visible = true;

            labelMark3.Visible = true;
            comboMark3.Visible = true;

            btnAdd.Visible = true;

            btnCancelAdd.Visible = true;

            btnAddPupil.Visible = false;

            btnGetBest.Visible = false;

            btnViewData.Visible = false;

            tbSKOLNIEKI.Visible = false;

            btnSettings.Visible = false;

        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Vai tiešām vēlaties atcelt?", "Atcelt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Globals.name_changed = false;
                Globals.surname_changed = false;

                labelName.Visible = false;
                textName.Visible = false;
                textName.ResetText();

                labelSurname.Visible = false;
                textSurname.Visible = false;
                textSurname.ResetText();

                labelMark1.Visible = false;
                comboMark1.Visible = false;
                comboMark1.SelectedIndex = -1;

                labelMark2.Visible = false;
                comboMark2.Visible = false;
                comboMark2.SelectedIndex = -1;

                labelMark3.Visible = false;
                comboMark3.Visible = false;
                comboMark3.SelectedIndex = -1;

                btnAdd.Visible = false;

                btnCancelAdd.Visible = false;

                btnAddPupil.Visible = true;

                btnGetBest.Visible = true;

                btnViewData.Visible = true;

                btnSettings.Visible = true;

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void textName_Leave(object sender, EventArgs e)
        {
            if (textName.TextLength != 0)
            {
                string name = textName.Text;
                string name_final = Program.Convert(name);
                if (name_final == "Kļūda")
                {
                    textName.Focus();
                    textName.ResetText();
                    MessageBox.Show("Ievadiet vārdu vēlreiz izmantojot tikai latviešu alfabēta burtus!",
                        "Nepareizi ievadīts vārds! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (name_final == "Tukšs")
                {

                }
                else
                {
                    textName.Text = name_final;
                    Globals.name_changed = true;
                }
            }
        }

        private void textSurname_Leave(object sender, EventArgs e)
        {
            string surname = textSurname.Text;
            string surname_final = Program.Convert(surname);
            if (surname_final == "Kļūda")
            {
                textSurname.Focus();
                textSurname.ResetText();
                MessageBox.Show("Ievadiet uzvārdu vēlreiz izmantojot tikai latviešu alfabēta burtus!",
                    "Nepareizi ievadīts uzvārds! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (surname_final == "Tukšs")
            {

            }
            else
            {
                textSurname.Text = surname_final;
                Globals.surname_changed = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Globals.name_changed && Globals.surname_changed && comboMark1.SelectedIndex > -1
               && comboMark2.SelectedIndex > -1 && comboMark3.SelectedIndex > -1)
            {
                
                OracleConnection con = new OracleConnection();

                string connectionString = "Data Source = (DESCRIPTION = " +
                                          "(ADDRESS = (PROTOCOL = TCP)(HOST = " + Globals.HOST + ")(PORT = 1521))" +
                                          "(CONNECT_DATA =" + //192.168.0.126
                                          "(SERVER = DEDICATED)" +
                                          "(SERVICE_NAME = " + Globals.SID + ")" +
                                          ")" +
                                          ");User Id =" + Globals.Login + ";password=" + Globals.PWD + ";";
                con.ConnectionString =  connectionString;

                try
                {
                    con.Open();

                    string sql = "insert into skolnieki(VARDS,UZVARDS,ATZIME_1,ATZIME_2,ATZIME_3) " +
                                 "values(:1, :2, :3, :4, :5)";

                    OracleCommand cmd = new OracleCommand(sql, con);

                    cmd.Connection = con;
                    cmd.CommandText = sql;

                    cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, textName.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, textSurname.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Decimal, comboMark1.SelectedItem, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Decimal, comboMark2.SelectedItem, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Decimal, comboMark3.SelectedItem, ParameterDirection.Input));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.Dispose();
                    con.Dispose();

                    MessageBox.Show("Tika saglabāti sekoši dati:\n\n" +
                                    "Vārds:       " + textName.Text + "\n" +
                                    "Uzvārds:   " + textSurname.Text + "\n" +
                                    "Atzīme 1:  " + comboMark1.SelectedItem + "\n" +
                                    "Atzīme 2:  " + comboMark2.SelectedItem + "\n" +
                                    "Atzīme 3:  " + comboMark3.SelectedItem,
                                        "Dati saglabāti veiksmīgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textName.ResetText();
                    textSurname.ResetText();
                    comboMark1.SelectedIndex = -1;
                    comboMark2.SelectedIndex = -1;
                    comboMark3.SelectedIndex = -1;
                }

                catch
                {
                    MessageBox.Show("Pēc laika mēģiniet vēlreiz!",
                                        "Nav izveidots savienojums ar datu bāzi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Pārbaudiet vai visi lauki ir aizpildīti pareizi un mēģiniet pievienot personu vēlreiz!",
                        "Nepareizi ievadīti dati!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {                       
            btnBack.Visible = true;
            btnAddPupil.Visible = false;
            btnGetBest.Visible = false;
            btnViewData.Visible = false;
            btnSettings.Visible = false;

            OracleConnection con = new OracleConnection();
            string connectionString = "Data Source = (DESCRIPTION = " +
                                      "(ADDRESS = (PROTOCOL = TCP)(HOST = " + Globals.HOST + ")(PORT = 1521))" +
                                      "(CONNECT_DATA =" + //192.168.0.126
                                      "(SERVER = DEDICATED)" +
                                      "(SERVICE_NAME = " + Globals.SID + ")" +
                                      ")" +
                                      ");User Id =" + Globals.Login + ";password=" + Globals.PWD + ";";
            
            con.ConnectionString = connectionString;

            try
            {
                con.Open();
                
                string sql = "select vards as \"Vārds\", uzvards as \"Uzvārds\", atzime_1 as \"Atzīme 1\"," +
                             "atzime_2 as \"Atzīme 2\", atzime_3 as \"Atzīme 3\" from skolnieki";
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleCommandBuilder cb = new OracleCommandBuilder(da);
                DataSet ds = new DataSet();

                da.Fill(ds);
                tbSKOLNIEKI.DataSource = ds.Tables[0];
                                                                                         
                tbSKOLNIEKI.Visible = true;            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error!");
                // MessageBox.Show("Pēc laika mēģiniet vēlreiz!",
                //"Nav izveidots savienojums ar datu bāzi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            tbSKOLNIEKI.Visible = false;
            btnBack.Visible = false;

            btnAddPupil.Visible = true;
            btnGetBest.Visible = true;
            btnViewData.Visible = true;
            btnSettings.Visible = true;
        }

        private void btnGetBest_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            btnAddPupil.Visible = false;
            btnGetBest.Visible = false;
            btnViewData.Visible = false;
            btnSettings.Visible = false;

            OracleConnection con = new OracleConnection();

            string connectionString = "Data Source = (DESCRIPTION = " +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = " + Globals.HOST + ")(PORT = 1521))" +
                "(CONNECT_DATA =" + //192.168.0.126
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = " + Globals.SID + ")" +
                ")" +
                ");User Id =" + Globals.Login + ";password=" + Globals.PWD + ";";

        con.ConnectionString = connectionString;

            try
            {
                con.Open();

                string sql = "select vards as \"Vārds\", uzvards as \"Uzvārds\", atzime_1 as \"Atzīme 1\"," +
                             "atzime_2 as \"Atzīme 2\", atzime_3 as \"Atzīme 3\" from skolnieki "+
                             "where atzime_1 > 8 and atzime_2 > 8 and atzime_3 > 8";
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleCommandBuilder cb = new OracleCommandBuilder(da);
                DataSet ds = new DataSet();

                da.Fill(ds);
                tbSKOLNIEKI.DataSource = ds.Tables[0];

                tbSKOLNIEKI.Visible = true;
            }

            catch
            {
                MessageBox.Show("Pēc laika mēģiniet vēlreiz!",
                                    "Nav izveidots savienojums ar datu bāzi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                       
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            textHost.Visible = true;
            labelHost.Visible = true;

            textSID.Visible = true;
            labelSID.Visible = true;

            textLogin.Visible = true;           
            labelLogin.Visible = true;

            textPwd.Visible = true;
            labelPwd.Visible = true;

            btnCloseSettings.Visible = true;
            btnSave.Visible = true;

            btnAddPupil.Visible = false;
            btnViewData.Visible = false;
            btnGetBest.Visible = false;
            btnSettings.Visible = false;

            
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            textHost.Visible = false;
            labelHost.Visible = false;

            textSID.Visible = false;
            labelSID.Visible = false;

            textLogin.Visible = false;
            labelLogin.Visible = false;

            textPwd.Visible = false;
            labelPwd.Visible = false;

            btnCloseSettings.Visible = false;
            btnSave.Visible = false;

            btnAddPupil.Visible = true;
            btnViewData.Visible = true;
            btnGetBest.Visible = true;
            btnSettings.Visible = true;
        }

        private void LD1_Load(object sender, EventArgs e)
        {
            Globals.HOST = textHost.Text.ToString();
            Globals.SID = textSID.Text.ToString();
            Globals.Login = textLogin.Text.ToString();
            Globals.PWD = textPwd.Text.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOST = textHost.Text.ToString();
            Properties.Settings.Default.SID = textSID.Text.ToString();
            Properties.Settings.Default.LOGIN = textLogin.Text.ToString();
            Properties.Settings.Default.PWD = textPwd.Text.ToString();
            Properties.Settings.Default.Save();

            Globals.HOST = textHost.Text.ToString();
            Globals.SID = textSID.Text.ToString();
            Globals.Login = textLogin.Text.ToString();
            Globals.PWD = textPwd.Text.ToString();


            textHost.Visible = false;
            labelHost.Visible = false;

            textSID.Visible = false;
            labelSID.Visible = false;

            textLogin.Visible = false;
            labelLogin.Visible = false;

            textPwd.Visible = false;
            labelPwd.Visible = false;

            btnCloseSettings.Visible = false;
            btnSave.Visible = false;

            btnAddPupil.Visible = true;
            btnViewData.Visible = true;
            btnGetBest.Visible = true;
            btnSettings.Visible = true;
        }
    }
}

// OracleDataReader dr = cmd.ExecuteReader();
// dr.Read();
// Create the InsertCommand.  
//cmd = new OracleCommand("INSERT INTO Dept (DeptNo, DName) " +
//        "VALUES (:pDeptNo, :pDName)", conn);
// cmd.Parameters.Add("pDeptNo", OracleDbType.Decimal, 2, "DeptNo");
// cmd.Parameters.Add("pDName", OracleDbType.Varchar2, 14, "DName");
//textName.Text = dr.GetString(0);
//MessageBox.Show(dr.GetString(0));