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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(Form1.SetValueForText2))
            {

                if (textBox2.Text.Equals(textBox3.Text))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Users set Password='" + textBox3.Text + "' where Email='" + label4.Text + "'", con);
                    SqlDataReader dr= cmd.ExecuteReader();
                    MessageBox.Show("Password Updated", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1();
                    this.Hide();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Confirm password doesn't match with your new password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.SetValueForText1;
        }
    }
}
