namespace VirtualMessManager
{
    partial class Add_Bazar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Bazar));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.cb_Items = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.bt_addItems = new System.Windows.Forms.Button();
            this.addBazarCancel = new System.Windows.Forms.Button();
            this.dt_Bazar = new System.Windows.Forms.DateTimePicker();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Specific Item And Insert One by One";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(190, 118);
            this.tb_Quantity.Multiline = true;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(108, 28);
            this.tb_Quantity.TabIndex = 1;
            // 
            // cb_Items
            // 
            this.cb_Items.AutoCompleteCustomSource.AddRange(new string[] {
            "Cal(Rice)",
            "Mosur_dal(Lentil)\t",
            "Mug_dal(Green_Gram)",
            "Booter_dal(Skinned)",
            "Lanka(Chili)",
            "Laban(Salt)",
            "Jeera(Cumin)",
            "Rasun(Garlic)",
            "Aada(Ginger)",
            "Halud(Turmeric)",
            "Garam_masala(Spice_Mixture)",
            "Jej_pata(Bay_leaf)",
            "Shorsher_tel(Mustard_oil)",
            "Peaj_koli(Shallot)",
            "Lebu(Citron)",
            "Kacha_morich(Green chili)",
            "Chal_Kumro(Ash Gourd)",
            "Karola(Bitter_melon)",
            "Sheem(Broad_Beans)"});
            this.cb_Items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Items.FormattingEnabled = true;
            this.cb_Items.Items.AddRange(new object[] {
            "Cal(Rice)",
            "Mosur_dal(Lentil)\t",
            "Mug_dal(Green_Gram)",
            "Booter_dal(Skinned)",
            "Lanka(Chili)",
            "Laban(Salt)",
            "Jeera(Cumin)",
            "Rasun(Garlic)",
            "Aada(Ginger)",
            "Halud(Turmeric)",
            "Garam_masala(Spice_Mixture)",
            "Jej_pata(Bay_leaf)",
            "Shorsher_tel(Mustard_oil)",
            "Peaj_koli(Shallot)",
            "Lebu(Citron)",
            "Kacha_morich(Green chili)",
            "Chal_Kumro(Ash Gourd)",
            "Karola(Bitter_melon)",
            "Sheem(Broad_Beans)"});
            this.cb_Items.Location = new System.Drawing.Point(12, 117);
            this.cb_Items.Name = "cb_Items";
            this.cb_Items.Size = new System.Drawing.Size(160, 28);
            this.cb_Items.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // tb_Amount
            // 
            this.tb_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(314, 117);
            this.tb_Amount.Multiline = true;
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(108, 28);
            this.tb_Amount.TabIndex = 1;
            // 
            // bt_addItems
            // 
            this.bt_addItems.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_addItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_addItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addItems.Location = new System.Drawing.Point(193, 169);
            this.bt_addItems.Name = "bt_addItems";
            this.bt_addItems.Size = new System.Drawing.Size(105, 31);
            this.bt_addItems.TabIndex = 4;
            this.bt_addItems.Text = "Add Items";
            this.bt_addItems.UseVisualStyleBackColor = false;
            this.bt_addItems.Click += new System.EventHandler(this.bt_addItems_Click);
            // 
            // addBazarCancel
            // 
            this.addBazarCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBazarCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBazarCancel.Location = new System.Drawing.Point(352, 234);
            this.addBazarCancel.Name = "addBazarCancel";
            this.addBazarCancel.Size = new System.Drawing.Size(105, 31);
            this.addBazarCancel.TabIndex = 4;
            this.addBazarCancel.Text = "E&xit";
            this.addBazarCancel.UseVisualStyleBackColor = true;
            this.addBazarCancel.Click += new System.EventHandler(this.addBazarCancel_Click);
            // 
            // dt_Bazar
            // 
            this.dt_Bazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Bazar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Bazar.Location = new System.Drawing.Point(12, 54);
            this.dt_Bazar.Name = "dt_Bazar";
            this.dt_Bazar.Size = new System.Drawing.Size(121, 24);
            this.dt_Bazar.TabIndex = 5;
            // 
            // bt_back
            // 
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(232, 235);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(110, 30);
            this.bt_back.TabIndex = 6;
            this.bt_back.Text = "B&ack";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // Add_Bazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(478, 287);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.dt_Bazar);
            this.Controls.Add(this.addBazarCancel);
            this.Controls.Add(this.bt_addItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Items);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Bazar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Bazar";
            this.Load += new System.EventHandler(this.Add_Bazar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.ComboBox cb_Items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Button bt_addItems;
        private System.Windows.Forms.Button addBazarCancel;
        private System.Windows.Forms.DateTimePicker dt_Bazar;
        private System.Windows.Forms.Button bt_back;
    }
}