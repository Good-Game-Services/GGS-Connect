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
            this.sessionLogin = new System.Windows.Forms.Timer(this.components);
            this.btn_login_with_discord = new MaterialSkin.Controls.MaterialButton();
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
            // sessionLogin
            // 
            this.sessionLogin.Tick += new System.EventHandler(this.sessionLogin_Tick);
            // 
            // btn_login_with_discord
            // 
            this.btn_login_with_discord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login_with_discord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login_with_discord.Depth = 0;
            this.btn_login_with_discord.HighEmphasis = true;
            this.btn_login_with_discord.Icon = null;
            this.btn_login_with_discord.Location = new System.Drawing.Point(13, 445);
            this.btn_login_with_discord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_login_with_discord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login_with_discord.Name = "btn_login_with_discord";
            this.btn_login_with_discord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login_with_discord.Size = new System.Drawing.Size(170, 36);
            this.btn_login_with_discord.TabIndex = 4;
            this.btn_login_with_discord.Text = "Login with Discord";
            this.btn_login_with_discord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login_with_discord.UseAccentColor = false;
            this.btn_login_with_discord.UseVisualStyleBackColor = true;
            this.btn_login_with_discord.Click += new System.EventHandler(this.btn_login_with_discord_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 496);
            this.Controls.Add(this.btn_login_with_discord);
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
        private System.Windows.Forms.Timer sessionLogin;
        private MaterialSkin.Controls.MaterialButton btn_login_with_discord;
    }
}

