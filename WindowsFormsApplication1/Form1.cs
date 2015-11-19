using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    // Создание интерфейса программы
    interface IPayroll
    {
        float Earnings(float rateMonth,int rateDay,int dayWorked);
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

          private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Расчет почасам
        private void button1_Click(object sender, EventArgs e)
        {
            IPayroll Horly = new Hourly();

            int clock = Convert.ToInt32(textBox1.Text);
            int payment = Convert.ToInt32(textBox2.Text);
            int one = 1;

            label4.Text = Horly.Earnings(clock, payment, one).ToString();
        }
        // Расчет по окладу
        private void button2_Click(object sender, EventArgs e)
        {
            IPayroll Salary = new Salary();

            float ratemonth = Convert.ToInt32(textBox3.Text);
            int rateday = Convert.ToInt32(numericUpDown1.Text);
            int dayworked = Convert.ToInt32(numericUpDown2.Text);

            if (dayworked > rateday)
            {
                numericUpDown2.Text = rateday.ToString();
                dayworked = rateday;

            }
    
            label10.Text = Salary.Earnings(ratemonth, rateday, dayworked).ToString();
        }
        // Расчет по  ставке
        private void button3_Click(object sender, EventArgs e)
        {
            IPayroll Rate = new Rate();

            int change = Convert.ToInt32(textBox5.Text);
            int cost = Convert.ToInt32(textBox4.Text);
            int one = 1;

            label12.Text = Rate.Earnings(change, cost, one).ToString();
        }


        // Проверка условий ввода
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
