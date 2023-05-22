using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CA_W12_Ave
{
    public partial class Form1 : Form
    {
        public static MySqlConnection sqlconnect;
        public static MySqlCommand sqlcommand;
        public static MySqlDataAdapter sqladapter;
        public static string connectionstring;
        public static string sqlquery;
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtteam = new DataTable();
        DataTable dtnation = new DataTable();
        DataTable dtpos = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionstring = "server=127.0.0.1;uid=root;pwd=averies10;database=premier_league";
            sqlconnect = new MySqlConnection(connectionstring);

            sqlquery = "SELECT  t.team_name as 'Team' FROM team t;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtteam);
            comboboxteam.DataSource = dtteam;
            comboboxteam.ValueMember = "Team";

            sqlquery = "SELECT n.nation as 'Nationality' FROM nationality n";
            sqlcommand = new MySqlCommand( sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter( sqlcommand);
            sqladapter.Fill(dtnation);
            combobox_nation.DataSource = dtnation;
            combobox_nation.ValueMember = "Nationality";

            sqlquery = "SELECT s.playing_pos as 'Position' FROM player s";
            sqlcommand = new MySqlCommand(sqlquery,sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtpos);
            combobox_position.DataSource = dtpos;
            combobox_position.ValueMember = "Position";
        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 edit = new Form2();
            edit.ShowDialog();
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 remove = new Form3();
            remove.ShowDialog();
        }
    }
}
