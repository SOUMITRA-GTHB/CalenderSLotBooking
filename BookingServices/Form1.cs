using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BookingServices
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        //public static string SetValueForText3 = "";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Users where Email='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    SetValueForText1 = textBox1.Text;
                    SetValueForText2 = textBox2.Text;
                    //SetValueForText3 = dr.GetValue(1).ToString();
                   // MessageBox.Show("Log in Successful", "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.Show();

                }
                else
                {
                    MessageBox.Show("please enter valid information: ", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void uuyuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}
