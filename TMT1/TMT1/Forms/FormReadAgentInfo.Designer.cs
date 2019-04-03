namespace TMT1.Forms
{
    partial class FormReadAgentInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAgentID = new System.Windows.Forms.Label();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.labelAgentNickname = new System.Windows.Forms.Label();
            this.labelAgentAge = new System.Windows.Forms.Label();
            this.labelAgentTownId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "TownId";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelAgentID
            // 
            this.labelAgentID.AutoSize = true;
            this.labelAgentID.Location = new System.Drawing.Point(211, 37);
            this.labelAgentID.Name = "labelAgentID";
            this.labelAgentID.Size = new System.Drawing.Size(19, 25);
            this.labelAgentID.TabIndex = 5;
            this.labelAgentID.Text = "-";
            this.labelAgentID.Click += new System.EventHandler(this.LabelAgentID_Click);
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Location = new System.Drawing.Point(211, 79);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(19, 25);
            this.labelAgentName.TabIndex = 6;
            this.labelAgentName.Text = "-";
            // 
            // labelAgentNickname
            // 
            this.labelAgentNickname.AutoSize = true;
            this.labelAgentNickname.Location = new System.Drawing.Point(211, 125);
            this.labelAgentNickname.Name = "labelAgentNickname";
            this.labelAgentNickname.Size = new System.Drawing.Size(19, 25);
            this.labelAgentNickname.TabIndex = 7;
            this.labelAgentNickname.Text = "-";
            // 
            // labelAgentAge
            // 
            this.labelAgentAge.AutoSize = true;
            this.labelAgentAge.Location = new System.Drawing.Point(211, 169);
            this.labelAgentAge.Name = "labelAgentAge";
            this.labelAgentAge.Size = new System.Drawing.Size(19, 25);
            this.labelAgentAge.TabIndex = 8;
            this.labelAgentAge.Text = "-";
            // 
            // labelAgentTownId
            // 
            this.labelAgentTownId.AutoSize = true;
            this.labelAgentTownId.Location = new System.Drawing.Point(211, 214);
            this.labelAgentTownId.Name = "labelAgentTownId";
            this.labelAgentTownId.Size = new System.Drawing.Size(19, 25);
            this.labelAgentTownId.TabIndex = 9;
            this.labelAgentTownId.Text = "-";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TMT1.Properties.Resources.arrow_l3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(52, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TMT1.Properties.Resources.arrow_r3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(207, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 44);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(33, 347);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 28);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Search";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(311, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "GO!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Agent name:";
            // 
            // FormReadAgentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(433, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAgentTownId);
            this.Controls.Add(this.labelAgentAge);
            this.Controls.Add(this.labelAgentNickname);
            this.Controls.Add(this.labelAgentName);
            this.Controls.Add(this.labelAgentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(451, 544);
            this.MinimumSize = new System.Drawing.Size(451, 544);
            this.Name = "FormReadAgentInfo";
            this.Text = "FormReadAgentInfo";
            this.Load += new System.EventHandler(this.FormReadAgentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAgentID;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Label labelAgentNickname;
        private System.Windows.Forms.Label labelAgentAge;
        private System.Windows.Forms.Label labelAgentTownId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}