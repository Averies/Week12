using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W12_Ave
{
    public partial class Form2 : Form
    {
        public static MySqlConnection sqlconnect;
        public static MySqlCommand sqlcommand;
        public static MySqlDataAdapter sqladapter;
        public static string connectionstring;
        public static string sqlquery;
        public Form2()
        {
            InitializeComponent();
        }
        DataTable dtteam = new DataTable();
        DataTable dtedit = new DataTable();
        int rows;
        int column;
        private void Form2_Load(object sender, EventArgs e)
        {
            connectionstring = "server=127.0.0.1;uid=root;pwd=averies10;database=premier_league";
            sqlconnect = new MySqlConnection(connectionstring);

            sqlquery = "SELECT  t.team_name as 'Team' FROM team t;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtteam);
            comboBox_team.DataSource = dtteam;
            comboBox_team.ValueMember = "Team";

            sqlquery = "SELECT t.manager_id as 'ID', m.manager_name as 'Name', n.nation, m.birthdate FROM team t INNER JOIN manager m ON t.manager_id = m.manager_id " +
                       "INNER JOIN nationality n ON m.nationality_id = n.nationality_id WHERE m.manager_id=t.team_name";
            sqlcommand = new MySqlCommand( sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter( sqlcommand);
            sqladapter.Fill(dtedit);
            dgv_edit.DataSource = dtedit;
        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 remove = new Form3();
            remove.ShowDialog();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.ShowDialog();
        }
    }
}
