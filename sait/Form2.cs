using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisha_bar
{
    public partial class Form2 : Form
    {
        List<string>smet=new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        double smetka =0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                smetka+=5.50*int.Parse(textBox1.Text);
                smet.Add($"PILI SAS ZELI 5,50LV x {textBox1.Text}");
            }
            if (checkBox2.Checked)
            {
                smetka += 2 * int.Parse(textBox2.Text);
                smet.Add($"SKEMBE CHORBA 2LV x {textBox2.Text}");
            }
            if (checkBox3.Checked)
            {
                smetka += 3.33 * int.Parse(textBox3.Text);
                smet.Add($"KALMARI PO RODOPSKI 3,33LV x {textBox3.Text}");
            }
            if (checkBox4.Checked)
            {
                smetka += 6 * int.Parse(textBox4.Text);
                smet.Add($"SKARIDI 6LV x {textBox4.Text}");
            }
            if (checkBox5.Checked)
            {
                smetka += 2 * int.Parse(textBox5.Text);
                smet.Add($"GROZDOVA 2LV x {textBox5.Text}");
            }
            if (checkBox6.Checked)
            {
                smetka += 3 * int.Parse(textBox6.Text);
                smet.Add($"UISKI 3LV x {textBox6.Text}");
            }
            if (checkBox7.Checked)
            {
                smetka += 3.50 * int.Parse(textBox7.Text);
                smet.Add($"VODKA 3,50LV x {textBox7.Text}");
            }
            if (checkBox8.Checked)
            {
                smetka += 2.60 * int.Parse(textBox8.Text);
                smet.Add($"ANASONLIKA 2,60LV x {textBox8.Text}");
            }
            if (checkBox10.Checked)
            {
                smetka += 20.99 * int.Parse(textBox11.Text);
                smet.Add($"NARGILE sprinja 20,99LV x {textBox11.Text}");
            }
            if (checkBox11.Checked)
            {
                smetka += 21 * int.Parse(textBox10.Text);
                smet.Add($"NArga Krusha 21LV x {textBox10.Text}");
            }
            if (checkBox12.Checked)
            {
                smetka += 21 * int.Parse(textBox9.Text);
                smet.Add($"NARGA qgotka 21LV x {textBox9.Text}");
            }
            MessageBox.Show($"{string.Join(Environment.NewLine,smet)}" +
                $"\n smetkata ti e :{smetka:F2}lv");
            smetka = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
