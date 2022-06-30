namespace GGSClient
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.btn_refresh_log = new MaterialSkin.Controls.MaterialButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_change_name = new MaterialSkin.Controls.MaterialButton();
            this.txt_lastname = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_firstname = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btn_change_password = new MaterialSkin.Controls.MaterialButton();
            this.txt_old_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_new_password_confirm = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_new_password = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_reset_log = new MaterialSkin.Controls.MaterialButton();
            this.switch_DoH = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label_doh_status = new System.Windows.Forms.LinkLabel();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1138, 567);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.Color.Black;
            this.richTextBox_log.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox_log.Location = new System.Drawing.Point(633, 9);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(493, 281);
            this.richTextBox_log.TabIndex = 1;
            this.richTextBox_log.Text = "";
            // 
            // btn_refresh_log
            // 
            this.btn_refresh_log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refresh_log.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_refresh_log.Depth = 0;
            this.btn_refresh_log.HighEmphasis = true;
            this.btn_refresh_log.Icon = null;
            this.btn_refresh_log.Location = new System.Drawing.Point(633, 299);
            this.btn_refresh_log.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_refresh_log.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refresh_log.Name = "btn_refresh_log";
            this.btn_refresh_log.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_refresh_log.Size = new System.Drawing.Size(116, 36);
            this.btn_refresh_log.TabIndex = 3;
            this.btn_refresh_log.Text = "Refresh Log";
            this.btn_refresh_log.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_refresh_log.UseAccentColor = false;
            this.btn_refresh_log.UseVisualStyleBackColor = true;
            this.btn_refresh_log.Click += new System.EventHandler(this.btn_refresh_log_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(593, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Log:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_change_name);
            this.materialCard1.Controls.Add(this.txt_lastname);
            this.materialCard1.Controls.Add(this.txt_firstname);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 9);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(431, 124);
            this.materialCard1.TabIndex = 5;
            // 
            // btn_change_name
            // 
            this.btn_change_name.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_change_name.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_change_name.Depth = 0;
            this.btn_change_name.HighEmphasis = true;
            this.btn_change_name.Icon = null;
            this.btn_change_name.Location = new System.Drawing.Point(17, 76);
            this.btn_change_name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_change_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_change_name.Name = "btn_change_name";
            this.btn_change_name.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_change_name.Size = new System.Drawing.Size(125, 36);
            this.btn_change_name.TabIndex = 3;
            this.btn_change_name.Text = "Change Name";
            this.btn_change_name.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_change_name.UseAccentColor = false;
            this.btn_change_name.UseVisualStyleBackColor = true;
            this.btn_change_name.Click += new System.EventHandler(this.btn_change_name_Click);
            // 
            // txt_lastname
            // 
            this.txt_lastname.AnimateReadOnly = false;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Depth = 0;
            this.txt_lastname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastname.Hint = "Lastname";
            this.txt_lastname.LeadingIcon = null;
            this.txt_lastname.Location = new System.Drawing.Point(211, 17);
            this.txt_lastname.MaxLength = 50;
            this.txt_lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_lastname.Multiline = false;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(188, 50);
            this.txt_lastname.TabIndex = 2;
            this.txt_lastname.Text = "";
            this.txt_lastname.TrailingIcon = null;
            // 
            // txt_firstname
            // 
            this.txt_firstname.AnimateReadOnly = false;
            this.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstname.Depth = 0;
            this.txt_firstname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstname.Hint = "Firstname";
            this.txt_firstname.LeadingIcon = null;
            this.txt_firstname.Location = new System.Drawing.Point(17, 17);
            this.txt_firstname.MaxLength = 50;
            this.txt_firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_firstname.Multiline = false;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(188, 50);
            this.txt_firstname.TabIndex = 1;
            this.txt_firstname.Text = "";
            this.txt_firstname.TrailingIcon = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btn_change_password);
            this.materialCard2.Controls.Add(this.txt_old_password);
            this.materialCard2.Controls.Add(this.txt_new_password_confirm);
            this.materialCard2.Controls.Add(this.txt_new_password);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 141);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(431, 128);
            this.materialCard2.TabIndex = 6;
            // 
            // btn_change_password
            // 
            this.btn_change_password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_change_password.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_change_password.Depth = 0;
            this.btn_change_password.HighEmphasis = true;
            this.btn_change_password.Icon = null;
            this.btn_change_password.Location = new System.Drawing.Point(17, 76);
            this.btn_change_password.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_change_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_change_password.Size = new System.Drawing.Size(163, 36);
            this.btn_change_password.TabIndex = 8;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_change_password.UseAccentColor = false;
            this.btn_change_password.UseVisualStyleBackColor = true;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // txt_old_password
            // 
            this.txt_old_password.AnimateReadOnly = false;
            this.txt_old_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_old_password.Depth = 0;
            this.txt_old_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_old_password.Hint = "Old Password";
            this.txt_old_password.LeadingIcon = null;
            this.txt_old_password.Location = new System.Drawing.Point(211, 73);
            this.txt_old_password.MaxLength = 50;
            this.txt_old_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_old_password.Multiline = false;
            this.txt_old_password.Name = "txt_old_password";
            this.txt_old_password.Size = new System.Drawing.Size(188, 50);
            this.txt_old_password.TabIndex = 2;
            this.txt_old_password.Text = "";
            this.txt_old_password.TrailingIcon = null;
            // 
            // txt_new_password_confirm
            // 
            this.txt_new_password_confirm.AnimateReadOnly = false;
            this.txt_new_password_confirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_password_confirm.Depth = 0;
            this.txt_new_password_confirm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_new_password_confirm.Hint = "New Password Cr";
            this.txt_new_password_confirm.LeadingIcon = null;
            this.txt_new_password_confirm.Location = new System.Drawing.Point(211, 17);
            this.txt_new_password_confirm.MaxLength = 50;
            this.txt_new_password_confirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_new_password_confirm.Multiline = false;
            this.txt_new_password_confirm.Name = "txt_new_password_confirm";
            this.txt_new_password_confirm.Size = new System.Drawing.Size(188, 50);
            this.txt_new_password_confirm.TabIndex = 1;
            this.txt_new_password_confirm.Text = "";
            this.txt_new_password_confirm.TrailingIcon = null;
            // 
            // txt_new_password
            // 
            this.txt_new_password.AnimateReadOnly = false;
            this.txt_new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_new_password.Depth = 0;
            this.txt_new_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_new_password.Hint = "New Password";
            this.txt_new_password.LeadingIcon = null;
            this.txt_new_password.Location = new System.Drawing.Point(17, 17);
            this.txt_new_password.MaxLength = 50;
            this.txt_new_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_new_password.Multiline = false;
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(188, 50);
            this.txt_new_password.TabIndex = 0;
            this.txt_new_password.Text = "";
            this.txt_new_password.TrailingIcon = null;
            // 
            // btn_reset_log
            // 
            this.btn_reset_log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reset_log.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reset_log.Depth = 0;
            this.btn_reset_log.HighEmphasis = true;
            this.btn_reset_log.Icon = null;
            this.btn_reset_log.Location = new System.Drawing.Point(757, 299);
            this.btn_reset_log.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reset_log.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reset_log.Name = "btn_reset_log";
            this.btn_reset_log.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reset_log.Size = new System.Drawing.Size(97, 36);
            this.btn_reset_log.TabIndex = 7;
            this.btn_reset_log.Text = "Reset Log";
            this.btn_reset_log.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reset_log.UseAccentColor = false;
            this.btn_reset_log.UseVisualStyleBackColor = true;
            this.btn_reset_log.Click += new System.EventHandler(this.btn_reset_log_Click);
            // 
            // switch_DoH
            // 
            this.switch_DoH.AutoSize = true;
            this.switch_DoH.Depth = 0;
            this.switch_DoH.Location = new System.Drawing.Point(17, 10);
            this.switch_DoH.Margin = new System.Windows.Forms.Padding(0);
            this.switch_DoH.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_DoH.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_DoH.Name = "switch_DoH";
            this.switch_DoH.Ripple = true;
            this.switch_DoH.Size = new System.Drawing.Size(220, 37);
            this.switch_DoH.TabIndex = 8;
            this.switch_DoH.Text = "cloudflared DoH (DNS)";
            this.switch_DoH.UseVisualStyleBackColor = true;
            this.switch_DoH.CheckedChanged += new System.EventHandler(this.switch_DoH_CheckedChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label_doh_status);
            this.materialCard3.Controls.Add(this.switch_DoH);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(23, 273);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(431, 72);
            this.materialCard3.TabIndex = 9;
            // 
            // label_doh_status
            // 
            this.label_doh_status.AutoSize = true;
            this.label_doh_status.LinkColor = System.Drawing.Color.Red;
            this.label_doh_status.Location = new System.Drawing.Point(17, 49);
            this.label_doh_status.Name = "label_doh_status";
            this.label_doh_status.Size = new System.Drawing.Size(67, 13);
            this.label_doh_status.TabIndex = 9;
            this.label_doh_status.TabStop = true;
            this.label_doh_status.Text = "Disonnected";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 567);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.btn_reset_log);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_refresh_log);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings - GGS Connect";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private MaterialSkin.Controls.MaterialButton btn_refresh_log;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txt_firstname;
        private MaterialSkin.Controls.MaterialTextBox txt_lastname;
        private MaterialSkin.Controls.MaterialButton btn_change_name;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_reset_log;
        private MaterialSkin.Controls.MaterialTextBox txt_new_password;
        private MaterialSkin.Controls.MaterialTextBox txt_new_password_confirm;
        private MaterialSkin.Controls.MaterialTextBox txt_old_password;
        private MaterialSkin.Controls.MaterialButton btn_change_password;
        private MaterialSkin.Controls.MaterialSwitch switch_DoH;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.LinkLabel label_doh_status;
    }
}