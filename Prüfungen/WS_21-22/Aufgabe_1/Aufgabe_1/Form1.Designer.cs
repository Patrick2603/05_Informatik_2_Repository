
namespace Aufgabe_1
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
            this.tBaktLeistung = new System.Windows.Forms.TextBox();
            this.chBWaschmaschine = new System.Windows.Forms.CheckBox();
            this.chBTrockner = new System.Windows.Forms.CheckBox();
            this.chBSpülmaschine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tBaktLeistung
            // 
            this.tBaktLeistung.Location = new System.Drawing.Point(12, 12);
            this.tBaktLeistung.Name = "tBaktLeistung";
            this.tBaktLeistung.Size = new System.Drawing.Size(100, 20);
            this.tBaktLeistung.TabIndex = 0;
            this.tBaktLeistung.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chBWaschmaschine
            // 
            this.chBWaschmaschine.AutoSize = true;
            this.chBWaschmaschine.Location = new System.Drawing.Point(12, 62);
            this.chBWaschmaschine.Name = "chBWaschmaschine";
            this.chBWaschmaschine.Size = new System.Drawing.Size(105, 17);
            this.chBWaschmaschine.TabIndex = 1;
            this.chBWaschmaschine.Text = "Waschmaschine";
            this.chBWaschmaschine.UseVisualStyleBackColor = true;
            // 
            // chBTrockner
            // 
            this.chBTrockner.AutoSize = true;
            this.chBTrockner.Location = new System.Drawing.Point(12, 98);
            this.chBTrockner.Name = "chBTrockner";
            this.chBTrockner.Size = new System.Drawing.Size(69, 17);
            this.chBTrockner.TabIndex = 2;
            this.chBTrockner.Text = "Trockner";
            this.chBTrockner.UseVisualStyleBackColor = true;
            // 
            // chBSpülmaschine
            // 
            this.chBSpülmaschine.AutoSize = true;
            this.chBSpülmaschine.Location = new System.Drawing.Point(12, 136);
            this.chBSpülmaschine.Name = "chBSpülmaschine";
            this.chBSpülmaschine.Size = new System.Drawing.Size(92, 17);
            this.chBSpülmaschine.TabIndex = 3;
            this.chBSpülmaschine.Text = "Spülmaschine";
            this.chBSpülmaschine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chBSpülmaschine);
            this.Controls.Add(this.chBTrockner);
            this.Controls.Add(this.chBWaschmaschine);
            this.Controls.Add(this.tBaktLeistung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBaktLeistung;
        private System.Windows.Forms.CheckBox chBWaschmaschine;
        private System.Windows.Forms.CheckBox chBTrockner;
        private System.Windows.Forms.CheckBox chBSpülmaschine;
    }
}

