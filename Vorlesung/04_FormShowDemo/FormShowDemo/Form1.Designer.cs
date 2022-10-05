namespace FormShowDemo
{
    partial class Form1
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
            this.showButton = new System.Windows.Forms.Button();
            this.showModalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(12, 12);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(183, 60);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Zeige Dialog";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showModalButton
            // 
            this.showModalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModalButton.Location = new System.Drawing.Point(201, 12);
            this.showModalButton.Name = "showModalButton";
            this.showModalButton.Size = new System.Drawing.Size(183, 60);
            this.showModalButton.TabIndex = 1;
            this.showModalButton.Text = "Zeige modalen Dialog";
            this.showModalButton.UseVisualStyleBackColor = true;
            this.showModalButton.Click += new System.EventHandler(this.showModalButton_Click);
            this.showModalButton.MouseEnter += new System.EventHandler(this.showModalButton_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 96);
            this.Controls.Add(this.showModalButton);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Hauptformular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button showModalButton;
    }
}

