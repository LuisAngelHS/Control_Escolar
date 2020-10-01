namespace PROYECTO_ESCUELA
{
    partial class archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archivos));
            this.bt_examinar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_Abrir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_examinar
            // 
            this.bt_examinar.BackColor = System.Drawing.Color.Blue;
            this.bt_examinar.Location = new System.Drawing.Point(597, 129);
            this.bt_examinar.Name = "bt_examinar";
            this.bt_examinar.Size = new System.Drawing.Size(96, 40);
            this.bt_examinar.TabIndex = 0;
            this.bt_examinar.Text = "Examinar";
            this.bt_examinar.UseVisualStyleBackColor = false;
            this.bt_examinar.Click += new System.EventHandler(this.bt_examinar_Click);
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.BackColor = System.Drawing.Color.Blue;
            this.bt_Abrir.Location = new System.Drawing.Point(597, 175);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(96, 37);
            this.bt_Abrir.TabIndex = 1;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = false;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(808, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(26, 24);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcerrar.TabIndex = 2413;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 2414;
            this.label1.Text = "BUSCAR ARCHIVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::PROYECTO_ESCUELA.Properties.Resources.archivo;
            this.ClientSize = new System.Drawing.Size(846, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_Abrir);
            this.Controls.Add(this.bt_examinar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "archivos";
            this.Text = "archivos";
            this.Load += new System.EventHandler(this.archivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_examinar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_Abrir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label label1;
    }
}