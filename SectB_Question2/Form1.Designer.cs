namespace SectB_Question2
{
    partial class rtbOutput
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
            lblHeading = new Label();
            lblName = new Label();
            lblId = new Label();
            lblCitizenship = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            cbbCitizenship = new ComboBox();
            btnValidateId = new Button();
            lblValidIdOutput = new Label();
            rtbProfileOutput = new RichTextBox();
            btnGenerateProfile = new Button();
            pbCoatOfArms = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCoatOfArms).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Green;
            lblHeading.Location = new Point(457, 12);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(385, 30);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(457, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Enter your name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(457, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 25);
            lblId.TabIndex = 3;
            lblId.Text = "Enter your ID:";
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCitizenship.Location = new Point(457, 135);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(204, 25);
            lblCitizenship.TabIndex = 4;
            lblCitizenship.Text = "Choose your citizenship:";
            // 
            // txtName
            // 
            txtName.Location = new Point(609, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 25);
            txtName.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(609, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(241, 25);
            txtId.TabIndex = 6;
            // 
            // cbbCitizenship
            // 
            cbbCitizenship.FormattingEnabled = true;
            cbbCitizenship.Items.AddRange(new object[] { "Citizen", "Permanent Resident", "Visitor" });
            cbbCitizenship.Location = new Point(667, 138);
            cbbCitizenship.Name = "cbbCitizenship";
            cbbCitizenship.Size = new Size(183, 25);
            cbbCitizenship.TabIndex = 7;
            // 
            // btnValidateId
            // 
            btnValidateId.BackColor = Color.ForestGreen;
            btnValidateId.Location = new Point(609, 185);
            btnValidateId.Name = "btnValidateId";
            btnValidateId.Size = new Size(99, 36);
            btnValidateId.TabIndex = 8;
            btnValidateId.Text = "Validate ID";
            btnValidateId.UseVisualStyleBackColor = false;
            btnValidateId.Click += btnValidateId_Click;
            // 
            // lblValidIdOutput
            // 
            lblValidIdOutput.AutoSize = true;
            lblValidIdOutput.Location = new Point(577, 224);
            lblValidIdOutput.Name = "lblValidIdOutput";
            lblValidIdOutput.Size = new Size(0, 17);
            lblValidIdOutput.TabIndex = 9;
            // 
            // rtbProfileOutput
            // 
            rtbProfileOutput.Location = new Point(468, 260);
            rtbProfileOutput.Name = "rtbProfileOutput";
            rtbProfileOutput.Size = new Size(393, 146);
            rtbProfileOutput.TabIndex = 10;
            rtbProfileOutput.Text = "";
            // 
            // btnGenerateProfile
            // 
            btnGenerateProfile.BackColor = Color.ForestGreen;
            btnGenerateProfile.Location = new Point(598, 442);
            btnGenerateProfile.Name = "btnGenerateProfile";
            btnGenerateProfile.Size = new Size(127, 36);
            btnGenerateProfile.TabIndex = 11;
            btnGenerateProfile.Text = "Generate Profile";
            btnGenerateProfile.UseVisualStyleBackColor = false;
            btnGenerateProfile.Click += btnGenerateProfile_Click;
            // 
            // pbCoatOfArms
            // 
            pbCoatOfArms.Image = HomeAffairsDigitalIdentityProcessor.Properties.Resources.CoatOfArms2;
            pbCoatOfArms.Location = new Point(26, 68);
            pbCoatOfArms.Name = "pbCoatOfArms";
            pbCoatOfArms.Size = new Size(390, 369);
            pbCoatOfArms.TabIndex = 12;
            pbCoatOfArms.TabStop = false;
            // 
            // rtbOutput
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(887, 503);
            Controls.Add(pbCoatOfArms);
            Controls.Add(btnGenerateProfile);
            Controls.Add(rtbProfileOutput);
            Controls.Add(lblValidIdOutput);
            Controls.Add(btnValidateId);
            Controls.Add(cbbCitizenship);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(lblCitizenship);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(lblHeading);
            Font = new Font("Segoe UI Semibold", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "rtbOutput";
            Text = "Home Affairs Digital Identity Processor";
            ((System.ComponentModel.ISupportInitialize)pbCoatOfArms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeading;
        private Label lblName;
        private Label lblId;
        private Label lblCitizenship;
        private TextBox txtName;
        private TextBox txtId;
        private ComboBox cbbCitizenship;
        private Button btnValidateId;
        private Label lblValidIdOutput;
        private RichTextBox rtbProfileOutput;
        private Button btnGenerateProfile;
        private PictureBox pbCoatOfArms;
    }
}
