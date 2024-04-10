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
using ClassLibrary2;




namespace WindowsFormsApp1
{
    public partial class frm_login : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=localhost ; DATABASE=teste ; UID=life ; PASSWORD=123 ;");

        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user WHERE username = '" + txb_user.Text + "' AND password = '"+txb_passw.Text+"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                frm_principal principal = new frm_principal();
                this.Hide();
                principal.Show();

            }
            else { 
                MessageBox.Show("Credenciais incorretas");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txb_user_TextChanged(object sender, EventArgs e)
        {
            e.ToString().Trim();

        }

        private void txb_user_Click(object sender, EventArgs e)
        {

        }
    }
}
