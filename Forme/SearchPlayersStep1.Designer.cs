namespace Forme
{
    partial class SearchPlayersStep1
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFoundPlayers = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriterijum pretrage(Naziv igraca)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(196, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvFoundPlayers
            // 
            this.dgvFoundPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundPlayers.Location = new System.Drawing.Point(82, 111);
            this.dgvFoundPlayers.Name = "dgvFoundPlayers";
            this.dgvFoundPlayers.Size = new System.Drawing.Size(180, 268);
            this.dgvFoundPlayers.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Prikazi podatke za izabranog igraca";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchPlayersStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvFoundPlayers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "SearchPlayersStep1";
            this.Text = "Pretrazi igrace";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFoundPlayers;
        private System.Windows.Forms.Button button2;
    }
}