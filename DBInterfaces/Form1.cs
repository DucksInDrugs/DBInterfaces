namespace DBInterfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (profileTextBox.Text.ToLower().Equals("admin"))
                {
                    Form2 form = new Form2(true);
                    form.Show();
                    Hide();
                }
                else
                {
                    Form2 form = new Form2(false);
                    form.Show();
                    Hide();
                }
            }
        }

        private void profileValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(profileTextBox.Text))
            {
                e.Cancel = true;
                profileTextBox.Focus();
                errorProviderProfile.SetError(profileTextBox, "Заполните это поле");
            }
            else
            {
                e.Cancel = false;
                errorProviderProfile.SetError(profileTextBox, null);
            }
        }
    }
}