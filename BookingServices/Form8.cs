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
    public partial class Form8 : Form
    {
        int p = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button58_Click_1(object sender, EventArgs e)
        {
            string ss = Form1.SetValueForText1;
            if (label5.Text.Equals("0"))
            {
                MessageBox.Show("No available Seat for the meeting", "Capacity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                con.Open();
                try
                {
         
                    SqlCommand cmd = new SqlCommand("insert into BookingTable(ParticipantEmail,MeetingId) values(@ParticipantEmail,@MeetingId)", con);
                    cmd.Parameters.AddWithValue("@ParticipantEmail", ss);
                    cmd.Parameters.AddWithValue("@MeetingId", textBox1.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    p += 1;
                    SqlCommand cmd2 = new SqlCommand("update MeetingCapacity set No_of_participant='" + p + "' where MeetingId='" + textBox1.Text + "'", con);
                    dr = cmd2.ExecuteReader();
                    MessageBox.Show("Slots Booked for You", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    string s=ex.Message;
                    MessageBox.Show("Slot Already Booked for You", "Booking", MessageBoxButtons.OK);
                }
                con.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

            int a, b;
            string s;
            string[] slot = new string[7];
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Meeting where MeetingId='" + textBox1.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from MeetingCapacity where MeetingId='" + textBox1.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            //SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {

                panel1.Visible = true;
                label2.Text = dr.GetValue(2).ToString();
                s = dr.GetValue(1).ToString();
                a = Convert.ToInt32(s);
                slot = dr.GetValue(3).ToString().Split(' ');
                foreach(string i in slot)
                {
                    if(i.Equals(label7.Text))
                    {
                        label7.Visible = true;
                    }
                    else if (i.Equals(label8.Text))
                    {
                        label8.Visible = true;
                    }
                    else if (i.Equals(label9.Text))
                    {
                        label9.Visible = true;
                    }
                    else if (i.Equals(label10.Text))
                    {
                        label10.Visible = true;
                    }
                    else if (i.Equals(label11.Text))
                    {
                        label11.Visible = true;
                    }
                    else if (i.Equals(label12.Text))
                    {
                        label12.Visible = true;
                    }
                    else if (i.Equals(label13.Text))
                    {
                        label13.Visible = true;
                    }
                    else if (i.Equals(label14.Text))
                    {
                        label14.Visible = true;
                    }
                    else
                    {
                        //do nothing
                    }
                }


                dr.Close();

                dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    s = dr.GetValue(1).ToString();
                    b = Convert.ToInt32(s);
                    p = b;
                    label5.Text = Convert.ToString(a - b);
                }
            }
            else
            {
                MessageBox.Show("Invalid Meeting Id","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}
