using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen_6_TID_SID_to_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showFields(int ver)
        {
            min_label.Visible = true;
            max_label.Visible = true;
            min_frame.Visible = true;
            max_frame.Visible = true;
            min_frame.Value = ver;
            max_frame.Minimum = ver;
            max_frame.Maximum = 100000;
            max_frame.Value = 150;
            srch.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void year_box_ValueChanged(object sender, EventArgs e)
        {
            date_message.Text = "Set the Citra RTC to " + year_box.Value + "-01-01 13:00:00";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (game.SelectedIndex)
            {
                case 0:
                    showFields(35);
                    break;
                case 1:
                    showFields(11);
                    break;
            }
        }


        private void srch_Click_1(object sender, EventArgs e)
        {
            int seconds = 0;
            TinyMT tiny = new TinyMT();
            Calculate calc = new Calculate();
            uint[] array;
            uint[] states = new uint[4];

            states[3] = UInt32.Parse(tiny_3.Text, System.Globalization.NumberStyles.HexNumber);
            states[2] = UInt32.Parse(tiny_2.Text, System.Globalization.NumberStyles.HexNumber);
            states[1] = UInt32.Parse(tiny_1.Text, System.Globalization.NumberStyles.HexNumber);
            states[0] = UInt32.Parse(tiny_0.Text, System.Globalization.NumberStyles.HexNumber);

            int tid = Convert.ToInt32(tid_box.Value);
            int sid = Convert.ToInt32(sid_box.Value);
            int delay = Convert.ToInt32(min_frame.Value);
            int frames = Convert.ToInt32(max_frame.Value);

            uint starting_range = calc.getseed(Convert.ToInt32(year_box.Value));
            uint tiny_seed = 0x00000000;
            ushort tsv = (ushort)((tid ^ sid) >> 4);
            byte trv = (byte)((tid ^ sid) & 0xF);
            string first_half = Convert.ToString(sid, 16).PadLeft(4, '0');
            string second_half = Convert.ToString(tid, 16).PadLeft(4, '0');
            string rand = (first_half + second_half).PadLeft(4, '0').ToUpper();
            uint uintrand = Convert.ToUInt32(rand, 16);
            for (uint i = starting_range; i < 0xFFFFFFFF; i++) //Search for the TinyMT seed
            {
                array = tiny.init(i);
                if (states[3] == array[3] && states[2] == array[2] && states[1] == array[1] && states[0] == array[0])
                {
                    tiny_seed = i;
                    break;
                }

            }

            //MessageBox.Show(" TinyMT seed = 0x" + (tiny_seed).ToString("X").PadLeft(8, '0')); //TinyMT seed in hex

            uint[] store_seed;
            bool stop = false;
            for (uint i = tiny_seed; i < 0xFFFFFFFF; i += 1000)
            {
                array = tiny.init(i);
                store_seed = tiny.init(i);
                for (int k = 0; k < delay; k++)
                    tiny.nextState(array);
                for (int k = delay; k < frames; k++)
                {
                    tiny.nextState(array);
                    if (tiny.temper(array) == uintrand)
                        if (MessageBox.Show("Date -> "  + calc.secondsToDate(seconds, Convert.ToInt32(year_box.Value)) +
                            "\n" +
                            "\nTinyMT Initial State:" +
                            "\n [3] " + store_seed[3].ToString("X").PadLeft(8, '0') +
                            "\n [2] " + store_seed[2].ToString("X").PadLeft(8, '0') +
                            "\n [1] " + store_seed[1].ToString("X").PadLeft(8, '0') +
                            "\n [0] " + store_seed[0].ToString("X").PadLeft(8, '0') +
                            "\n" +
                            "\nFrame = " + k +
                            "\nTID = " + Convert.ToString(tid).PadLeft(5, '0') + "   SID = " + Convert.ToString(sid).PadLeft(5, '0') +
                            "\nTSV =  " + Convert.ToString(tsv).PadLeft(4, '0') + "   TRV = " + trv.ToString("X") +
                            "\nRand# = " + (uintrand).ToString("X").PadLeft(8, '0') +
                            "\n\nContinue the research?", "Results", MessageBoxButtons.YesNo) == DialogResult.No)
                            stop = true;
                }
                seconds++;
                if (stop)
                    break;
            }

        }

        private void tiny_3_TextChanged(object sender, EventArgs e) //Needs fix
        {
            string item = tiny_3.Text;
            int n;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              item != String.Empty)
            {
                tiny_3.Text = item.Remove(item.Length - 1, 1);
                tiny_3.SelectionStart = tiny_3.Text.Length;
            }
        }

        private void tiny_2_TextChanged(object sender, EventArgs e) //Needs fix
        {
            string item = tiny_2.Text;
            int n;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              item != String.Empty)
            {
                tiny_2.Text = item.Remove(item.Length - 1, 1);
                tiny_2.SelectionStart = tiny_2.Text.Length;
            }
        }

        private void tiny_1_TextChanged(object sender, EventArgs e) //Needs fix
        {
            string item = tiny_1.Text;
            int n;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              item != String.Empty)
            {
                tiny_1.Text = item.Remove(item.Length - 1, 1);
                tiny_1.SelectionStart = tiny_1.Text.Length;
            }
        }

        private void tiny_0_TextChanged(object sender, EventArgs e) //Needs fix
        {
            string item = tiny_0.Text;
            int n;
            if (!int.TryParse(item, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              item != String.Empty)
            {
                tiny_0.Text = item.Remove(item.Length - 1, 1);
                tiny_0.SelectionStart = tiny_0.Text.Length;
            }
        }
    }
}