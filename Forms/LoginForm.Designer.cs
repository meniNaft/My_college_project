namespace My_college_project
{
    partial class LoginForm
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
            materialLabel_mainTitle = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel_username = new ReaLTaiizor.Controls.MaterialLabel();
            materialTextBox_username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTextBox_password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_password = new ReaLTaiizor.Controls.MaterialLabel();
            labelBtn_login = new Label();
            labelBtn_registration = new Label();
            SuspendLayout();
            // 
            // materialLabel_mainTitle
            // 
            materialLabel_mainTitle.AutoSize = true;
            materialLabel_mainTitle.Depth = 0;
            materialLabel_mainTitle.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_mainTitle.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            materialLabel_mainTitle.Location = new Point(223, 107);
            materialLabel_mainTitle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_mainTitle.Name = "materialLabel_mainTitle";
            materialLabel_mainTitle.Size = new Size(368, 41);
            materialLabel_mainTitle.TabIndex = 0;
            materialLabel_mainTitle.Text = "my college - ברוכים הבאים";
            // 
            // materialLabel_username
            // 
            materialLabel_username.AutoSize = true;
            materialLabel_username.Depth = 0;
            materialLabel_username.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_username.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_username.Location = new Point(258, 185);
            materialLabel_username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_username.Name = "materialLabel_username";
            materialLabel_username.Size = new Size(110, 29);
            materialLabel_username.TabIndex = 1;
            materialLabel_username.Text = "שם משתמש ";
            // 
            // materialTextBox_username
            // 
            materialTextBox_username.AnimateReadOnly = false;
            materialTextBox_username.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox_username.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox_username.BackgroundImageLayout = ImageLayout.None;
            materialTextBox_username.CharacterCasing = CharacterCasing.Normal;
            materialTextBox_username.Depth = 0;
            materialTextBox_username.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox_username.HideSelection = true;
            materialTextBox_username.LeadingIcon = null;
            materialTextBox_username.Location = new Point(258, 230);
            materialTextBox_username.MaxLength = 32767;
            materialTextBox_username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBox_username.Name = "materialTextBox_username";
            materialTextBox_username.PasswordChar = '\0';
            materialTextBox_username.PrefixSuffixText = null;
            materialTextBox_username.ReadOnly = false;
            materialTextBox_username.RightToLeft = RightToLeft.No;
            materialTextBox_username.SelectedText = "";
            materialTextBox_username.SelectionLength = 0;
            materialTextBox_username.SelectionStart = 0;
            materialTextBox_username.ShortcutsEnabled = true;
            materialTextBox_username.Size = new Size(312, 48);
            materialTextBox_username.TabIndex = 2;
            materialTextBox_username.TabStop = false;
            materialTextBox_username.TextAlign = HorizontalAlignment.Right;
            materialTextBox_username.TrailingIcon = null;
            materialTextBox_username.UseSystemPasswordChar = false;
            // 
            // materialTextBox_password
            // 
            materialTextBox_password.AnimateReadOnly = false;
            materialTextBox_password.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox_password.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox_password.BackgroundImageLayout = ImageLayout.None;
            materialTextBox_password.CharacterCasing = CharacterCasing.Normal;
            materialTextBox_password.Depth = 0;
            materialTextBox_password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox_password.HideSelection = true;
            materialTextBox_password.LeadingIcon = null;
            materialTextBox_password.Location = new Point(258, 361);
            materialTextBox_password.MaxLength = 32767;
            materialTextBox_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBox_password.Name = "materialTextBox_password";
            materialTextBox_password.PasswordChar = '\0';
            materialTextBox_password.PrefixSuffixText = null;
            materialTextBox_password.ReadOnly = false;
            materialTextBox_password.RightToLeft = RightToLeft.No;
            materialTextBox_password.SelectedText = "";
            materialTextBox_password.SelectionLength = 0;
            materialTextBox_password.SelectionStart = 0;
            materialTextBox_password.ShortcutsEnabled = true;
            materialTextBox_password.Size = new Size(312, 48);
            materialTextBox_password.TabIndex = 4;
            materialTextBox_password.TabStop = false;
            materialTextBox_password.TextAlign = HorizontalAlignment.Right;
            materialTextBox_password.TrailingIcon = null;
            materialTextBox_password.UseSystemPasswordChar = false;
            // 
            // materialLabel_password
            // 
            materialLabel_password.AutoSize = true;
            materialLabel_password.Depth = 0;
            materialLabel_password.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_password.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_password.Location = new Point(258, 316);
            materialLabel_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_password.Name = "materialLabel_password";
            materialLabel_password.Size = new Size(57, 29);
            materialLabel_password.TabIndex = 3;
            materialLabel_password.Text = "סיסמא";
            // 
            // labelBtn_login
            // 
            labelBtn_login.AutoSize = true;
            labelBtn_login.BackColor = Color.RoyalBlue;
            labelBtn_login.Font = new Font("Segoe UI", 18F);
            labelBtn_login.ForeColor = Color.White;
            labelBtn_login.Location = new Point(317, 436);
            labelBtn_login.MinimumSize = new Size(200, 40);
            labelBtn_login.Name = "labelBtn_login";
            labelBtn_login.Size = new Size(200, 41);
            labelBtn_login.TabIndex = 5;
            labelBtn_login.Text = "כניסה";
            labelBtn_login.TextAlign = ContentAlignment.MiddleCenter;
            labelBtn_login.Click += labelBtn_login_Click;
            // 
            // labelBtn_loginAsGuest
            // 
            labelBtn_registration.AutoSize = true;
            labelBtn_registration.BackColor = Color.RoyalBlue;
            labelBtn_registration.Font = new Font("Segoe UI", 18F);
            labelBtn_registration.ForeColor = Color.White;
            labelBtn_registration.Location = new Point(317, 497);
            labelBtn_registration.MinimumSize = new Size(200, 40);
            labelBtn_registration.Name = "labelBtn_loginAsGuest";
            labelBtn_registration.Size = new Size(200, 41);
            labelBtn_registration.TabIndex = 6;
            labelBtn_registration.Text = "הרשמה";
            labelBtn_registration.TextAlign = ContentAlignment.MiddleCenter;
            labelBtn_registration.Click += labelBtn_registration_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(labelBtn_registration);
            Controls.Add(labelBtn_login);
            Controls.Add(materialTextBox_password);
            Controls.Add(materialLabel_password);
            Controls.Add(materialTextBox_username);
            Controls.Add(materialLabel_username);
            Controls.Add(materialLabel_mainTitle);
            Font = new Font("Segoe UI", 9F);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך כניסה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel_mainTitle;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_password;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_password;
        private Label labelBtn_login;
        private Label labelBtn_registration;
    }
}
