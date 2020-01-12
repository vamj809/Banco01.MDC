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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaMenuPrincipal));
            this.LogOff = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.WelcomeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyProfileLink = new System.Windows.Forms.ToolStripSplitButton();
            this.ProfileEditorBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(909, 13);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(75, 52);
            this.LogOff.TabIndex = 0;
            this.LogOff.Text = "Cerrar Sesion";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyProfileLink,
            this.WelcomeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(157, 20);
            this.WelcomeLabel.Text = "                                     ";
            // 
            // MyProfileLink
            // 
            this.MyProfileLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MyProfileLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileEditorBTN});
            this.MyProfileLink.Image = ((System.Drawing.Image)(resources.GetObject("MyProfileLink.Image")));
            this.MyProfileLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MyProfileLink.Name = "MyProfileLink";
            this.MyProfileLink.Size = new System.Drawing.Size(39, 24);
            this.MyProfileLink.Text = "Mi Perfil";
            // 
            // ProfileEditorBTN
            // 
            this.ProfileEditorBTN.Name = "ProfileEditorBTN";
            this.ProfileEditorBTN.Size = new System.Drawing.Size(224, 26);
            this.ProfileEditorBTN.Text = "Editar mi perfil";
            this.ProfileEditorBTN.Click += new System.EventHandler(this.ProfileEditorBTN_Click);
            // 
            // CajaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LogOff);
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

        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel WelcomeLabel;
        private System.Windows.Forms.ToolStripSplitButton MyProfileLink;
        private System.Windows.Forms.ToolStripMenuItem ProfileEditorBTN;
    }
}