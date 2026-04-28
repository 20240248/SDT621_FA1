namespace Question3
{
    public partial class Form1 : Form
    {
        private List<string> languages = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string langauge;

            langauge = txtLanguage.Text;
            // Ensure language is valid
            if (!string.IsNullOrWhiteSpace(langauge))
            {
                // Ensure no duplicates are added
                if (languages.Contains(langauge))
                {
                    MessageBox.Show("Language already exists in the list");
                    return;
                }

                languages.Add(langauge);
                lstLanguages.Items.Add(langauge);
                txtLanguage.Clear();
            } else
            {
                MessageBox.Show("Please enter a valid language");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItems.Count > 0)
            { 
                ListViewItem language = lstLanguages.SelectedItems[0];
                languages.Remove(language.Text);
                lstLanguages.Items.Remove(language);

                lblRemoveOutput.Text = $"Removed {language.Text} at {DateTime.Now}";
            }

        }
    }
}
