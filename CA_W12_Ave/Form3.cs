using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W12_Ave
{
    public partial class Form3 : Form
    {
        public static MySqlConnection sqlconnect;
        public static MySqlCommand sqlcommand;
        public static MySqlDataAdapter sqladapter;
        public static string connectionstring;
        public static string sqlquery;
        public Form3()
        {
            InitializeComponent();
        }
        DataTable dtteam = new DataTable();
        DataTable dtplayer = new DataTable();
        private void Form3_Load(object sender, EventArgs e)
        {
            connectionstring = "server=127.0.0.1;uid=root;pwd=averies10;database=premier_league";
            sqlconnect = new MySqlConnection(connectionstring);

            sqlquery = "SELECT  t.team_name as 'Team' FROM team t;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dtteam);
            comboBoxteam.DataSource = dtteam;
            comboBoxteam.ValueMember = "Team";

            sqlquery = "SELECT p.player_name as 'Player Name', n.nation as 'Nationality', p.playing_pos as 'Position', p.team_number as 'Number', p.height, p.weight, p.birthdate " +
                       "FROM player p INNER JOIN nationality n ON p.nationality_id=n.nationality_id WHERE p.team_id=t.team_name";
            sqlcommand = new MySqlCommand( sqlquery, sqlconnect);
            sqladapter = new MySqlDataAdapter( sqlcommand);
            sqladapter.Fill(dtplayer);

        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
