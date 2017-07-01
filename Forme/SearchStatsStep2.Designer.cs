namespace Forme
{
    partial class SearchStatsStep2
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.dgvStatItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igrac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utakmica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stavke statistike:";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(94, 34);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            this.txtPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer.TabIndex = 4;
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(94, 88);
            this.txtGame.Name = "txtGame";
            this.txtGame.ReadOnly = true;
            this.txtGame.Size = new System.Drawing.Size(243, 20);
            this.txtGame.TabIndex = 5;
            // 
            // dgvStatItems
            // 
            this.dgvStatItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatItems.Location = new System.Drawing.Point(12, 215);
            this.dgvStatItems.Name = "dgvStatItems";
            this.dgvStatItems.ReadOnly = true;
            this.dgvStatItems.Size = new System.Drawing.Size(312, 213);
            this.dgvStatItems.TabIndex = 7;
            // 
            // SearchStatsStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 463);
            this.Controls.Add(this.dgvStatItems);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchStatsStep2";
            this.Text = "Pretrazi statistike";
            this.Load += new System.EventHandler(this.SearchStatsStep2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.DataGridView dgvStatItems;
    }
}