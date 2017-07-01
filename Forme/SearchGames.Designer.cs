namespace Forme
{
    partial class SearchGames
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxOnlyHome = new System.Windows.Forms.CheckBox();
            this.cboxOnlyGuest = new System.Windows.Forms.CheckBox();
            this.cboxChooseTeam = new System.Windows.Forms.CheckBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.cbGuestTeam = new System.Windows.Forms.ComboBox();
            this.cbHomeTeam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxOnlyHome);
            this.groupBox1.Controls.Add(this.cboxOnlyGuest);
            this.groupBox1.Controls.Add(this.cboxChooseTeam);
            this.groupBox1.Controls.Add(this.txtDateTo);
            this.groupBox1.Controls.Add(this.txtDateFrom);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTeam);
            this.groupBox1.Controls.Add(this.cbGuestTeam);
            this.groupBox1.Controls.Add(this.cbHomeTeam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxOnlyHome
            // 
            this.cboxOnlyHome.AutoSize = true;
            this.cboxOnlyHome.Location = new System.Drawing.Point(291, 136);
            this.cboxOnlyHome.Name = "cboxOnlyHome";
            this.cboxOnlyHome.Size = new System.Drawing.Size(175, 19);
            this.cboxOnlyHome.TabIndex = 14;
            this.cboxOnlyHome.Text = "primeni filter na domaci tim";
            this.cboxOnlyHome.UseVisualStyleBackColor = true;
            // 
            // cboxOnlyGuest
            // 
            this.cboxOnlyGuest.AutoSize = true;
            this.cboxOnlyGuest.Location = new System.Drawing.Point(291, 179);
            this.cboxOnlyGuest.Name = "cboxOnlyGuest";
            this.cboxOnlyGuest.Size = new System.Drawing.Size(183, 19);
            this.cboxOnlyGuest.TabIndex = 13;
            this.cboxOnlyGuest.Text = "primeni filter na gostujuci tim";
            this.cboxOnlyGuest.UseVisualStyleBackColor = true;
            // 
            // cboxChooseTeam
            // 
            this.cboxChooseTeam.AutoSize = true;
            this.cboxChooseTeam.Location = new System.Drawing.Point(291, 228);
            this.cboxChooseTeam.Name = "cboxChooseTeam";
            this.cboxChooseTeam.Size = new System.Drawing.Size(117, 19);
            this.cboxChooseTeam.TabIndex = 12;
            this.cboxChooseTeam.Text = "Izaberi samo tim";
            this.cboxChooseTeam.UseVisualStyleBackColor = true;
            this.cboxChooseTeam.CheckedChanged += new System.EventHandler(this.cboxChooseTeam_CheckedChanged);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(142, 83);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(121, 21);
            this.txtDateTo.TabIndex = 11;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(142, 42);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(121, 21);
            this.txtDateFrom.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Primeni filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(386, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 77);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Tim se odnosi na to ako niste sigurni da li je tim bio domacin ili gost(ova opci" +
    "ja onemogucije unos domaceg i gostujuceg tima)";
            // 
            // cbTeam
            // 
            this.cbTeam.Enabled = false;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(142, 224);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(121, 23);
            this.cbTeam.TabIndex = 7;
            // 
            // cbGuestTeam
            // 
            this.cbGuestTeam.FormattingEnabled = true;
            this.cbGuestTeam.Location = new System.Drawing.Point(142, 180);
            this.cbGuestTeam.Name = "cbGuestTeam";
            this.cbGuestTeam.Size = new System.Drawing.Size(121, 23);
            this.cbGuestTeam.TabIndex = 6;
            // 
            // cbHomeTeam
            // 
            this.cbHomeTeam.FormattingEnabled = true;
            this.cbHomeTeam.Location = new System.Drawing.Point(142, 137);
            this.cbHomeTeam.Name = "cbHomeTeam";
            this.cbHomeTeam.Size = new System.Drawing.Size(121, 23);
            this.cbHomeTeam.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gostujuci tim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domaci tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum do (mm.dd.yyy)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum od (mm.dd.yyy)";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(13, 311);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.Size = new System.Drawing.Size(607, 150);
            this.dgvSearchResults.TabIndex = 1;
            // 
            // SearchGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 475);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchGames";
            this.Text = "Pretrazi utakmice";
            this.Load += new System.EventHandler(this.SearchGames_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.ComboBox cbGuestTeam;
        private System.Windows.Forms.ComboBox cbHomeTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.CheckBox cboxChooseTeam;
        private System.Windows.Forms.CheckBox cboxOnlyHome;
        private System.Windows.Forms.CheckBox cboxOnlyGuest;
    }
}