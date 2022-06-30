namespace Client
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.sessionLogin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(897, 496);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // txt_Username
            // 
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.Hint = "Username";
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(12, 331);
            this.txt_Username.MaxLength = 50;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(291, 50);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.Text = "";
            this.txt_Username.TrailingIcon = null;
            // 
            // txt_Password
            // 
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.Hint = "Password";
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(12, 387);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Password = true;
            this.txt_Password.Size = new System.Drawing.Size(291, 50);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "";
            this.txt_Password.TrailingIcon = null;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(13, 445);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(64, 36);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // sessionLogin
            // 
            this.sessionLogin.Tick += new System.EventHandler(this.sessionLogin_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 496);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - GGS Connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private MaterialSkin.Controls.MaterialTextBox txt_Username;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private System.Windows.Forms.Timer sessionLogin;
    }
}

