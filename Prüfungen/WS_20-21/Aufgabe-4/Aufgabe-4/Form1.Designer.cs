
namespace Aufgabe_4
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.t1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(91, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(12, 12);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(61, 20);
            this.n1.TabIndex = 1;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(12, 41);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.TextBox t1;
    }
}

