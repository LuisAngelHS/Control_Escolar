namespace PROYECTO_ESCUELA
{
    partial class login
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
            this.tx_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.tx_contrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_user
            // 
            this.tx_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tx_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tx_user.BackColor = System.Drawing.SystemColors.Window;
            this.tx_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tx_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_user.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tx_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tx_user.HintForeColor = System.Drawing.Color.Empty;
            this.tx_user.HintText = "";
            this.tx_user.isPassword = false;
            this.tx_user.LineFocusedColor = System.Drawing.Color.Blue;
            this.tx_user.LineIdleColor = System.Drawing.Color.Gray;
            this.tx_user.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tx_user.LineThickness = 3;
            this.tx_user.Location = new System.Drawing.Point(160, 122);
            this.tx_user.Margin = new System.Windows.Forms.Padding(4);
            this.tx_user.MaxLength = 32767;
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(200, 33);
            this.tx_user.TabIndex = 0;
            this.tx_user.Text = "NombreUsuario";
            this.tx_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_user.Enter += new System.EventHandler(this.tx_user_Enter);
            this.tx_user.Leave += new System.EventHandler(this.tx_user_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(56, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbuser
            // 
            this.lbuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbuser.AutoSize = true;
            this.lbuser.BackColor = System.Drawing.Color.Transparent;
            this.lbuser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.ForeColor = System.Drawing.Color.Red;
            this.lbuser.Location = new System.Drawing.Point(171, 159);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(47, 15);
            this.lbuser.TabIndex = 24;
            this.lbuser.Text = "Usuario";
            this.lbuser.Visible = false;
            this.lbuser.Click += new System.EventHandler(this.lbuser_Click);
            // 
            // lbpass
            // 
            this.lbpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.SystemColors.Window;
            this.lbpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.ForeColor = System.Drawing.Color.Red;
            this.lbpass.Location = new System.Drawing.Point(29, 229);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(69, 15);
            this.lbpass.TabIndex = 25;
            this.lbpass.Text = "Contraseña";
            this.lbpass.Visible = false;
            // 
            // lblogin
            // 
            this.lblogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblogin.AutoSize = true;
            this.lblogin.BackColor = System.Drawing.SystemColors.Window;
            this.lblogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.Color.Red;
            this.lblogin.Location = new System.Drawing.Point(53, 268);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(42, 15);
            this.lblogin.TabIndex = 26;
            this.lblogin.Text = "Login?";
            this.lblogin.Visible = false;
            // 
            // tx_contrase
            // 
            this.tx_contrase.Location = new System.Drawing.Point(32, 206);
            this.tx_contrase.Name = "tx_contrase";
            this.tx_contrase.PasswordChar = '*';
            this.tx_contrase.Size = new System.Drawing.Size(173, 20);
            this.tx_contrase.TabIndex = 1;
            this.tx_contrase.Leave += new System.EventHandler(this.tx_contrase_Leave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_ESCUELA.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_contrase);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_user);
            this.Name = "login";
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tx_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox tx_contrase;
    }
}