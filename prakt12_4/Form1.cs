using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prakt12_4
{
    public partial class Form1 : Form
    {
        private Pokupatel pokupatel;
        public Form1()
        {
            InitializeComponent();
            pokupatel = new Pokupatel("", 0, 0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = textBox1.Text;
                double productPrice = Convert.ToDouble(textBox2.Text);
                int quantity = Convert.ToInt32(textBox3.Text);
                double wallet = Convert.ToDouble(textBox4.Text);

                pokupatel = new Pokupatel(productName, productPrice, quantity, wallet);

                pokupatel.PurchaseInfo();
                pokupatel.Buy(quantity);
                pokupatel.CheckMood();
            }
            catch
            {
                MessageBox.Show("Введено недопустимое значение в одно из полей", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
