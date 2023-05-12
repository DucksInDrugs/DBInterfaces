namespace DBInterfaces
{
    partial class Form2
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
            this.insertPharmacist = new System.Windows.Forms.Button();
            this.insertPurchases = new System.Windows.Forms.Button();
            this.insertAssortiment = new System.Windows.Forms.Button();
            this.insertPharmacy = new System.Windows.Forms.Button();
            this.insertPurchase = new System.Windows.Forms.Button();
            this.insertCategory = new System.Windows.Forms.Button();
            this.insertDevice = new System.Windows.Forms.Button();
            this.insertGood = new System.Windows.Forms.Button();
            this.insertActiveSubstInDrug = new System.Windows.Forms.Button();
            this.insertDrug = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.insertActiveSubst = new System.Windows.Forms.Button();
            this.insertView = new System.Windows.Forms.Button();
            this.insertLabel = new System.Windows.Forms.Label();
            this.showLabel = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.userChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertPharmacist
            // 
            this.insertPharmacist.Location = new System.Drawing.Point(26, 286);
            this.insertPharmacist.Name = "insertPharmacist";
            this.insertPharmacist.Size = new System.Drawing.Size(98, 23);
            this.insertPharmacist.TabIndex = 0;
            this.insertPharmacist.Text = "Фармацевт";
            this.insertPharmacist.UseVisualStyleBackColor = true;
            // 
            // insertPurchases
            // 
            this.insertPurchases.Location = new System.Drawing.Point(244, 257);
            this.insertPurchases.Name = "insertPurchases";
            this.insertPurchases.Size = new System.Drawing.Size(70, 23);
            this.insertPurchases.TabIndex = 1;
            this.insertPurchases.Text = "Покупки";
            this.insertPurchases.UseVisualStyleBackColor = true;
            this.insertPurchases.Click += new System.EventHandler(this.insertPurchases_Click);
            // 
            // insertAssortiment
            // 
            this.insertAssortiment.Location = new System.Drawing.Point(348, 286);
            this.insertAssortiment.Name = "insertAssortiment";
            this.insertAssortiment.Size = new System.Drawing.Size(75, 23);
            this.insertAssortiment.TabIndex = 2;
            this.insertAssortiment.Text = "Наличие";
            this.insertAssortiment.UseVisualStyleBackColor = true;
            // 
            // insertPharmacy
            // 
            this.insertPharmacy.Location = new System.Drawing.Point(429, 286);
            this.insertPharmacy.Name = "insertPharmacy";
            this.insertPharmacy.Size = new System.Drawing.Size(75, 23);
            this.insertPharmacy.TabIndex = 3;
            this.insertPharmacy.Text = "Аптеки";
            this.insertPharmacy.UseVisualStyleBackColor = true;
            // 
            // insertPurchase
            // 
            this.insertPurchase.Location = new System.Drawing.Point(320, 257);
            this.insertPurchase.Name = "insertPurchase";
            this.insertPurchase.Size = new System.Drawing.Size(184, 23);
            this.insertPurchase.TabIndex = 4;
            this.insertPurchase.Text = "Приобретение одного товара";
            this.insertPurchase.UseVisualStyleBackColor = true;
            // 
            // insertCategory
            // 
            this.insertCategory.Location = new System.Drawing.Point(343, 228);
            this.insertCategory.Name = "insertCategory";
            this.insertCategory.Size = new System.Drawing.Size(161, 23);
            this.insertCategory.TabIndex = 5;
            this.insertCategory.Text = "Категории медикаментов";
            this.insertCategory.UseVisualStyleBackColor = true;
            this.insertCategory.Click += new System.EventHandler(this.insertCategory_Click);
            // 
            // insertDevice
            // 
            this.insertDevice.Location = new System.Drawing.Point(195, 286);
            this.insertDevice.Name = "insertDevice";
            this.insertDevice.Size = new System.Drawing.Size(147, 23);
            this.insertDevice.TabIndex = 6;
            this.insertDevice.Text = "Медицинские приборы";
            this.insertDevice.UseVisualStyleBackColor = true;
            // 
            // insertGood
            // 
            this.insertGood.Location = new System.Drawing.Point(130, 286);
            this.insertGood.Name = "insertGood";
            this.insertGood.Size = new System.Drawing.Size(59, 23);
            this.insertGood.TabIndex = 7;
            this.insertGood.Text = "Товары";
            this.insertGood.UseVisualStyleBackColor = true;
            // 
            // insertActiveSubstInDrug
            // 
            this.insertActiveSubstInDrug.Location = new System.Drawing.Point(128, 228);
            this.insertActiveSubstInDrug.Name = "insertActiveSubstInDrug";
            this.insertActiveSubstInDrug.Size = new System.Drawing.Size(214, 23);
            this.insertActiveSubstInDrug.TabIndex = 8;
            this.insertActiveSubstInDrug.Text = "Активные вещества в медикаменте";
            this.insertActiveSubstInDrug.UseVisualStyleBackColor = true;
            this.insertActiveSubstInDrug.Click += new System.EventHandler(this.insertActiveSubstInDrug_Click);
            // 
            // insertDrug
            // 
            this.insertDrug.Location = new System.Drawing.Point(26, 228);
            this.insertDrug.Name = "insertDrug";
            this.insertDrug.Size = new System.Drawing.Size(96, 23);
            this.insertDrug.TabIndex = 9;
            this.insertDrug.Text = "Медикаменты";
            this.insertDrug.UseVisualStyleBackColor = true;
            this.insertDrug.Click += new System.EventHandler(this.insertDrug_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Медикаменты",
            "Активные вещества в медикаментах",
            "Категории медикаментов",
            "ViewModel",
            "Активные вещества",
            "Покупки",
            "Приобретение одного товара",
            "Фармацевт",
            "Товары",
            "Медицинские приборы",
            "Наличие",
            "Аптеки"});
            this.comboBox1.Location = new System.Drawing.Point(136, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // insertActiveSubst
            // 
            this.insertActiveSubst.Location = new System.Drawing.Point(107, 257);
            this.insertActiveSubst.Name = "insertActiveSubst";
            this.insertActiveSubst.Size = new System.Drawing.Size(131, 23);
            this.insertActiveSubst.TabIndex = 11;
            this.insertActiveSubst.Text = "Активные вещества";
            this.insertActiveSubst.UseVisualStyleBackColor = true;
            this.insertActiveSubst.Click += new System.EventHandler(this.insertActiveSubst_Click);
            // 
            // insertView
            // 
            this.insertView.Location = new System.Drawing.Point(26, 257);
            this.insertView.Name = "insertView";
            this.insertView.Size = new System.Drawing.Size(75, 23);
            this.insertView.TabIndex = 12;
            this.insertView.Text = "ViewModel";
            this.insertView.UseVisualStyleBackColor = true;
            this.insertView.Click += new System.EventHandler(this.insertView_Click);
            // 
            // insertLabel
            // 
            this.insertLabel.AutoSize = true;
            this.insertLabel.Location = new System.Drawing.Point(136, 194);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(259, 15);
            this.insertLabel.TabIndex = 13;
            this.insertLabel.Text = "Открыть форму для вставки нового элемента";
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Location = new System.Drawing.Point(142, 41);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(247, 15);
            this.showLabel.TabIndex = 14;
            this.showLabel.Text = "Просмотр имеющихся значений в таблице";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(228, 97);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(375, 12);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(144, 23);
            this.userChange.TabIndex = 16;
            this.userChange.Text = "Сменить пользователя";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 332);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.insertView);
            this.Controls.Add(this.insertActiveSubst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.insertDrug);
            this.Controls.Add(this.insertActiveSubstInDrug);
            this.Controls.Add(this.insertGood);
            this.Controls.Add(this.insertDevice);
            this.Controls.Add(this.insertCategory);
            this.Controls.Add(this.insertPurchase);
            this.Controls.Add(this.insertPharmacy);
            this.Controls.Add(this.insertAssortiment);
            this.Controls.Add(this.insertPurchases);
            this.Controls.Add(this.insertPharmacist);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button insertPharmacist;
        private Button insertPurchases;
        private Button insertAssortiment;
        private Button insertPharmacy;
        private Button insertPurchase;
        private Button insertCategory;
        private Button insertDevice;
        private Button insertGood;
        private Button insertActiveSubstInDrug;
        private Button insertDrug;
        private ComboBox comboBox1;
        private Button insertActiveSubst;
        private Button insertView;
        private Label insertLabel;
        private Label showLabel;
        private Button buttonOpen;
        private Button userChange;
    }
}