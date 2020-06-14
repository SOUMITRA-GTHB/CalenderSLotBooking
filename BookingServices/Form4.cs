using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace BookingServices
{
    public partial class Form4 : Form
    {
        public Form4()
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
            string email = "";
            string Password = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Email,Password from Users where Email=@Email", con);
            cmd.Parameters.AddWithValue("Email", textBox1.Text);
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {

                if (sdr.Read())
                {
                    email = sdr["email"].ToString();
                    Password = sdr["Password"].ToString();

                }
                else
                {
                    MessageBox.Show("Incorrect Email ID", "Forgot Password", MessageBoxButtons.OK);
                }

            }
            con.Close();
            if (!string.IsNullOrEmpty(Password))
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("sou143mitra@gmail.com");
                msg.To.Add(textBox1.Text);
                msg.Subject = " Recover your Password";
                msg.Body = ("Your Username is:" + email + "<br/><br/>" + "Your Password is:" + Password);
                msg.IsBodyHtml = true;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntwd = new NetworkCredential();
                ntwd.UserName = "sou143mitra@gmail.com";
                ntwd.Password = "SOU@143mitra";
                smt.UseDefaultCredentials = true;
                smt.Credentials = ntwd;
                smt.Port = 587;
                smt.EnableSsl = true;
                smt.Send(msg);
                string msgs = "Username and Password Sent Successfully";
                MessageBox.Show(msgs, "Forgot Password", MessageBoxButtons.OK);
            }
        }
    }
}
