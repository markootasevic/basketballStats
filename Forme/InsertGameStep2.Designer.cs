﻿namespace Forme
{
    partial class InsertGameStep2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvHomePlayers = new System.Windows.Forms.DataGridView();
            this.dgvGuestPlayers = new System.Windows.Forms.DataGridView();
            this.cbHomePlayer = new System.Windows.Forms.ComboBox();
            this.cbGuestPlayer = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblGuestTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domacin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gosti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Igrac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Igrac";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(116, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(533, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvHomePlayers
            // 
            this.dgvHomePlayers.AllowUserToAddRows = false;
            this.dgvHomePlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomePlayers.Location = new System.Drawing.Point(12, 227);
            this.dgvHomePlayers.Name = "dgvHomePlayers";
            this.dgvHomePlayers.Size = new System.Drawing.Size(240, 150);
            this.dgvHomePlayers.TabIndex = 8;
            // 
            // dgvGuestPlayers
            // 
            this.dgvGuestPlayers.AllowUserToAddRows = false;
            this.dgvGuestPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestPlayers.Location = new System.Drawing.Point(398, 227);
            this.dgvGuestPlayers.Name = "dgvGuestPlayers";
            this.dgvGuestPlayers.Size = new System.Drawing.Size(240, 150);
            this.dgvGuestPlayers.TabIndex = 9;
            // 
            // cbHomePlayer
            // 
            this.cbHomePlayer.FormattingEnabled = true;
            this.cbHomePlayer.Location = new System.Drawing.Point(82, 85);
            this.cbHomePlayer.Name = "cbHomePlayer";
            this.cbHomePlayer.Size = new System.Drawing.Size(121, 21);
            this.cbHomePlayer.TabIndex = 10;
            // 
            // cbGuestPlayer
            // 
            this.cbGuestPlayer.FormattingEnabled = true;
            this.cbGuestPlayer.Location = new System.Drawing.Point(493, 84);
            this.cbGuestPlayer.Name = "cbGuestPlayer";
            this.cbGuestPlayer.Size = new System.Drawing.Size(121, 21);
            this.cbGuestPlayer.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(259, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sacuvaj utakmicu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(168, 23);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(0, 13);
            this.lblHomeTeam.TabIndex = 13;
            // 
            // lblGuestTeam
            // 
            this.lblGuestTeam.AutoSize = true;
            this.lblGuestTeam.Location = new System.Drawing.Point(582, 23);
            this.lblGuestTeam.Name = "lblGuestTeam";
            this.lblGuestTeam.Size = new System.Drawing.Size(0, 13);
            this.lblGuestTeam.TabIndex = 14;
            // 
            // InsertGameStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 483);
            this.Controls.Add(this.lblGuestTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbGuestPlayer);
            this.Controls.Add(this.cbHomePlayer);
            this.Controls.Add(this.dgvGuestPlayers);
            this.Controls.Add(this.dgvHomePlayers);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertGameStep2";
            this.Text = "Dodaj utakmicu";
            this.Load += new System.EventHandler(this.InsertGameStep2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomePlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvHomePlayers;
        private System.Windows.Forms.DataGridView dgvGuestPlayers;
        private System.Windows.Forms.ComboBox cbHomePlayer;
        private System.Windows.Forms.ComboBox cbGuestPlayer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblGuestTeam;
    }
}