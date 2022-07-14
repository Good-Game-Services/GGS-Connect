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
            this.label_tp_status = new System.Windows.Forms.LinkLabel();
            this.switch_TP = new MaterialSkin.Controls.MaterialSwitch();
            this.label_vpn_status = new System.Windows.Forms.LinkLabel();
            this.lable_username = new System.Windows.Forms.LinkLabel();
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
            this.btn_settings.Location = new System.Drawing.Point(220, 70);
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
            this.materialCard1.Controls.Add(this.label_tp_status);
            this.materialCard1.Controls.Add(this.switch_TP);
            this.materialCard1.Controls.Add(this.label_vpn_status);
            this.materialCard1.Controls.Add(this.switch_VPN_State);
            this.materialCard1.Controls.Add(this.btn_settings);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(619, 367);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(328, 126);
            this.materialCard1.TabIndex = 5;
            // 
            // label_tp_status
            // 
            this.label_tp_status.AutoSize = true;
            this.label_tp_status.LinkColor = System.Drawing.Color.Red;
            this.label_tp_status.Location = new System.Drawing.Point(134, 51);
            this.label_tp_status.Name = "label_tp_status";
            this.label_tp_status.Size = new System.Drawing.Size(73, 13);
            this.label_tp_status.TabIndex = 8;
            this.label_tp_status.TabStop = true;
            this.label_tp_status.Text = "Disconnected";
            // 
            // switch_TP
            // 
            this.switch_TP.AutoSize = true;
            this.switch_TP.Depth = 0;
            this.switch_TP.Location = new System.Drawing.Point(137, 14);
            this.switch_TP.Margin = new System.Windows.Forms.Padding(0);
            this.switch_TP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_TP.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_TP.Name = "switch_TP";
            this.switch_TP.Ripple = true;
            this.switch_TP.Size = new System.Drawing.Size(177, 37);
            this.switch_TP.TabIndex = 7;
            this.switch_TP.Text = "Proxy (Titanium)";
            this.switch_TP.UseVisualStyleBackColor = true;
            this.switch_TP.CheckedChanged += new System.EventHandler(this.switch_TP_CheckedChanged);
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
            // lable_username
            // 
            this.lable_username.AutoSize = true;
            this.lable_username.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lable_username.Location = new System.Drawing.Point(12, 484);
            this.lable_username.Name = "lable_username";
            this.lable_username.Size = new System.Drawing.Size(25, 13);
            this.lable_username.TabIndex = 6;
            this.lable_username.TabStop = true;
            this.lable_username.Text = "???";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.lable_username);
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
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Timer vpn_status;
        private MaterialSkin.Controls.MaterialButton btn_settings;
        private MaterialSkin.Controls.MaterialSwitch switch_VPN_State;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.LinkLabel label_vpn_status;
        private System.Windows.Forms.LinkLabel lable_username;
        private System.Windows.Forms.LinkLabel label_tp_status;
        private MaterialSkin.Controls.MaterialSwitch switch_TP;
    }
}