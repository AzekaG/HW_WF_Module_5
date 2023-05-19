using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW_WF_Module_5.Form1;

namespace HW_WF_Module_5
{
    public partial class Form2 : Form
    {
       public List<Product> storeTemp;
        public Form2(List<Product> obj)
        {
            storeTemp = obj;
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Информация о продукте";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Введите категорию продукта";
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = "Введите модель продукта";
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = "Введите описание продукта";
            textBox5.ForeColor = Color.Gray;
            textBox5.Text = "Введите цену продукта";
            foreach (var el in storeTemp)
            {
                comboBox2.Items.Add(el.NameProduct);
            }
            button2.Enabled = false;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Text = storeTemp.ElementAt(comboBox2.SelectedIndex).ToString()+
                storeTemp.ElementAt(comboBox2.SelectedIndex).DescribeProduct;
            button2.Enabled = true;
        }

    

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите категорию продукта")
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = "Введите категорию продукта";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите модель продукта")
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = "Введите модель продукта";

            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите описание продукта")
            {
                textBox4.Text = string.Empty;
                textBox4.ForeColor = Color.Black;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.ForeColor = Color.Gray;
                textBox4.Text = "Введите описание продукта";

            }
        }


        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Введите цену продукта")
            {
                textBox5.Text = string.Empty;
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.ForeColor = Color.Gray;
                textBox5.Text = "Введите цену продукта";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!=string.Empty && textBox2.Text!= "Введите категорию продукта")
            {
                storeTemp.ElementAt(comboBox2.SelectedIndex).CategoryProduct = textBox2.Text;
            }
            if (textBox3.Text != string.Empty && textBox3.Text != "Введите модель продукта")
            {
                storeTemp.ElementAt(comboBox2.SelectedIndex).NameProduct = textBox3.Text;
            }
            if (textBox4.Text != string.Empty && textBox4.Text != "Введите описание продукта")
            {
                storeTemp.ElementAt(comboBox2.SelectedIndex).DescribeProduct = textBox4.Text;
            }
            if (textBox5.Text != string.Empty && textBox5.Text != "Введите цену продукта")
            {

                bool Flag = double.TryParse(textBox5.Text, out var flagValue);
                if(Flag)   storeTemp.ElementAt(comboBox2.SelectedIndex).PriceProduct = flagValue;
           
            }
            comboBox2.Items.Clear();
            foreach (var el in storeTemp)
            {
                comboBox2.Items.Add(el.NameProduct);
            }
            button2.Enabled = false;

            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Информация о продукте";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Введите категорию продукта";
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = "Введите модель продукта";
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = "Введите описание продукта";
            textBox5.ForeColor = Color.Gray;
            textBox5.Text = "Введите цену продукта";
            MessageBox.Show("Изменено");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool localFlag1 = true , localFlag2 = true , localFlag3 = true , localFlag4 = true;
            string category = string.Empty, name = string.Empty, describe = string.Empty;
            double price = 0;

            if (textBox2.Text != string.Empty && textBox2.Text != "Введите категорию продукта")
            {
                category = textBox2.Text;
                localFlag1 = true;
            }
            else
            {
                localFlag1 = false;
                MessageBox.Show("Введите корректную категорию");
            }

            if (textBox3.Text != string.Empty && textBox3.Text != "Введите модель продукта")
            {
                name = textBox3.Text;
                localFlag2 = true;
            }
            else
            {
                localFlag2 = false;
                MessageBox.Show("Введите корректную модель");
            }
            if (textBox4.Text != string.Empty && textBox4.Text != "Введите описание продукта")
            {
                describe = textBox4.Text;
                localFlag3 = true;
            }
            else
            {
                localFlag3 = false;
                MessageBox.Show("Введите ккорректное описание");
            }
            if (textBox5.Text != string.Empty && textBox5.Text != "Введите цену продукта")
            {

                bool Flag = double.TryParse(textBox5.Text, out var flagValue);
                if (Flag)
                {
                    price = flagValue;
                    localFlag4 = true;
                }

            }
            else
            {
                localFlag4 = false;
                MessageBox.Show("Введите корректную цену");
            }
            if (localFlag1 && localFlag2 && localFlag3 && localFlag4)
            {
                Product temp = new Product();
                temp.NameProduct = name;
                temp.PriceProduct = price;
                temp.DescribeProduct = describe;
                temp.CategoryProduct = category;
                storeTemp.Add(temp);
            }


            comboBox2.Items.Clear();
            foreach (var el in storeTemp)
            {
                comboBox2.Items.Add(el.NameProduct);
            }
            button2.Enabled = false;



            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Информация о продукте";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Введите категорию продукта";
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = "Введите модель продукта";
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = "Введите описание продукта";
            textBox5.ForeColor = Color.Gray;
            textBox5.Text = "Введите цену продукта";
            MessageBox.Show("Добавлено");


        }
        public List<Product> GetStoreProducts()
        {
            return storeTemp;
        }
    }
}
