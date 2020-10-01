namespace PROYECTO_ESCUELA
{
    partial class generador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gradotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gradotxt
            // 
            this.gradotxt.Location = new System.Drawing.Point(12, 38);
            this.gradotxt.MaxLength = 18;
            this.gradotxt.Name = "gradotxt";
            this.gradotxt.Size = new System.Drawing.Size(52, 20);
            this.gradotxt.TabIndex = 25;
            this.gradotxt.Visible = false;
            this.gradotxt.TextChanged += new System.EventHandler(this.gradotxt_TextChanged);
            // 
            // generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 93);
            this.Controls.Add(this.gradotxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "generador";
            this.Text = "generador";
            this.Load += new System.EventHandler(this.generador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox gradotxt;
    }
}