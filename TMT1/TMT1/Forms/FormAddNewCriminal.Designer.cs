namespace TMT1.Forms
{
    partial class FormAddNewCriminal
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelNickName = new System.Windows.Forms.Label();
            this.labeltownId = new System.Windows.Forms.Label();
            this.labelCrime = new System.Windows.Forms.Label();
            this.labelSentence = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelEvilnessFactor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(1, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickName.Location = new System.Drawing.Point(1, 43);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(81, 20);
            this.labelNickName.TabIndex = 1;
            this.labelNickName.Text = "NickName";
            // 
            // labeltownId
            // 
            this.labeltownId.AutoSize = true;
            this.labeltownId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltownId.Location = new System.Drawing.Point(1, 87);
            this.labeltownId.Name = "labeltownId";
            this.labeltownId.Size = new System.Drawing.Size(61, 20);
            this.labeltownId.TabIndex = 2;
            this.labeltownId.Text = "TownId";
            // 
            // labelCrime
            // 
            this.labelCrime.AutoSize = true;
            this.labelCrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrime.Location = new System.Drawing.Point(1, 120);
            this.labelCrime.Name = "labelCrime";
            this.labelCrime.Size = new System.Drawing.Size(50, 20);
            this.labelCrime.TabIndex = 3;
            this.labelCrime.Text = "Crime";
            // 
            // labelSentence
            // 
            this.labelSentence.AutoSize = true;
            this.labelSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSentence.Location = new System.Drawing.Point(1, 152);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(78, 20);
            this.labelSentence.TabIndex = 4;
            this.labelSentence.Text = "Sentence";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(1, 187);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            // 
            // labelEvilnessFactor
            // 
            this.labelEvilnessFactor.AutoSize = true;
            this.labelEvilnessFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEvilnessFactor.Location = new System.Drawing.Point(1, 222);
            this.labelEvilnessFactor.Name = "labelEvilnessFactor";
            this.labelEvilnessFactor.Size = new System.Drawing.Size(113, 20);
            this.labelEvilnessFactor.TabIndex = 6;
            this.labelEvilnessFactor.Text = "EvilnessFactor";
            // 
            // FormAddNewCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.labelEvilnessFactor);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSentence);
            this.Controls.Add(this.labelCrime);
            this.Controls.Add(this.labeltownId);
            this.Controls.Add(this.labelNickName);
            this.Controls.Add(this.labelName);
            this.Name = "FormAddNewCriminal";
            this.Text = "FormAddNewCriminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.Label labeltownId;
        private System.Windows.Forms.Label labelCrime;
        private System.Windows.Forms.Label labelSentence;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelEvilnessFactor;
    }
}