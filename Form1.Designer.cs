﻿namespace PokemondexN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPikachu = new Button();
            btnEspeon = new Button();
            bthHatterene = new Button();
            btnSwirlix = new Button();
            bthJigglypuff = new Button();
            bthAlcremie = new Button();
            lbName = new Label();
            lbType = new Label();
            lbStats = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPikachu
            // 
            btnPikachu.BackColor = Color.White;
            btnPikachu.ForeColor = Color.MediumVioletRed;
            btnPikachu.Location = new Point(40, 35);
            btnPikachu.Name = "btnPikachu";
            btnPikachu.Size = new Size(94, 29);
            btnPikachu.TabIndex = 0;
            btnPikachu.Text = "Pikachu";
            btnPikachu.UseVisualStyleBackColor = false;
            btnPikachu.Click += btnPikachu_Click;
            // 
            // btnBeedrill
            // 
            btnBeedrill.ForeColor = Color.DeepPink;
            btnBeedrill.Location = new Point(40, 103);
            btnBeedrill.Name = "btnBeedrill";
            btnBeedrill.Size = new Size(94, 29);
            btnBeedrill.TabIndex = 1;
            btnBeedrill.Text = "Beedrill";
            btnBeedrill.UseVisualStyleBackColor = true;
            btnBeedrill.Click += btnBeedrill_Click;
            // 
            // bthBulbasaur
            // 
            bthBulbasaur.ForeColor = Color.HotPink;
            bthBulbasaur.Location = new Point(40, 165);
            bthBulbasaur.Name = "bthBulbasaur";
            bthBulbasaur.Size = new Size(94, 29);
            bthBulbasaur.TabIndex = 2;
            bthBulbasaur.Text = "Bulbasaur";
            bthBulbasaur.UseVisualStyleBackColor = true;
            bthBulbasaur.Click += bthBulbasaur_Click;
            // 
            // btnButterfee
            // 
            btnButterfee.ForeColor = Color.PaleVioletRed;
            btnButterfee.Location = new Point(40, 233);
            btnButterfee.Name = "btnButterfee";
            btnButterfee.Size = new Size(94, 29);
            btnButterfee.TabIndex = 3;
            btnButterfee.Text = "Butterfee";
            btnButterfee.UseVisualStyleBackColor = true;
            btnButterfee.Click += btnButterfee_Click;
            // 
            // bthCharizard
            // 
            bthCharizard.ForeColor = Color.Pink;
            bthCharizard.Location = new Point(40, 301);
            bthCharizard.Name = "bthCharizard";
            bthCharizard.Size = new Size(94, 29);
            bthCharizard.TabIndex = 4;
            bthCharizard.Text = "Charizard";
            bthCharizard.UseVisualStyleBackColor = true;
            bthCharizard.Click += bthCharizard_Click;
            // 
            // bthSquirtle
            // 
            bthSquirtle.ForeColor = Color.LightPink;
            bthSquirtle.Location = new Point(40, 362);
            bthSquirtle.Name = "bthSquirtle";
            bthSquirtle.Size = new Size(94, 29);
            bthSquirtle.TabIndex = 5;
            bthSquirtle.Text = "Squirtle";
            bthSquirtle.UseVisualStyleBackColor = true;
            bthSquirtle.Click += bthSquirtle_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.MediumVioletRed;
            lbName.Location = new Point(479, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.ForeColor = Color.DeepPink;
            lbType.Location = new Point(479, 125);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 20);
            lbType.TabIndex = 7;
            lbType.Text = "Type";
            // 
            // lbStats
            // 
            lbStats.AutoSize = true;
            lbStats.ForeColor = Color.HotPink;
            lbStats.Location = new Point(479, 165);
            lbStats.Name = "lbStats";
            lbStats.Size = new Size(75, 20);
            lbStats.TabIndex = 8;
            lbStats.Text = "BasicStats";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pikachu;
            pictureBox1.Location = new Point(172, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbStats);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(bthAlcremie);
            Controls.Add(bthJigglypuff);
            Controls.Add(btnSwirlix);
            Controls.Add(bthHatterene);
            Controls.Add(btnEspeon);
            Controls.Add(btnPikachu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPikachu;
        private Button btnEspeon;
        private Button bthHatterene;
        private Button btnSwirlix;
        private Button bthJigglypuff;
        private Button bthAlcremie;
        private Label lbName;
        private Label lbType;
        private Label lbStats;
        private PictureBox pictureBox1;
    }
}
