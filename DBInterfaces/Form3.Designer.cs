namespace DBInterfaces
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.медикаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медикаментыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.активныеВеществаВМедикаментахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииМедикаментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активныеВеществаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приобретениеОдногоТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фармацевтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскиеПриборыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наличиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аптекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медикаментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // медикаментыToolStripMenuItem
            // 
            this.медикаментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медикаментыToolStripMenuItem1,
            this.активныеВеществаВМедикаментахToolStripMenuItem,
            this.категорииМедикаментовToolStripMenuItem,
            this.viewModelToolStripMenuItem,
            this.активныеВеществаToolStripMenuItem,
            this.покупкиToolStripMenuItem,
            this.приобретениеОдногоТовараToolStripMenuItem,
            this.фармацевтToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.медицинскиеПриборыToolStripMenuItem,
            this.наличиеToolStripMenuItem,
            this.аптекиToolStripMenuItem});
            this.медикаментыToolStripMenuItem.Name = "медикаментыToolStripMenuItem";
            this.медикаментыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.медикаментыToolStripMenuItem.Text = "Показать";
            // 
            // медикаментыToolStripMenuItem1
            // 
            this.медикаментыToolStripMenuItem1.Name = "медикаментыToolStripMenuItem1";
            this.медикаментыToolStripMenuItem1.Size = new System.Drawing.Size(274, 22);
            this.медикаментыToolStripMenuItem1.Text = "Медикаменты";
            this.медикаментыToolStripMenuItem1.Click += new System.EventHandler(this.медикаментыToolStripMenuItem1_Click);
            // 
            // активныеВеществаВМедикаментахToolStripMenuItem
            // 
            this.активныеВеществаВМедикаментахToolStripMenuItem.Name = "активныеВеществаВМедикаментахToolStripMenuItem";
            this.активныеВеществаВМедикаментахToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.активныеВеществаВМедикаментахToolStripMenuItem.Text = "Активные вещества в медикаментах";
            this.активныеВеществаВМедикаментахToolStripMenuItem.Click += new System.EventHandler(this.активныеВеществаВМедикаментахToolStripMenuItem_Click);
            // 
            // категорииМедикаментовToolStripMenuItem
            // 
            this.категорииМедикаментовToolStripMenuItem.Name = "категорииМедикаментовToolStripMenuItem";
            this.категорииМедикаментовToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.категорииМедикаментовToolStripMenuItem.Text = "Категории медикаментов";
            this.категорииМедикаментовToolStripMenuItem.Click += new System.EventHandler(this.категорииМедикаментовToolStripMenuItem_Click);
            // 
            // viewModelToolStripMenuItem
            // 
            this.viewModelToolStripMenuItem.Name = "viewModelToolStripMenuItem";
            this.viewModelToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.viewModelToolStripMenuItem.Text = "ViewModel";
            this.viewModelToolStripMenuItem.Click += new System.EventHandler(this.viewModelToolStripMenuItem_Click);
            // 
            // активныеВеществаToolStripMenuItem
            // 
            this.активныеВеществаToolStripMenuItem.Name = "активныеВеществаToolStripMenuItem";
            this.активныеВеществаToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.активныеВеществаToolStripMenuItem.Text = "Активные вещества";
            this.активныеВеществаToolStripMenuItem.Click += new System.EventHandler(this.активныеВеществаToolStripMenuItem_Click);
            // 
            // покупкиToolStripMenuItem
            // 
            this.покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            this.покупкиToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.покупкиToolStripMenuItem.Text = "Покупки";
            this.покупкиToolStripMenuItem.Click += new System.EventHandler(this.покупкиToolStripMenuItem_Click);
            // 
            // приобретениеОдногоТовараToolStripMenuItem
            // 
            this.приобретениеОдногоТовараToolStripMenuItem.Name = "приобретениеОдногоТовараToolStripMenuItem";
            this.приобретениеОдногоТовараToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.приобретениеОдногоТовараToolStripMenuItem.Text = "Приобретение одного товара";
            this.приобретениеОдногоТовараToolStripMenuItem.Click += new System.EventHandler(this.приобретениеОдногоТовараToolStripMenuItem_Click);
            // 
            // фармацевтToolStripMenuItem
            // 
            this.фармацевтToolStripMenuItem.Name = "фармацевтToolStripMenuItem";
            this.фармацевтToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.фармацевтToolStripMenuItem.Text = "Фармацевт";
            this.фармацевтToolStripMenuItem.Click += new System.EventHandler(this.фармацевтToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // медицинскиеПриборыToolStripMenuItem
            // 
            this.медицинскиеПриборыToolStripMenuItem.Name = "медицинскиеПриборыToolStripMenuItem";
            this.медицинскиеПриборыToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.медицинскиеПриборыToolStripMenuItem.Text = "Медицинские приборы";
            this.медицинскиеПриборыToolStripMenuItem.Click += new System.EventHandler(this.медицинскиеПриборыToolStripMenuItem_Click);
            // 
            // наличиеToolStripMenuItem
            // 
            this.наличиеToolStripMenuItem.Name = "наличиеToolStripMenuItem";
            this.наличиеToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.наличиеToolStripMenuItem.Text = "Наличие";
            this.наличиеToolStripMenuItem.Click += new System.EventHandler(this.наличиеToolStripMenuItem_Click);
            // 
            // аптекиToolStripMenuItem
            // 
            this.аптекиToolStripMenuItem.Name = "аптекиToolStripMenuItem";
            this.аптекиToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.аптекиToolStripMenuItem.Text = "Аптеки";
            this.аптекиToolStripMenuItem.Click += new System.EventHandler(this.аптекиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        public DataGridView dataGridView1;
        private ToolStripMenuItem медикаментыToolStripMenuItem;
        private ToolStripMenuItem медикаментыToolStripMenuItem1;
        private ToolStripMenuItem активныеВеществаВМедикаментахToolStripMenuItem;
        private ToolStripMenuItem категорииМедикаментовToolStripMenuItem;
        private ToolStripMenuItem viewModelToolStripMenuItem;
        private ToolStripMenuItem активныеВеществаToolStripMenuItem;
        private ToolStripMenuItem покупкиToolStripMenuItem;
        private ToolStripMenuItem приобретениеОдногоТовараToolStripMenuItem;
        private ToolStripMenuItem фармацевтToolStripMenuItem;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem медицинскиеПриборыToolStripMenuItem;
        private ToolStripMenuItem наличиеToolStripMenuItem;
        private ToolStripMenuItem аптекиToolStripMenuItem;
        public Button button1;
        public TextBox textBox1;
    }
}