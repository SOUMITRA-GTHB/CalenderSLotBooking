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
    public partial class Form2 : Form
    {
      
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Users(Email,Name,DOB,Password) values(@Email,@Name,@DOB,@Password)", con);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim());
                SqlDataReader dr= cmd.ExecuteReader();
                MessageBox.Show("registration successful", "Equestion", MessageBoxButtons.OKCancel);
                Form1 f = new Form1();
                this.Hide();
                f.Show();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Equestion");
             }
            con.Close();
        }
    }
}
