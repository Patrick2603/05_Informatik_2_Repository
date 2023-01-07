
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
            this.pwdText = new System.Windows.Forms.TextBox();
            this.vglBtn = new System.Windows.Forms.Button();
            this.ergLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwdText
            // 
            this.pwdText.Location = new System.Drawing.Point(12, 12);
            this.pwdText.Multiline = true;
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(130, 39);
            this.pwdText.TabIndex = 0;
            // 
            // vglBtn
            // 
            this.vglBtn.Location = new System.Drawing.Point(176, 12);
            this.vglBtn.Name = "vglBtn";
            this.vglBtn.Size = new System.Drawing.Size(84, 27);
            this.vglBtn.TabIndex = 1;
            this.vglBtn.UseVisualStyleBackColor = true;
            this.vglBtn.Click += new System.EventHandler(this.vglBtn_Click);
            // 
            // ergLab
            // 
            this.ergLab.AutoSize = true;
            this.ergLab.Location = new System.Drawing.Point(12, 77);
            this.ergLab.Name = "ergLab";
            this.ergLab.Size = new System.Drawing.Size(35, 13);
            this.ergLab.TabIndex = 2;
            this.ergLab.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ergLab);
            this.Controls.Add(this.vglBtn);
            this.Controls.Add(this.pwdText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button vglBtn;
        private System.Windows.Forms.Label ergLab;
    }
}

