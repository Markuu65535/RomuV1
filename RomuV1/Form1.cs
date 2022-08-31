using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace RomuV1
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess("Growtopia.exe");
            if (m.OpenProcess("Growtopia.exe"))
            {
                label1.Text = "Attached";
                label1.ForeColor = Color.Green;
                m.WriteMemory("base+55E1B9", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+55E1B9", "bytes", "75 08");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                m.WriteMemory("base+6B7545", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+6B7545", "bytes", "75 0B");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                m.WriteMemory("base+6C7597", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+6C7597", "bytes", "74 5D");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                m.WriteMemory("base+666372", "bytes", "73 05");
            }
            else
            {
                m.WriteMemory("base+666372", "bytes", "74 05");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                m.WriteMemory("base+6B7545", "bytes", "90 90");
                m.WriteMemory("base+6C7597", "bytes", "90 90");
                m.WriteMemory("base+666372", "bytes", "73 05");
            }
            else
            {
                m.WriteMemory("base+6B7545", "bytes", "75 0B");
                m.WriteMemory("base+6C7597", "bytes", "74 5D");
                m.WriteMemory("base+666372", "bytes", "74 05");
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                m.WriteMemory("base+6C85AA", "bytes", "E9 04 01 00 00 00");
            }
            else
            {
                m.WriteMemory("base+6C85AA", "bytes", "0F 84 03 01 00 00");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                m.WriteMemory("base+666C01", "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+666C01", "bytes", "F3 0F 5C D1");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                m.WriteMemory("base+C54298", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+C54298", "bytes", "4F 6E");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                m.WriteMemory("base+6B7539", "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+6B7539", "bytes", "80 79 12 00");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                m.WriteMemory("base+54EA09", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+54EA09", "bytes", "75 0B");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                m.WriteMemory("base+6A7069", "bytes", "90 90");
            }
            else
            {
                m.WriteMemory("base+6A7069", "bytes", "75 06");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                m.WriteMemory("base+6687E8", "bytes", "75 0E");
            }
            else
            {
                m.WriteMemory("base+6687E8", "bytes", "74 0E");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                m.WriteMemory("base+6984E6", "bytes", "75 0B");
            }
            else
            {
                m.WriteMemory("base+6984E6", "bytes", "74 0B");
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                m.WriteMemory("base+54E72F", "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+54E72F", "bytes", "80 B8 79 01 00 00 00");
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                m.WriteMemory("base+65A77E", "bytes", "75 13");
            }
            else
            {
                m.WriteMemory("base+65A77E", "bytes", "74 13");
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                m.WriteMemory("base+66A0F8", "bytes", "75 6B");
            }
            else
            {
                m.WriteMemory("base+66A0F8", "bytes", "74 6B");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                m.WriteMemory("base+671F59", "bytes", "0F 85 88 00 00 00");
            }
            else
            {
                m.WriteMemory("base+671F59", "bytes", "0F 84 88 00 00 00");
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                m.WriteMemory("base+6D8308", "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory("base+6D8308", "bytes", "0F 82 49 19 00 00");
            }
        }
    }
}
