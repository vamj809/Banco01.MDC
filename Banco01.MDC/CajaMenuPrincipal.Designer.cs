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
            this.newUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.EditMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeOfDayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dummyLabel01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.WorldTimer = new System.Windows.Forms.Timer(this.components);
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.DetallesCuadre = new System.Windows.Forms.GroupBox();
            this.BalanceActualLabel = new System.Windows.Forms.Label();
            this.BalanceTitleLabel = new System.Windows.Forms.Label();
            this.CashInputButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.DetallesCuadre.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MyProfileLink
            // 
            this.MyProfileLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserMenuItem,
            this.newUserSeparator,
            this.EditMyProfile,
            this.LogOffMenuItem});
            this.MyProfileLink.Image = ((System.Drawing.Image)(resources.GetObject("MyProfileLink.Image")));
            this.MyProfileLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MyProfileLink.Name = "MyProfileLink";
            this.MyProfileLink.Size = new System.Drawing.Size(84, 24);
            this.MyProfileLink.Text = "Mi Perfil";
            // 
            // newUserMenuItem
            // 
            this.newUserMenuItem.Name = "newUserMenuItem";
            this.newUserMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newUserMenuItem.Text = "Crear Nuevo Usuario";
            this.newUserMenuItem.Visible = false;
            this.newUserMenuItem.Click += new System.EventHandler(this.NewUserMenuItem_Click);
            // 
            // newUserSeparator
            // 
            this.newUserSeparator.Name = "newUserSeparator";
            this.newUserSeparator.Size = new System.Drawing.Size(180, 6);
            this.newUserSeparator.Visible = false;
            // 
            // EditMyProfile
            // 
            this.EditMyProfile.Name = "EditMyProfile";
            this.EditMyProfile.Size = new System.Drawing.Size(183, 22);
            this.EditMyProfile.Text = "Editar mi Perfil";
            this.EditMyProfile.Click += new System.EventHandler(this.EditMyProfile_Click);
            // 
            // LogOffMenuItem
            // 
            this.LogOffMenuItem.Name = "LogOffMenuItem";
            this.LogOffMenuItem.Size = new System.Drawing.Size(183, 22);
            this.LogOffMenuItem.Text = "Cerrar Sesión";
            this.LogOffMenuItem.Click += new System.EventHandler(this.LogOffMenuItem_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(673, 21);
            this.WelcomeLabel.Spring = true;
            this.WelcomeLabel.Text = "                                     ";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeOfDayLabel
            // 
            this.TimeOfDayLabel.Name = "TimeOfDayLabel";
            this.TimeOfDayLabel.Size = new System.Drawing.Size(13, 21);
            this.TimeOfDayLabel.Text = "  ";
            this.TimeOfDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeOfDayLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TimeOfDayLabel.ToolTipText = "dd/MM/yyyy hh:mm tt";
            // 
            // dummyLabel01
            // 
            this.dummyLabel01.Name = "dummyLabel01";
            this.dummyLabel01.Size = new System.Drawing.Size(19, 21);
            this.dummyLabel01.Text = "    ";
            // 
            // WorldTimer
            // 
            this.WorldTimer.Enabled = true;
            this.WorldTimer.Interval = 500;
            this.WorldTimer.Tick += new System.EventHandler(this.WorldTimer_Tick);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(172, 60);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(260, 70);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Realizar Operaciones con clientes";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(8, 178);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(176, 53);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Finalizar el dia y realizar el cuadre";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(172, 172);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(260, 70);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Solicitar mas efectivo a la sucursal principal";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DetallesCuadre
            // 
            this.DetallesCuadre.Controls.Add(this.BalanceActualLabel);
            this.DetallesCuadre.Controls.Add(this.BalanceTitleLabel);
            this.DetallesCuadre.Controls.Add(this.Button2);
            this.DetallesCuadre.Controls.Add(this.CashInputButton);
            this.DetallesCuadre.Location = new System.Drawing.Point(594, 172);
            this.DetallesCuadre.Margin = new System.Windows.Forms.Padding(4);
            this.DetallesCuadre.Name = "DetallesCuadre";
            this.DetallesCuadre.Padding = new System.Windows.Forms.Padding(4);
            this.DetallesCuadre.Size = new System.Drawing.Size(193, 242);
            this.DetallesCuadre.TabIndex = 5;
            this.DetallesCuadre.TabStop = false;
            this.DetallesCuadre.Text = "Auditoría";
            // 
            // BalanceActualLabel
            // 
            this.BalanceActualLabel.Location = new System.Drawing.Point(19, 123);
            this.BalanceActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceActualLabel.Name = "BalanceActualLabel";
            this.BalanceActualLabel.Size = new System.Drawing.Size(156, 29);
            this.BalanceActualLabel.TabIndex = 2;
            this.BalanceActualLabel.Text = "$0.00";
            this.BalanceActualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BalanceActualLabel.Click += new System.EventHandler(this.BalanceActualLabel_Click);
            // 
            // BalanceTitleLabel
            // 
            this.BalanceTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BalanceTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BalanceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTitleLabel.Location = new System.Drawing.Point(8, 78);
            this.BalanceTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceTitleLabel.Name = "BalanceTitleLabel";
            this.BalanceTitleLabel.Size = new System.Drawing.Size(176, 91);
            this.BalanceTitleLabel.TabIndex = 1;
            this.BalanceTitleLabel.Text = "\r\nBalance de Caja:";
            this.BalanceTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CashInputButton
            // 
            this.CashInputButton.Location = new System.Drawing.Point(8, 21);
            this.CashInputButton.Margin = new System.Windows.Forms.Padding(4);
            this.CashInputButton.Name = "CashInputButton";
            this.CashInputButton.Size = new System.Drawing.Size(176, 48);
            this.CashInputButton.TabIndex = 0;
            this.CashInputButton.Text = "Entrada Manual de Efectivo";
            this.CashInputButton.UseVisualStyleBackColor = true;
            this.CashInputButton.Visible = false;
            this.CashInputButton.Click += new System.EventHandler(this.CashInputButton_Click);
            // 
            // CajaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetallesCuadre);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CajaMenuPrincipal";
            this.Text = "Aplicacion de caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CajaMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.CajaMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.DetallesCuadre.ResumeLayout(false);
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
        private System.Windows.Forms.Timer WorldTimer;
        private System.Windows.Forms.ToolStripStatusLabel dummyLabel01;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.GroupBox DetallesCuadre;
        private System.Windows.Forms.Label BalanceActualLabel;
        private System.Windows.Forms.Label BalanceTitleLabel;
        private System.Windows.Forms.Button CashInputButton;
        private System.Windows.Forms.ToolStripSeparator newUserSeparator;
        private System.Windows.Forms.ToolStripMenuItem newUserMenuItem;
    }
}