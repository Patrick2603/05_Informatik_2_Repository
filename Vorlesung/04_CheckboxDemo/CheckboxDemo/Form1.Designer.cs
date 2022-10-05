namespace CheckboxDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTitel = new System.Windows.Forms.CheckBox();
            this.checkBoxMessage = new System.Windows.Forms.CheckBox();
            this.radioButtonQuestion = new System.Windows.Forms.RadioButton();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonError = new System.Windows.Forms.RadioButton();
            this.radioButtonInfo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Was soll angezeigt werden?";
            // 
            // checkBoxTitel
            // 
            this.checkBoxTitel.AutoSize = true;
            this.checkBoxTitel.Checked = true;
            this.checkBoxTitel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTitel.Location = new System.Drawing.Point(12, 42);
            this.checkBoxTitel.Name = "checkBoxTitel";
            this.checkBoxTitel.Size = new System.Drawing.Size(71, 29);
            this.checkBoxTitel.TabIndex = 1;
            this.checkBoxTitel.Text = "Titel";
            this.checkBoxTitel.UseVisualStyleBackColor = true;
            // 
            // checkBoxMessage
            // 
            this.checkBoxMessage.AutoSize = true;
            this.checkBoxMessage.Checked = true;
            this.checkBoxMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMessage.Location = new System.Drawing.Point(12, 69);
            this.checkBoxMessage.Name = "checkBoxMessage";
            this.checkBoxMessage.Size = new System.Drawing.Size(116, 29);
            this.checkBoxMessage.TabIndex = 2;
            this.checkBoxMessage.Text = "Nachricht";
            this.checkBoxMessage.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion
            // 
            this.radioButtonQuestion.AutoSize = true;
            this.radioButtonQuestion.Checked = true;
            this.radioButtonQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuestion.Location = new System.Drawing.Point(12, 139);
            this.radioButtonQuestion.Name = "radioButtonQuestion";
            this.radioButtonQuestion.Size = new System.Drawing.Size(114, 29);
            this.radioButtonQuestion.TabIndex = 3;
            this.radioButtonQuestion.TabStop = true;
            this.radioButtonQuestion.Text = "als Frage";
            this.radioButtonQuestion.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(372, 198);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(126, 43);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Anzeigen";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wie soll die MessageBox angezeigt werden?";
            // 
            // radioButtonError
            // 
            this.radioButtonError.AutoSize = true;
            this.radioButtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonError.Location = new System.Drawing.Point(12, 174);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(118, 29);
            this.radioButtonError.TabIndex = 6;
            this.radioButtonError.Text = "als Fehler";
            this.radioButtonError.UseVisualStyleBackColor = true;
            // 
            // radioButtonInfo
            // 
            this.radioButtonInfo.AutoSize = true;
            this.radioButtonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInfo.Location = new System.Drawing.Point(12, 209);
            this.radioButtonInfo.Name = "radioButtonInfo";
            this.radioButtonInfo.Size = new System.Drawing.Size(95, 29);
            this.radioButtonInfo.TabIndex = 7;
            this.radioButtonInfo.Text = "als Info";
            this.radioButtonInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 253);
            this.Controls.Add(this.radioButtonInfo);
            this.Controls.Add(this.radioButtonError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.radioButtonQuestion);
            this.Controls.Add(this.checkBoxMessage);
            this.Controls.Add(this.checkBoxTitel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Checkbox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTitel;
        private System.Windows.Forms.CheckBox checkBoxMessage;
        private System.Windows.Forms.RadioButton radioButtonQuestion;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonError;
        private System.Windows.Forms.RadioButton radioButtonInfo;
    }
}

