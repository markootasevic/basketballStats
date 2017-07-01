namespace Forme
{
    partial class SearchStatsStep1
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbPlayer);
            this.groupBox1.Controls.Add(this.cbTeam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Primeni fliter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(77, 131);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(121, 23);
            this.cbPlayer.TabIndex = 5;
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(77, 55);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(121, 23);
            this.cbTeam.TabIndex = 4;
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Igrac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tim";
            // 
            // dgvStats
            // 
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(23, 236);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.Size = new System.Drawing.Size(585, 189);
            this.dgvStats.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Prikazi izabranu statistiku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchStatsStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchStatsStep1";
            this.Text = "Pretrazi statistike";
            this.Load += new System.EventHandler(this.SearchStatsStep1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Button button2;
    }
}