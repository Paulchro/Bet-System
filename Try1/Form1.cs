using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try1
{
    public partial class Form1 : Form
    {
        List<Label> labellist = new List<Label>();
        int y = 0;
        List<double> list = new List<double>();
        List<int> check = new List<int>();
        public Form1()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                textBox12.Enabled = false;
                checkBox1.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                textBox10.Enabled = false;
                checkBox2.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                textBox9.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                textBox8.Enabled = false;
                checkBox4.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                textBox7.Enabled = false;
                checkBox5.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                textBox6.Enabled = false;
                checkBox6.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox5.Enabled = false;
                checkBox7.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox4.Enabled = false;
                checkBox8.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Enabled = false;
                checkBox9.Enabled = false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                checkBox10.Enabled = false;
            }




        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "1";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Text = "2";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Text = "3";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Text = "4";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Text = "5";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Text = "6";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Text = "7";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Text = "8";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Text = "9";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Text = "10";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox12.Enabled = true;
            checkBox1.Enabled = true;
            if (String.IsNullOrEmpty(textBox11.Text))
            {
                textBox12.Clear();
                textBox12.Enabled = false;
                checkBox1.Enabled = false;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = true;
            checkBox2.Enabled = true;
            if (String.IsNullOrEmpty(textBox12.Text))
            {
                textBox10.Clear();
                textBox10.Enabled = false;
                checkBox2.Enabled = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            checkBox3.Enabled = true;
            if (String.IsNullOrEmpty(textBox10.Text))
            {
                textBox9.Clear();
                textBox9.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            checkBox4.Enabled = true;
            if (String.IsNullOrEmpty(textBox9.Text))
            {
                textBox8.Clear();
                textBox8.Enabled = false;
                checkBox4.Enabled = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            checkBox5.Enabled = true;
            if (String.IsNullOrEmpty(textBox8.Text))
            {
                textBox7.Clear();
                textBox7.Enabled = false;
                checkBox5.Enabled = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            checkBox6.Enabled = true;
            if (String.IsNullOrEmpty(textBox7.Text))
            {
                textBox6.Clear();
                textBox6.Enabled = false;
                checkBox6.Enabled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            checkBox7.Enabled = true;
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                textBox5.Clear();
                textBox5.Enabled = false;
                checkBox7.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            checkBox8.Enabled = true;
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                textBox4.Clear();
                textBox4.Enabled = false;
                checkBox8.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            checkBox9.Enabled = true;
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Enabled = false;
                textBox3.Clear();
                checkBox9.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            checkBox10.Enabled = true;
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                
                checkBox10.Enabled = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<double> results = new List<double>();
           
            y = 0;
            double res = 1;
            double last = 0;
            int i = 1;
            int count = 0;
            foreach (Label _label in this.Controls.OfType<Label>().Where(a => a.Name == "Label" + y.ToString()).Select(a => a).ToArray())
            {
                Label l = labellist.ElementAt(y);
                labellist.RemoveAt(y);
                l.Dispose();
                
            }
            list.Clear();
            check.Clear();


            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text != string.Empty && textBox.Enabled == true)
                    { 
                        list.Add(Convert.ToDouble(textBox.Text));
                    }
                }
            }
            foreach (Control f in this.Controls)
            {
                if (f is CheckBox)
                {
                    CheckBox checkBox = f as CheckBox;
                    if (checkBox.Checked != false)
                    
                        check.Add(Convert.ToInt32(checkBox.Text));
                }
            }
            check.Reverse();
           
            if (check.Count > list.Count || numericUpDown1.Text.Length == 0)
            {
                label13.Text = "Wrong Input";
            }
            else
            {
                foreach (var item in check)
                {
                    var result = Combinations(list, item).ToList();
                    foreach (var d in result)
                    {
                        foreach (var c in d)
                        {
                            res *= c;
                            
                        }
                        last += res;
                        res = 1;
                        count++;

                    }
                    Label labelnew = new Label();
                    labelnew.Location = new Point(130, (i * 26));
                    labelnew.Name = "Label" + y.ToString();
                    labelnew.Text = "\nBet System " + item.ToString() + " ,possible win " + ": " + (last * Convert.ToDouble(numericUpDown1.Text)).ToString() + "€";
                    labelnew.AutoSize = true;
                    this.Controls.Add(labelnew);
                    labellist.Add(labelnew);
                    i++;
                    res = 1;
                    last = 0;
                    
                }
                label15.Text = "Bet total: " + ((double)count * Convert.ToDouble(numericUpDown1.Text)).ToString() + "€";
            }
            
            
        }
        public static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in Combinations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
