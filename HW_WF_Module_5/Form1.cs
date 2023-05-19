using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_WF_Module_5
{
    public partial class Form1 : Form
    {
        public StoreProducts products;
        double summ = 0;
        Form2 form2;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = new StoreProducts();
            products.AddProduct("VideoCard", "Nvidia RTX 3090", "24 gb, GDDR6X , 19500MhZ , 750W" , 43000.00);
            products.AddProduct("CPU", "Intel Core i(-13900K", "Socet LGA1700 , 3GZ - 5.8 GZ", 27000.00);
            products.AddProduct("KeyBoard", "Apex TKL WireLess", "Magnit-type, PBT , Steelseries OmniPoint", 12999);
  
            
            comboBox_Products.Items.Clear();
            
            foreach(var el in products.products) 
            {
                comboBox_Products.Items.Add(el.NameProduct);
            }

            button_Add.Enabled = false;
            button_Remove.Enabled = false;
            
        }











      public  class StoreProducts
        {
            public static  int Count = 0;
            public int GetCount()
            {
                return Count;
            }
            public List<Product> products = new List<Product>();
            public StoreProducts(List<Product> products)
            {
                this.products = products;
            }
            public StoreProducts()
            { }

            public void AddProduct(string category,string name, string describe, double price )
            {
                Product product = new Product();
                product.NameProduct = name;
                product.PriceProduct = price;
                product.DescribeProduct = describe;
                product.CategoryProduct = category;
                products.Add(product);
                Count++;
            }

            public void RemoveProduct(int index)
            {
                products.RemoveAt(index);
                
            }
            public void ChangeName(int index, string name)
            { 
            products.ElementAt(index).NameProduct = name;
            }
            public void ChangeDescribeProduct(int index, string describe)
            {
                products[index].DescribeProduct = describe;
            }
            public void ChangePriceProduct(int index, double price)
            {
                products.ElementAt(index).PriceProduct = price;
            }
            public void ChangeCategoryproduct(int index, string category)
            {
                products.ElementAt(index).CategoryProduct = category;
            }

        }



      public  class Product
        {
            
            public string CategoryProduct { get; set; }
            public string NameProduct { get; set; }
            public double PriceProduct { get; set; }
            public string DescribeProduct { get; set; }
            public override string ToString()
            {
                return CategoryProduct + "\t" +NameProduct+"\t" ;
            }

        }

        private void comboBox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox_Info_Product.Text = string.Empty;
            textBox_Info_Product.Text = products.products[comboBox_Products.SelectedIndex].NameProduct + " \t"+
                 products.products[comboBox_Products.SelectedIndex].PriceProduct.ToString() + "  грн.\t";

            button_Add.Enabled = true;
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            listBox_Shop_List.Items.Add(products.products[comboBox_Products.SelectedIndex].NameProduct);
            listBox_Shop_List_Price.Items.Add(products.products[comboBox_Products.SelectedIndex].PriceProduct);
            listBox_Shop_List_Grn.Items.Add(".грн");
            label1.Text = String.Empty;
            summ += products.products[comboBox_Products.SelectedIndex].PriceProduct;
            label1.Text = summ.ToString() + " грн.";
            
           
        }

        private void listBox_Shop_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Remove.Enabled = true;
            listBox_Shop_List_Price.SelectedIndex = listBox_Shop_List.SelectedIndex;
            listBox_Shop_List_Grn.SelectedIndex = listBox_Shop_List.SelectedIndex;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            summ -= double.Parse(listBox_Shop_List_Price.SelectedItem.ToString());

            listBox_Shop_List_Grn.Items.RemoveAt(listBox_Shop_List.SelectedIndex);
            listBox_Shop_List_Price.Items.RemoveAt(listBox_Shop_List.SelectedIndex);
            listBox_Shop_List.Items.RemoveAt(listBox_Shop_List.SelectedIndex);
            
            label1.Text = summ.ToString() + " грн.";
            button_Remove.Enabled = false;
        }

        private void listBox_Shop_List_Price_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }



        private void button_NextForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(products.products);
            form2.Show();         

            button_Add.Enabled = false;
            button_Remove.Enabled = false;

        }

        private void comboBox_Products_MouseEnter(object sender, EventArgs e)
        {
            comboBox_Products.Items.Clear();

            foreach (var el in products.products)
            {
                comboBox_Products.Items.Add(el.NameProduct);
            }
        }
    }
}
