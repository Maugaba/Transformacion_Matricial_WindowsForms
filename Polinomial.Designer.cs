namespace Transformacion_Matricial_WindowsForms
{
    partial class Polinomial
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SliderY = new System.Windows.Forms.TrackBar();
            this.SliderX = new System.Windows.Forms.TrackBar();
            this.SliderGrado = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1510, 882);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 47);
            this.label6.TabIndex = 17;
            this.label6.Text = "Slider Posicion Grados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1639, 776);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 47);
            this.label5.TabIndex = 16;
            this.label5.Text = "Slider Posicion Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1405, 776);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 47);
            this.label4.TabIndex = 15;
            this.label4.Text = "Slider Posicion X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1616, 965);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1720, 858);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1485, 858);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // SliderY
            // 
            this.SliderY.Location = new System.Drawing.Point(1614, 826);
            this.SliderY.Maximum = 50;
            this.SliderY.Minimum = -50;
            this.SliderY.Name = "SliderY";
            this.SliderY.Size = new System.Drawing.Size(236, 45);
            this.SliderY.TabIndex = 11;
            this.SliderY.Scroll += new System.EventHandler(this.SliderY_Scroll);
            // 
            // SliderX
            // 
            this.SliderX.Location = new System.Drawing.Point(1380, 826);
            this.SliderX.Maximum = 50;
            this.SliderX.Minimum = -50;
            this.SliderX.Name = "SliderX";
            this.SliderX.Size = new System.Drawing.Size(236, 45);
            this.SliderX.TabIndex = 10;
            this.SliderX.Scroll += new System.EventHandler(this.SliderX_Scroll);
            // 
            // SliderGrado
            // 
            this.SliderGrado.Location = new System.Drawing.Point(1371, 932);
            this.SliderGrado.Maximum = 90;
            this.SliderGrado.Minimum = -90;
            this.SliderGrado.Name = "SliderGrado";
            this.SliderGrado.Size = new System.Drawing.Size(487, 45);
            this.SliderGrado.TabIndex = 9;
            this.SliderGrado.Scroll += new System.EventHandler(this.SliderGrado_Scroll);
            // 
            // Polinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SliderY);
            this.Controls.Add(this.SliderX);
            this.Controls.Add(this.SliderGrado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Polinomial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polinomial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Polinomial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SliderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SliderY;
        private System.Windows.Forms.TrackBar SliderX;
        private System.Windows.Forms.TrackBar SliderGrado;
    }
}