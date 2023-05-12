namespace DBInterfaces
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openButton = new System.Windows.Forms.Button();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderProfile = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(82, 78);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Войти";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // profileTextBox
            // 
            this.profileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileTextBox.Location = new System.Drawing.Point(47, 49);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.PlaceholderText = "Введите профиль";
            this.profileTextBox.Size = new System.Drawing.Size(153, 23);
            this.profileTextBox.TabIndex = 2;
            this.profileTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.profileValidating);
            // 
            // errorProviderProfile
            // 
            this.errorProviderProfile.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderProfile.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 161);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openButton;
        private TextBox profileTextBox;
        private ErrorProvider errorProviderProfile;
    }
}