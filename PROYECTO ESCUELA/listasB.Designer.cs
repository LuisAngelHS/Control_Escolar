namespace PROYECTO_ESCUELA
{
    partial class listasB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listasB));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_grupo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.listadobtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtruta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listadobtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "MENU IMPRESIONES DE LISTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "GRUPO:";
            // 
            // Cmb_grupo
            // 
            this.Cmb_grupo.BackColor = System.Drawing.SystemColors.Control;
            this.Cmb_grupo.BorderRadius = 1;
            this.Cmb_grupo.Color = System.Drawing.SystemColors.ButtonShadow;
            this.Cmb_grupo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Cmb_grupo.DisabledColor = System.Drawing.Color.Gray;
            this.Cmb_grupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_grupo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.Cmb_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_grupo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Cmb_grupo.FillDropDown = false;
            this.Cmb_grupo.FillIndicator = false;
            this.Cmb_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_grupo.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_grupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cmb_grupo.FormattingEnabled = true;
            this.Cmb_grupo.Icon = null;
            this.Cmb_grupo.IndicatorColor = System.Drawing.SystemColors.Highlight;
            this.Cmb_grupo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Cmb_grupo.ItemBackColor = System.Drawing.Color.White;
            this.Cmb_grupo.ItemBorderColor = System.Drawing.Color.White;
            this.Cmb_grupo.ItemForeColor = System.Drawing.Color.Black;
            this.Cmb_grupo.ItemHeight = 26;
            this.Cmb_grupo.ItemHighLightColor = System.Drawing.SystemColors.Highlight;
            this.Cmb_grupo.Items.AddRange(new object[] {
            "1°A",
            "2°A",
            "3°A",
            "4°A",
            "5°A",
            "6°A",
            "4°A"});
            this.Cmb_grupo.Location = new System.Drawing.Point(180, 88);
            this.Cmb_grupo.Name = "Cmb_grupo";
            this.Cmb_grupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cmb_grupo.Size = new System.Drawing.Size(148, 32);
            this.Cmb_grupo.TabIndex = 10;
            this.Cmb_grupo.Text = "Seleccione el grupo";
            // 
            // listadobtn
            // 
            this.listadobtn.Image = ((System.Drawing.Image)(resources.GetObject("listadobtn.Image")));
            this.listadobtn.ImageActive = null;
            this.listadobtn.Location = new System.Drawing.Point(128, 220);
            this.listadobtn.Name = "listadobtn";
            this.listadobtn.Size = new System.Drawing.Size(231, 50);
            this.listadobtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.listadobtn.TabIndex = 13;
            this.listadobtn.TabStop = false;
            this.listadobtn.Zoom = 10;
            this.listadobtn.Click += new System.EventHandler(this.listadobtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NOMBRE:";
            // 
            // txtruta
            // 
            this.txtruta.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtruta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtruta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtruta.BorderThickness = 3;
            this.txtruta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtruta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtruta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtruta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtruta.isPassword = false;
            this.txtruta.Location = new System.Drawing.Point(165, 142);
            this.txtruta.Margin = new System.Windows.Forms.Padding(4);
            this.txtruta.MaxLength = 32767;
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(217, 44);
            this.txtruta.TabIndex = 14;
            this.txtruta.Text = "Nombre del archivo";
            this.txtruta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(492, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(26, 24);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcerrar.TabIndex = 2412;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // listasB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 303);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.listadobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_grupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listasB";
            this.Text = "listasB";
            ((System.ComponentModel.ISupportInitialize)(this.listadobtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown Cmb_grupo;
        private Bunifu.Framework.UI.BunifuImageButton listadobtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtruta;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}