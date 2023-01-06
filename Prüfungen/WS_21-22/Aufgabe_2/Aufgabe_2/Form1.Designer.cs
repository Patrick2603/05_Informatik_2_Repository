
namespace Aufgabe_2
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tBBeschreibung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tBStatus = new System.Windows.Forms.TextBox();
            this.tBNummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // tBBeschreibung
            // 
            this.tBBeschreibung.Location = new System.Drawing.Point(12, 29);
            this.tBBeschreibung.Multiline = true;
            this.tBBeschreibung.Name = "tBBeschreibung";
            this.tBBeschreibung.Size = new System.Drawing.Size(603, 20);
            this.tBBeschreibung.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "einfügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(603, 359);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Status ändern";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tBStatus
            // 
            this.tBStatus.Location = new System.Drawing.Point(701, 122);
            this.tBStatus.Multiline = true;
            this.tBStatus.Name = "tBStatus";
            this.tBStatus.Size = new System.Drawing.Size(88, 32);
            this.tBStatus.TabIndex = 5;
            // 
            // tBNummer
            // 
            this.tBNummer.Location = new System.Drawing.Point(701, 68);
            this.tBNummer.Multiline = true;
            this.tBNummer.Name = "tBNummer";
            this.tBNummer.Size = new System.Drawing.Size(88, 32);
            this.tBNummer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBNummer);
            this.Controls.Add(this.tBStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBBeschreibung);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tBBeschreibung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tBStatus;
        private System.Windows.Forms.TextBox tBNummer;
    }
}

