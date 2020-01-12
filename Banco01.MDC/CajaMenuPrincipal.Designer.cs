namespace Banco01.MDC
{
    partial class CajaMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaMenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MyProfileLink = new System.Windows.Forms.ToolStripDropDownButton();
            this.EditMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeOfDayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dummyLabel01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.worldTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyProfileLink,
            this.WelcomeLabel,
            this.TimeOfDayLabel,
            this.dummyLabel01});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MyProfileLink
            // 
            this.MyProfileLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMyProfile,
            this.LogOffMenuItem});
            this.MyProfileLink.Image = ((System.Drawing.Image)(resources.GetObject("MyProfileLink.Image")));
            this.MyProfileLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MyProfileLink.Name = "MyProfileLink";
            this.MyProfileLink.Size = new System.Drawing.Size(97, 24);
            this.MyProfileLink.Text = "Mi Perfil";
            // 
            // EditMyProfile
            // 
            this.EditMyProfile.Name = "EditMyProfile";
            this.EditMyProfile.Size = new System.Drawing.Size(189, 26);
            this.EditMyProfile.Text = "Editar mi Perfil";
            this.EditMyProfile.Click += new System.EventHandler(this.EditMyProfile_Click);
            // 
            // LogOffMenuItem
            // 
            this.LogOffMenuItem.Name = "LogOffMenuItem";
            this.LogOffMenuItem.Size = new System.Drawing.Size(189, 26);
            this.LogOffMenuItem.Text = "Cerrar Sesión";
            this.LogOffMenuItem.Click += new System.EventHandler(this.LogOffMenuItem_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(874, 20);
            this.WelcomeLabel.Spring = true;
            this.WelcomeLabel.Text = "                                     ";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeOfDayLabel
            // 
            this.TimeOfDayLabel.Name = "TimeOfDayLabel";
            this.TimeOfDayLabel.Size = new System.Drawing.Size(17, 20);
            this.TimeOfDayLabel.Text = "  ";
            this.TimeOfDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeOfDayLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TimeOfDayLabel.ToolTipText = "dd/MM/yyyy hh:mm tt";
            // 
            // dummyLabel01
            // 
            this.dummyLabel01.Name = "dummyLabel01";
            this.dummyLabel01.Size = new System.Drawing.Size(25, 20);
            this.dummyLabel01.Text = "    ";
            // 
            // worldTimer
            // 
            this.worldTimer.Enabled = true;
            this.worldTimer.Interval = 500;
            this.worldTimer.Tick += new System.EventHandler(this.worldTimer_Tick);
            // 
            // CajaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CajaMenuPrincipal";
            this.Text = "Aplicacion de caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CajaMenuPrincipal_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel WelcomeLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeOfDayLabel;
        private System.Windows.Forms.ToolStripDropDownButton MyProfileLink;
        private System.Windows.Forms.ToolStripMenuItem EditMyProfile;
        private System.Windows.Forms.ToolStripMenuItem LogOffMenuItem;
        private System.Windows.Forms.Timer worldTimer;
        private System.Windows.Forms.ToolStripStatusLabel dummyLabel01;
    }
}