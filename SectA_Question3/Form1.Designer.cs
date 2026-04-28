namespace Question3
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
            lblTitle = new Label();
            panel1 = new Panel();
            lblRemoveOutput = new Label();
            btnRemove = new Button();
            btnAdd = new Button();
            txtLanguage = new TextBox();
            lstLanguages = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(66, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(516, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Favourite Programming Languages";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblRemoveOutput);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtLanguage);
            panel1.Controls.Add(lstLanguages);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(74, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 338);
            panel1.TabIndex = 1;
            // 
            // lblRemoveOutput
            // 
            lblRemoveOutput.AutoSize = true;
            lblRemoveOutput.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemoveOutput.ForeColor = SystemColors.ControlDarkDark;
            lblRemoveOutput.Location = new Point(18, 302);
            lblRemoveOutput.Name = "lblRemoveOutput";
            lblRemoveOutput.Size = new Size(0, 21);
            lblRemoveOutput.TabIndex = 5;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(107, 270);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(83, 30);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(18, 269);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLanguage
            // 
            txtLanguage.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLanguage.Location = new Point(18, 232);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Enter programming language";
            txtLanguage.Size = new Size(347, 31);
            txtLanguage.TabIndex = 2;
            // 
            // lstLanguages
            // 
            lstLanguages.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLanguages.Location = new Point(18, 62);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(609, 164);
            lstLanguages.TabIndex = 1;
            lstLanguages.UseCompatibleStateImageBehavior = false;
            lstLanguages.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Favourite Programming Languages";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private ListView lstLanguages;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtLanguage;
        private Label lblRemoveOutput;
    }
}
