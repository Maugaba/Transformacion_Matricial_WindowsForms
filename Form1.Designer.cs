namespace Transformacion_Matricial_WindowsForms
{
    partial class Form1
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
            this.SliderGrado = new System.Windows.Forms.TrackBar();
            this.SliderX = new System.Windows.Forms.TrackBar();
            this.SliderY = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).BeginInit();
            this.SuspendLayout();
            // 
            // SliderGrado
            // 
            this.SliderGrado.Location = new System.Drawing.Point(301, 333);
            this.SliderGrado.Maximum = 90;
            this.SliderGrado.Minimum = -90;
            this.SliderGrado.Name = "SliderGrado";
            this.SliderGrado.Size = new System.Drawing.Size(487, 45);
            this.SliderGrado.TabIndex = 0;
            this.SliderGrado.Value = 30;
            this.SliderGrado.Scroll += new System.EventHandler(this.SliderGrado_Scroll);
            // 
            // SliderX
            // 
            this.SliderX.Location = new System.Drawing.Point(301, 283);
            this.SliderX.Maximum = 50;
            this.SliderX.Minimum = -50;
            this.SliderX.Name = "SliderX";
            this.SliderX.Size = new System.Drawing.Size(236, 45);
            this.SliderX.TabIndex = 1;
            this.SliderX.Value = 1;
            this.SliderX.Scroll += new System.EventHandler(this.SliderX_Scroll);
            // 
            // SliderY
            // 
            this.SliderY.Location = new System.Drawing.Point(552, 283);
            this.SliderY.Maximum = 50;
            this.SliderY.Minimum = -50;
            this.SliderY.Name = "SliderY";
            this.SliderY.Size = new System.Drawing.Size(236, 45);
            this.SliderY.TabIndex = 2;
            this.SliderY.Value = -2;
            this.SliderY.Scroll += new System.EventHandler(this.SliderY_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SliderY);
            this.Controls.Add(this.SliderX);
            this.Controls.Add(this.SliderGrado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SliderGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar SliderGrado;
        private System.Windows.Forms.TrackBar SliderX;
        private System.Windows.Forms.TrackBar SliderY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

