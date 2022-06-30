namespace GGSClient
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.vpn_status = new System.Windows.Forms.Timer(this.components);
            this.btn_settings = new MaterialSkin.Controls.MaterialButton();
            this.switch_VPN_State = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label_vpn_status = new System.Windows.Forms.LinkLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(960, 506);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // vpn_status
            // 
            this.vpn_status.Tick += new System.EventHandler(this.vpn_status_Tick);
            // 
            // btn_settings
            // 
            this.btn_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_settings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_settings.Depth = 0;
            this.btn_settings.HighEmphasis = true;
            this.btn_settings.Icon = null;
            this.btn_settings.Location = new System.Drawing.Point(18, 103);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_settings.Size = new System.Drawing.Size(90, 36);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_settings.UseAccentColor = false;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // switch_VPN_State
            // 
            this.switch_VPN_State.AutoSize = true;
            this.switch_VPN_State.Depth = 0;
            this.switch_VPN_State.Location = new System.Drawing.Point(14, 14);
            this.switch_VPN_State.Margin = new System.Windows.Forms.Padding(0);
            this.switch_VPN_State.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_VPN_State.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_VPN_State.Name = "switch_VPN_State";
            this.switch_VPN_State.Ripple = true;
            this.switch_VPN_State.Size = new System.Drawing.Size(93, 37);
            this.switch_VPN_State.TabIndex = 4;
            this.switch_VPN_State.Text = "VPN ";
            this.switch_VPN_State.UseVisualStyleBackColor = true;
            this.switch_VPN_State.CheckedChanged += new System.EventHandler(this.switch_VPN_State_CheckedChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label_vpn_status);
            this.materialCard1.Controls.Add(this.switch_VPN_State);
            this.materialCard1.Controls.Add(this.btn_settings);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(794, 334);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(153, 159);
            this.materialCard1.TabIndex = 5;
            // 
            // label_vpn_status
            // 
            this.label_vpn_status.AutoSize = true;
            this.label_vpn_status.LinkColor = System.Drawing.Color.Red;
            this.label_vpn_status.Location = new System.Drawing.Point(17, 51);
            this.label_vpn_status.Name = "label_vpn_status";
            this.label_vpn_status.Size = new System.Drawing.Size(73, 13);
            this.label_vpn_status.TabIndex = 6;
            this.label_vpn_status.TabStop = true;
            this.label_vpn_status.Text = "Disconnected";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - GGS Connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Timer vpn_status;
        private MaterialSkin.Controls.MaterialButton btn_settings;
        private MaterialSkin.Controls.MaterialSwitch switch_VPN_State;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.LinkLabel label_vpn_status;
    }
}