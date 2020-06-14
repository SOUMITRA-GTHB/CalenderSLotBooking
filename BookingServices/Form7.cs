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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        string b = "";
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            DateTime idate = dateTimePicker1.Value;
            label1.Text = Convert.ToString(idate.DayOfWeek);
            if (label1.Text.Equals("Sunday"))
            {
                panel1.Visible = true;
            }
            if (label1.Text.Equals("Monday"))
            {
                panel2.Visible = true;
            }
            if (label1.Text.Equals("Tuesday"))
            {
                panel3.Visible = true;
            }
            if (label1.Text.Equals("Wednesday"))
            {
                panel4.Visible = true;
            }
            if (label1.Text.Equals("Thursday"))
            {
                panel5.Visible = true;
            }
            if (label1.Text.Equals("Friday"))
            {
                panel6.Visible = true;
            }
            if (label1.Text.Equals("Saturday"))
            {
                panel7.Visible=true;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            DateTime idate = dateTimePicker1.Value;
            label1.Text = Convert.ToString(idate.DayOfWeek);
            if (label1.Text.Equals("Sunday"))
            {
                panel1.Visible = true;
            }
            if (label1.Text.Equals("Monday"))
            {
                panel2.Visible = true;
            }
            if (label1.Text.Equals("Tuesday"))
            {
                panel3.Visible = true;
            }
            if (label1.Text.Equals("Wednesday"))
            {
                panel4.Visible = true;
            }
            if (label1.Text.Equals("Thursday"))
            {
                panel5.Visible = true;
            }
            if (label1.Text.Equals("Friday"))
            {
                panel6.Visible = true;
            }
            if (label1.Text.Equals("Saturday"))
            {
                panel7.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.IndianRed;
            b += button9.Text+" ";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.BackColor = Color.IndianRed;
            b += button57.Text+" ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.IndianRed;
            b += button8.Text+" ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.IndianRed;
            b += button7.Text+" ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.IndianRed;
            b += button6.Text + " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.IndianRed;
            b += button5.Text + " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            b += button4.Text + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.IndianRed;
            b += button3.Text + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            b += button2.Text + " ";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            button66.BackColor = Color.IndianRed;
            b += button66.Text + " ";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            button65.BackColor = Color.IndianRed;
            b += button65.Text + " ";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            button64.BackColor = Color.IndianRed;
            b += button64.Text + " ";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            button63.BackColor = Color.IndianRed;
            b += button63.Text + " ";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            button62.BackColor = Color.IndianRed;
            b += button62.Text + " ";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            button61.BackColor = Color.IndianRed;
            b += button61.Text + " ";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            button60.BackColor = Color.IndianRed;
            b += button60.Text + " ";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            button59.BackColor = Color.IndianRed;
            b += button59.Text + " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.IndianRed;
            b += button17.Text + " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.IndianRed;
            b += button16.Text + " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.IndianRed;
            b += button15.Text + " ";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.IndianRed;
            b += button14.Text + " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.IndianRed;
            b += button13.Text + " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.IndianRed;
            b += button12.Text + " ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.IndianRed;
            b += button11.Text + " ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.IndianRed;
            b += button10.Text + " ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.IndianRed;
            b += button25.Text + " ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.IndianRed;
            b += button24.Text + " ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.IndianRed;
            b += button23.Text + " ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.IndianRed;
            b += button22.Text + " ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.IndianRed;
            b += button21.Text + " ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.IndianRed;
            b += button20.Text + " ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.IndianRed;
            b += button19.Text + " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.IndianRed;
            b += button18.Text + " ";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.IndianRed;
            b += button33.Text + " ";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.IndianRed;
            b += button32.Text + " ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.IndianRed;
            b += button31.Text + " ";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.IndianRed;
            b += button30.Text + " ";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.IndianRed;
            b += button29.Text + " ";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.IndianRed;
            b += button28.Text + " ";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.IndianRed;
            b += button27.Text + " ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.IndianRed;
            b += button26.Text + " ";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.IndianRed;
            b += button41.Text + " ";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.IndianRed;
            b += button40.Text + " ";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.IndianRed;
            b += button39.Text + " ";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.IndianRed;
            b += button38.Text + " ";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.IndianRed;
            b += button35.Text + " ";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.IndianRed;
            b += button36.Text + " ";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.IndianRed;
            b += button35.Text + " ";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.IndianRed;
            b += button34.Text + " ";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.BackColor = Color.IndianRed;
            b += button56.Text + " ";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.BackColor = Color.IndianRed;
            b += button7.Text + " ";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.BackColor = Color.IndianRed;
            b += button54.Text + " ";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.BackColor = Color.IndianRed;
            b += button53.Text + " ";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.BackColor = Color.IndianRed;
            b += button52.Text + " ";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.IndianRed;
            b += button51.Text + " ";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.BackColor = Color.IndianRed;
            b += button50.Text + " ";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            b = "";
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button13.BackColor = Color.Gainsboro;
            button14.BackColor = Color.Gainsboro;
            button15.BackColor = Color.Gainsboro;
            button16.BackColor = Color.Gainsboro;
            button17.BackColor = Color.Gainsboro;
            button18.BackColor = Color.Gainsboro;
            button19.BackColor = Color.Gainsboro;
            button20.BackColor = Color.Gainsboro;
            button21.BackColor = Color.Gainsboro;
            button22.BackColor = Color.Gainsboro;
            button23.BackColor = Color.Gainsboro;
            button24.BackColor = Color.Gainsboro;
            button25.BackColor = Color.Gainsboro;
            button26.BackColor = Color.Gainsboro;
            button27.BackColor = Color.Gainsboro;
            button28.BackColor = Color.Gainsboro;
            button29.BackColor = Color.Gainsboro;
            button30.BackColor = Color.Gainsboro;
            button31.BackColor = Color.Gainsboro;
            button32.BackColor = Color.Gainsboro;
            button33.BackColor = Color.Gainsboro;
            button34.BackColor = Color.Gainsboro;
            button35.BackColor = Color.Gainsboro;
            button36.BackColor = Color.Gainsboro;
            button37.BackColor = Color.Gainsboro;
            button38.BackColor = Color.Gainsboro;
            button39.BackColor = Color.Gainsboro;
            button40.BackColor = Color.Gainsboro;
            button41.BackColor = Color.Gainsboro;
            button50.BackColor = Color.Gainsboro;
            button51.BackColor = Color.Gainsboro;
            button52.BackColor = Color.Gainsboro;
            button53.BackColor = Color.Gainsboro;
            button54.BackColor = Color.Gainsboro;
            button55.BackColor = Color.Gainsboro;
            button56.BackColor = Color.Gainsboro;
            button57.BackColor = Color.Gainsboro;
            button59.BackColor = Color.Gainsboro;
            button60.BackColor = Color.Gainsboro;
            button61.BackColor = Color.Gainsboro;
            button62.BackColor = Color.Gainsboro;
            button63.BackColor = Color.Gainsboro;
            button64.BackColor = Color.Gainsboro;
            button65.BackColor = Color.Gainsboro;
            button66.BackColor = Color.Gainsboro;
        }

        private void button57_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Maximum Invitees for the spot","Invitees",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DateTime idate1 = dateTimePicker1.Value;
                //MessageBox.Show(idate1.ToShortDateString());
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Meeting(MeetingId,MaxInvitees,Date,slot) values(@MeetingId,@MaxInvitees,@Date,@slot)", con);
                    cmd.Parameters.AddWithValue("@MeetingId", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaxInvitees", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Date", idate1.ToShortDateString());
                    cmd.Parameters.AddWithValue("@slot", b);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    SqlCommand cmd1 = new SqlCommand("insert into MeetingCapacity(MeetingId,No_of_participant) values(@MeetingId,@No_of_participant)", con);
                    cmd1.Parameters.AddWithValue("@MeetingId", textBox2.Text.Trim());
                    cmd1.Parameters.AddWithValue("@No_of_participant",1);
                    dr = cmd1.ExecuteReader();
                    MessageBox.Show("Your Available Slot is Defined;Please Share Meeting Id with users\n your Meeting Id:"+textBox2.Text.Trim(), "CalenderSlotBookingServices", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.Show();
                }
                catch(Exception ex)
                {
                    
                    MessageBox.Show("Meeiting Id exists;It should be unique ","Meeting Id",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                con.Close();
            }
            
        }
    }
}

