namespace PROYECTO_ESCUELA
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.menu_vertical = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.tx_listas = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_direc = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bT_ALUMNO = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.txlista = new System.Windows.Forms.ComboBox();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barraTitulo.Controls.Add(this.iconcerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(238, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1062, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1026, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(33, 32);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // menu_vertical
            // 
            this.menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menu_vertical.Controls.Add(this.txlista);
            this.menu_vertical.Controls.Add(this.button9);
            this.menu_vertical.Controls.Add(this.tx_listas);
            this.menu_vertical.Controls.Add(this.button8);
            this.menu_vertical.Controls.Add(this.button7);
            this.menu_vertical.Controls.Add(this.button6);
            this.menu_vertical.Controls.Add(this.button1);
            this.menu_vertical.Controls.Add(this.tx_direc);
            this.menu_vertical.Controls.Add(this.button3);
            this.menu_vertical.Controls.Add(this.button4);
            this.menu_vertical.Controls.Add(this.button5);
            this.menu_vertical.Controls.Add(this.button2);
            this.menu_vertical.Controls.Add(this.bT_ALUMNO);
            this.menu_vertical.Controls.Add(this.pictureBox1);
            this.menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.menu_vertical.Name = "menu_vertical";
            this.menu_vertical.Size = new System.Drawing.Size(238, 650);
            this.menu_vertical.TabIndex = 0;
            this.menu_vertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_vertical_Paint);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-9, 622);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(250, 40);
            this.button9.TabIndex = 11;
            this.button9.Text = "BUSCAR";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tx_listas
            // 
            this.tx_listas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tx_listas.FormattingEnabled = true;
            this.tx_listas.Items.AddRange(new object[] {
            "1°A",
            "2°A",
            "3°A",
            "4°A",
            "5°A",
            "6°A"});
            this.tx_listas.Location = new System.Drawing.Point(42, 328);
            this.tx_listas.Name = "tx_listas";
            this.tx_listas.Size = new System.Drawing.Size(159, 21);
            this.tx_listas.TabIndex = 10;
            this.tx_listas.SelectedIndexChanged += new System.EventHandler(this.tx_listas_SelectedIndexChanged);
            this.tx_listas.TextChanged += new System.EventHandler(this.tx_listas_TextChanged);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-9, 576);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 40);
            this.button8.TabIndex = 9;
            this.button8.Text = "ARCHIVOS";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-9, 530);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "ESTADISTICA";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-9, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "CALIFICACION";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "BIMESTRALES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tx_direc
            // 
            this.tx_direc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tx_direc.FormattingEnabled = true;
            this.tx_direc.Items.AddRange(new object[] {
            "1°A",
            "2°A",
            "3°A",
            "4°A",
            "5°A",
            "6°A"});
            this.tx_direc.Location = new System.Drawing.Point(42, 241);
            this.tx_direc.Name = "tx_direc";
            this.tx_direc.Size = new System.Drawing.Size(159, 21);
            this.tx_direc.TabIndex = 5;
            this.tx_direc.SelectedIndexChanged += new System.EventHandler(this.tx_direc_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "DIRECTORIO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-9, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "LISTAS ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-9, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "BOLETA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "GRUPOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bT_ALUMNO
            // 
            this.bT_ALUMNO.FlatAppearance.BorderSize = 0;
            this.bT_ALUMNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bT_ALUMNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bT_ALUMNO.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT_ALUMNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bT_ALUMNO.Image = ((System.Drawing.Image)(resources.GetObject("bT_ALUMNO.Image")));
            this.bT_ALUMNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bT_ALUMNO.Location = new System.Drawing.Point(0, 93);
            this.bT_ALUMNO.Name = "bT_ALUMNO";
            this.bT_ALUMNO.Size = new System.Drawing.Size(250, 40);
            this.bT_ALUMNO.TabIndex = 1;
            this.bT_ALUMNO.Text = "ALUMNOS";
            this.bT_ALUMNO.UseVisualStyleBackColor = true;
            this.bT_ALUMNO.Click += new System.EventHandler(this.bT_ALUMNO_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contenedor.BackgroundImage")));
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(238, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1062, 600);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // txlista
            // 
            this.txlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txlista.FormattingEnabled = true;
            this.txlista.Items.AddRange(new object[] {
            "1°A",
            "2°A",
            "3°A",
            "4°A",
            "5°A",
            "6°A"});
            this.txlista.Location = new System.Drawing.Point(42, 387);
            this.txlista.Name = "txlista";
            this.txlista.Size = new System.Drawing.Size(159, 21);
            this.txlista.TabIndex = 12;
            this.txlista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.principal_Load);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bT_ALUMNO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel menu_vertical;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox tx_direc;
        //private System.Windows.Forms.ComboBox txt_listas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox tx_listas;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox txlista;
    }
}

