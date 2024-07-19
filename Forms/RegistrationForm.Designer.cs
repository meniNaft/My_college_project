namespace My_college_project
{
    partial class RegistrationForm
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
            label_back = new Label();
            materialTextBox_address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_address = new ReaLTaiizor.Controls.MaterialLabel();
            materialTextBox_password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_password = new ReaLTaiizor.Controls.MaterialLabel();
            materialTextBox_username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_username = new ReaLTaiizor.Controls.MaterialLabel();
            labelBtn_registration = new Label();
            materialTextBox_phone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_Phone = new ReaLTaiizor.Controls.MaterialLabel();
            materialTextBox_name = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel_name = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // label_back
            // 
            label_back.AutoSize = true;
            label_back.BackColor = SystemColors.ControlDark;
            label_back.Font = new Font("Segoe UI", 15F);
            label_back.ForeColor = Color.White;
            label_back.Location = new Point(233, 93);
            label_back.MinimumSize = new Size(100, 30);
            label_back.Name = "label_back";
            label_back.Size = new Size(100, 35);
            label_back.TabIndex = 35;
            label_back.Text = "חזור";
            label_back.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialTextBox_address
            // 
            materialTextBox_address.AnimateReadOnly = false;
            materialTextBox_address.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox_address.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox_address.BackgroundImageLayout = ImageLayout.None;
            materialTextBox_address.CharacterCasing = CharacterCasing.Normal;
            materialTextBox_address.Depth = 0;
            materialTextBox_address.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox_address.HideSelection = true;
            materialTextBox_address.LeadingIcon = null;
            materialTextBox_address.Location = new Point(233, 437);
            materialTextBox_address.MaxLength = 32767;
            materialTextBox_address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBox_address.Name = "materialTextBox_address";
            materialTextBox_address.PasswordChar = '\0';
            materialTextBox_address.PrefixSuffixText = null;
            materialTextBox_address.ReadOnly = false;
            materialTextBox_address.RightToLeft = RightToLeft.No;
            materialTextBox_address.SelectedText = "";
            materialTextBox_address.SelectionLength = 0;
            materialTextBox_address.SelectionStart = 0;
            materialTextBox_address.ShortcutsEnabled = true;
            materialTextBox_address.Size = new Size(343, 48);
            materialTextBox_address.TabIndex = 34;
            materialTextBox_address.TabStop = false;
            materialTextBox_address.TextAlign = HorizontalAlignment.Right;
            materialTextBox_address.TrailingIcon = null;
            materialTextBox_address.UseSystemPasswordChar = false;
            // 
            // materialLabel_address
            // 
            materialLabel_address.AutoSize = true;
            materialLabel_address.Depth = 0;
            materialLabel_address.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_address.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_address.Location = new Point(233, 392);
            materialLabel_address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_address.Name = "materialLabel_address";
            materialLabel_address.Size = new Size(55, 29);
            materialLabel_address.TabIndex = 33;
            materialLabel_address.Text = "כתובת";
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
            materialTextBox_password.Location = new Point(581, 323);
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
            materialTextBox_password.Size = new Size(257, 48);
            materialTextBox_password.TabIndex = 32;
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
            materialLabel_password.Location = new Point(581, 278);
            materialLabel_password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_password.Name = "materialLabel_password";
            materialLabel_password.Size = new Size(57, 29);
            materialLabel_password.TabIndex = 31;
            materialLabel_password.Text = "סיסמא";
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
            materialTextBox_username.Location = new Point(581, 192);
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
            materialTextBox_username.Size = new Size(257, 48);
            materialTextBox_username.TabIndex = 30;
            materialTextBox_username.TabStop = false;
            materialTextBox_username.TextAlign = HorizontalAlignment.Right;
            materialTextBox_username.TrailingIcon = null;
            materialTextBox_username.UseSystemPasswordChar = false;
            // 
            // materialLabel_username
            // 
            materialLabel_username.AutoSize = true;
            materialLabel_username.Depth = 0;
            materialLabel_username.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_username.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_username.Location = new Point(581, 147);
            materialLabel_username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_username.Name = "materialLabel_username";
            materialLabel_username.Size = new Size(110, 29);
            materialLabel_username.TabIndex = 29;
            materialLabel_username.Text = "שם משתמש ";
            // 
            // labelBtn_registration
            // 
            labelBtn_registration.AutoSize = true;
            labelBtn_registration.BackColor = Color.RoyalBlue;
            labelBtn_registration.Font = new Font("Segoe UI", 18F);
            labelBtn_registration.ForeColor = Color.White;
            labelBtn_registration.Location = new Point(638, 444);
            labelBtn_registration.MinimumSize = new Size(200, 40);
            labelBtn_registration.Name = "labelBtn_registration";
            labelBtn_registration.Size = new Size(200, 41);
            labelBtn_registration.TabIndex = 28;
            labelBtn_registration.Text = "הרשמה";
            labelBtn_registration.TextAlign = ContentAlignment.MiddleCenter;
            labelBtn_registration.Click += labelBtn_registration_Click;
            // 
            // materialTextBox_phone
            // 
            materialTextBox_phone.AnimateReadOnly = false;
            materialTextBox_phone.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox_phone.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox_phone.BackgroundImageLayout = ImageLayout.None;
            materialTextBox_phone.CharacterCasing = CharacterCasing.Normal;
            materialTextBox_phone.Depth = 0;
            materialTextBox_phone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox_phone.HideSelection = true;
            materialTextBox_phone.LeadingIcon = null;
            materialTextBox_phone.Location = new Point(233, 323);
            materialTextBox_phone.MaxLength = 32767;
            materialTextBox_phone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBox_phone.Name = "materialTextBox_phone";
            materialTextBox_phone.PasswordChar = '\0';
            materialTextBox_phone.PrefixSuffixText = null;
            materialTextBox_phone.ReadOnly = false;
            materialTextBox_phone.RightToLeft = RightToLeft.No;
            materialTextBox_phone.SelectedText = "";
            materialTextBox_phone.SelectionLength = 0;
            materialTextBox_phone.SelectionStart = 0;
            materialTextBox_phone.ShortcutsEnabled = true;
            materialTextBox_phone.Size = new Size(267, 48);
            materialTextBox_phone.TabIndex = 27;
            materialTextBox_phone.TabStop = false;
            materialTextBox_phone.TextAlign = HorizontalAlignment.Right;
            materialTextBox_phone.TrailingIcon = null;
            materialTextBox_phone.UseSystemPasswordChar = false;
            // 
            // materialLabel_Phone
            // 
            materialLabel_Phone.AutoSize = true;
            materialLabel_Phone.Depth = 0;
            materialLabel_Phone.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_Phone.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_Phone.Location = new Point(233, 278);
            materialLabel_Phone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_Phone.Name = "materialLabel_Phone";
            materialLabel_Phone.Size = new Size(100, 29);
            materialLabel_Phone.TabIndex = 26;
            materialLabel_Phone.Text = "מספר טלפון";
            // 
            // materialTextBox_name
            // 
            materialTextBox_name.AnimateReadOnly = false;
            materialTextBox_name.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox_name.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox_name.BackgroundImageLayout = ImageLayout.None;
            materialTextBox_name.CharacterCasing = CharacterCasing.Normal;
            materialTextBox_name.Depth = 0;
            materialTextBox_name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox_name.HideSelection = true;
            materialTextBox_name.LeadingIcon = null;
            materialTextBox_name.Location = new Point(233, 192);
            materialTextBox_name.MaxLength = 32767;
            materialTextBox_name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBox_name.Name = "materialTextBox_name";
            materialTextBox_name.PasswordChar = '\0';
            materialTextBox_name.PrefixSuffixText = null;
            materialTextBox_name.ReadOnly = false;
            materialTextBox_name.RightToLeft = RightToLeft.No;
            materialTextBox_name.SelectedText = "";
            materialTextBox_name.SelectionLength = 0;
            materialTextBox_name.SelectionStart = 0;
            materialTextBox_name.ShortcutsEnabled = true;
            materialTextBox_name.Size = new Size(267, 48);
            materialTextBox_name.TabIndex = 25;
            materialTextBox_name.TabStop = false;
            materialTextBox_name.TextAlign = HorizontalAlignment.Right;
            materialTextBox_name.TrailingIcon = null;
            materialTextBox_name.UseSystemPasswordChar = false;
            // 
            // materialLabel_name
            // 
            materialLabel_name.AutoSize = true;
            materialLabel_name.Depth = 0;
            materialLabel_name.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_name.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel_name.Location = new Point(233, 147);
            materialLabel_name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel_name.Name = "materialLabel_name";
            materialLabel_name.Size = new Size(151, 29);
            materialLabel_name.TabIndex = 24;
            materialLabel_name.Text = "שם פרטי ומשפחה";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 589);
            Controls.Add(label_back);
            Controls.Add(materialTextBox_address);
            Controls.Add(materialLabel_address);
            Controls.Add(materialTextBox_password);
            Controls.Add(materialLabel_password);
            Controls.Add(materialTextBox_username);
            Controls.Add(materialLabel_username);
            Controls.Add(labelBtn_registration);
            Controls.Add(materialTextBox_phone);
            Controls.Add(materialLabel_Phone);
            Controls.Add(materialTextBox_name);
            Controls.Add(materialLabel_name);
            Name = "RegistrationForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מסך הרשמה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_back;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_address;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_address;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_password;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_username;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_username;
        private Label labelBtn_registration;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_phone;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_Phone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBox_name;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel_name;
    }
}