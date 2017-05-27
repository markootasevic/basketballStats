namespace Forme
{
    partial class InsertGameStep1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtHomePts = new System.Windows.Forms.TextBox();
            this.txtGuestPts = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cbAwayTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domacin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj poena domaci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj poena gosti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum(dd.mm.yyyy)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Unesi igrace koji su igrali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHomePts
            // 
            this.txtHomePts.Location = new System.Drawing.Point(164, 158);
            this.txtHomePts.Name = "txtHomePts";
            this.txtHomePts.Size = new System.Drawing.Size(121, 20);
            this.txtHomePts.TabIndex = 6;
            // 
            // txtGuestPts
            // 
            this.txtGuestPts.Location = new System.Drawing.Point(164, 213);
            this.txtGuestPts.Name = "txtGuestPts";
            this.txtGuestPts.Size = new System.Drawing.Size(121, 20);
            this.txtGuestPts.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(164, 264);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 20);
            this.txtDate.TabIndex = 8;
            // 
            // cbHomeTeam
            // 
            this.cbHomeTeam.FormattingEnabled = true;
            this.cbHomeTeam.Location = new System.Drawing.Point(164, 37);
            this.cbHomeTeam.Name = "cbHomeTeam";
            this.cbHomeTeam.Size = new System.Drawing.Size(121, 21);
            this.cbHomeTeam.TabIndex = 9;
            // 
            // cbAwayTeam
            // 
            this.cbAwayTeam.FormattingEnabled = true;
            this.cbAwayTeam.Location = new System.Drawing.Point(164, 92);
            this.cbAwayTeam.Name = "cbAwayTeam";
            this.cbAwayTeam.Size = new System.Drawing.Size(121, 21);
            this.cbAwayTeam.TabIndex = 10;
            // 
            // InsertGameStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 422);
            this.Controls.Add(this.cbAwayTeam);
            this.Controls.Add(this.cbHomeTeam);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtGuestPts);
            this.Controls.Add(this.txtHomePts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertGameStep1";
            this.Text = "Dodaj utakmicu";
            this.Load += new System.EventHandler(this.InsertGameStep1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHomePts;
        private System.Windows.Forms.TextBox txtGuestPts;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cbHomeTeam;
        private System.Windows.Forms.ComboBox cbAwayTeam;
    }
}