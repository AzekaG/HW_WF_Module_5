namespace HW_WF_Module_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Products = new System.Windows.Forms.ComboBox();
            this.listBox_Shop_List = new System.Windows.Forms.ListBox();
            this.textBox_Info_Product = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_NextForm = new System.Windows.Forms.Button();
            this.listBox_Shop_List_Price = new System.Windows.Forms.ListBox();
            this.listBox_Shop_List_Grn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox_Products
            // 
            this.comboBox_Products.FormattingEnabled = true;
            this.comboBox_Products.Location = new System.Drawing.Point(759, 14);
            this.comboBox_Products.Name = "comboBox_Products";
            this.comboBox_Products.Size = new System.Drawing.Size(239, 21);
            this.comboBox_Products.TabIndex = 0;
            this.comboBox_Products.SelectedIndexChanged += new System.EventHandler(this.comboBox_Products_SelectedIndexChanged);
            this.comboBox_Products.MouseEnter += new System.EventHandler(this.comboBox_Products_MouseEnter);
            // 
            // listBox_Shop_List
            // 
            this.listBox_Shop_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Shop_List.FormattingEnabled = true;
            this.listBox_Shop_List.Location = new System.Drawing.Point(12, 14);
            this.listBox_Shop_List.Name = "listBox_Shop_List";
            this.listBox_Shop_List.Size = new System.Drawing.Size(372, 416);
            this.listBox_Shop_List.TabIndex = 1;
            this.listBox_Shop_List.SelectedIndexChanged += new System.EventHandler(this.listBox_Shop_List_SelectedIndexChanged);
            // 
            // textBox_Info_Product
            // 
            this.textBox_Info_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Info_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Info_Product.Location = new System.Drawing.Point(514, 12);
            this.textBox_Info_Product.Multiline = true;
            this.textBox_Info_Product.Name = "textBox_Info_Product";
            this.textBox_Info_Product.ReadOnly = true;
            this.textBox_Info_Product.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Info_Product.Size = new System.Drawing.Size(227, 92);
            this.textBox_Info_Product.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(389, 14);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(119, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(390, 43);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(118, 23);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "Убрать";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 298);
            this.label1.TabIndex = 6;
            this.label1.Text = "00.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_NextForm
            // 
            this.button_NextForm.Location = new System.Drawing.Point(759, 347);
            this.button_NextForm.Name = "button_NextForm";
            this.button_NextForm.Size = new System.Drawing.Size(239, 91);
            this.button_NextForm.TabIndex = 7;
            this.button_NextForm.Text = "Следующая форма";
            this.button_NextForm.UseVisualStyleBackColor = true;
            this.button_NextForm.Click += new System.EventHandler(this.button_NextForm_Click);
            // 
            // listBox_Shop_List_Price
            // 
            this.listBox_Shop_List_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Shop_List_Price.Enabled = false;
            this.listBox_Shop_List_Price.FormattingEnabled = true;
            this.listBox_Shop_List_Price.Location = new System.Drawing.Point(240, 14);
            this.listBox_Shop_List_Price.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.listBox_Shop_List_Price.Name = "listBox_Shop_List_Price";
            this.listBox_Shop_List_Price.Size = new System.Drawing.Size(143, 416);
            this.listBox_Shop_List_Price.TabIndex = 8;
            // 
            // listBox_Shop_List_Grn
            // 
            this.listBox_Shop_List_Grn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Shop_List_Grn.Enabled = false;
            this.listBox_Shop_List_Grn.FormattingEnabled = true;
            this.listBox_Shop_List_Grn.Location = new System.Drawing.Point(346, 14);
            this.listBox_Shop_List_Grn.Name = "listBox_Shop_List_Grn";
            this.listBox_Shop_List_Grn.Size = new System.Drawing.Size(37, 416);
            this.listBox_Shop_List_Grn.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_WF_Module_5.Properties.Resources._16057914765fb66ef490a1a8_99433198;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.listBox_Shop_List_Grn);
            this.Controls.Add(this.listBox_Shop_List_Price);
            this.Controls.Add(this.button_NextForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Info_Product);
            this.Controls.Add(this.listBox_Shop_List);
            this.Controls.Add(this.comboBox_Products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Products;
        private System.Windows.Forms.ListBox listBox_Shop_List;
        private System.Windows.Forms.TextBox textBox_Info_Product;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_NextForm;
        private System.Windows.Forms.ListBox listBox_Shop_List_Price;
        private System.Windows.Forms.ListBox listBox_Shop_List_Grn;
    }
}

