using HomeAffairsDigitalIdentityProcessor;

namespace SectB_Question2
{
    public partial class rtbOutput : Form
    {
        private CitizenProfile Profile;

        public rtbOutput()
        {
            InitializeComponent();
        }

        private void btnValidateId_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please enter a valid ID");
                return;
            }

            if (!CitizenProfile.ValidateID(long.Parse(txtId.Text)))
            {
                lblValidIdOutput.Text = $"Valid ID, citizen is {CitizenProfile.CalculateAgeFromId(long.Parse(txtId.Text))}";
            }
            else
            {
                lblValidIdOutput.Text = $"Id is not valid";
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }

            if (string.IsNullOrEmpty(cbbCitizenship.Text))
            {
                MessageBox.Show("Please select a valid citizenship status");
                return;
            }

            CitizenProfile citizenProfile = new CitizenProfile(txtName.Text, long.Parse(txtId.Text), cbbCitizenship.Text);

            this.Profile = citizenProfile;
            this.Profile.SetIdValidation(true);
        }
        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            if (this.Profile == null)
            {
                MessageBox.Show("Citizen profile is not created yet.");
                return;
            }

            rtbProfileOutput.Text = this.Profile.DisplayProfile();
        }
    }
}
