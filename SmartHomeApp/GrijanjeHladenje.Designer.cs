namespace SmartHomeApp
{
    partial class GrijanjeHladenje
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.btnUgasiHladenje = new System.Windows.Forms.Button();
            this.btnUpaliHladenje = new System.Windows.Forms.Button();
            this.btnAutoGrijanjeHladenje = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUgasiGrijanje = new System.Windows.Forms.Button();
            this.btnUpaliGrijanje = new System.Windows.Forms.Button();
            this.lblStanjeHladenje = new System.Windows.Forms.Label();
            this.lblStanjeGrijanje = new System.Windows.Forms.Label();
            this.pbTemperatura = new SmartHomeApp.my_progress_bar_temp();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(364, 13);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(26, 25);
            this.lblTemp.TabIndex = 38;
            this.lblTemp.Text = "X";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "80°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "-40°C";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(22, 41);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(169, 31);
            this.tempLabel.TabIndex = 35;
            this.tempLabel.Text = "Temperatura";
            // 
            // btnUgasiHladenje
            // 
            this.btnUgasiHladenje.BackColor = System.Drawing.Color.IndianRed;
            this.btnUgasiHladenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUgasiHladenje.Location = new System.Drawing.Point(370, 132);
            this.btnUgasiHladenje.Name = "btnUgasiHladenje";
            this.btnUgasiHladenje.Size = new System.Drawing.Size(86, 50);
            this.btnUgasiHladenje.TabIndex = 40;
            this.btnUgasiHladenje.Text = "UGASI";
            this.btnUgasiHladenje.UseVisualStyleBackColor = false;
            this.btnUgasiHladenje.Click += new System.EventHandler(this.btnUgasiHladenje_Click);
            // 
            // btnUpaliHladenje
            // 
            this.btnUpaliHladenje.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpaliHladenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpaliHladenje.Location = new System.Drawing.Point(269, 132);
            this.btnUpaliHladenje.Name = "btnUpaliHladenje";
            this.btnUpaliHladenje.Size = new System.Drawing.Size(93, 50);
            this.btnUpaliHladenje.TabIndex = 39;
            this.btnUpaliHladenje.Text = "UPALI";
            this.btnUpaliHladenje.UseVisualStyleBackColor = false;
            this.btnUpaliHladenje.Click += new System.EventHandler(this.btnUpaliHladenje_Click);
            // 
            // btnAutoGrijanjeHladenje
            // 
            this.btnAutoGrijanjeHladenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutoGrijanjeHladenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoGrijanjeHladenje.Location = new System.Drawing.Point(463, 132);
            this.btnAutoGrijanjeHladenje.Name = "btnAutoGrijanjeHladenje";
            this.btnAutoGrijanjeHladenje.Size = new System.Drawing.Size(93, 106);
            this.btnAutoGrijanjeHladenje.TabIndex = 41;
            this.btnAutoGrijanjeHladenje.Text = "AUTO";
            this.btnAutoGrijanjeHladenje.UseVisualStyleBackColor = false;
            this.btnAutoGrijanjeHladenje.Click += new System.EventHandler(this.btnAutoGrijanjeHladenje_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(469, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 41);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 31);
            this.label7.TabIndex = 43;
            this.label7.Text = "Hlađenje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Grijanje:";
            // 
            // btnUgasiGrijanje
            // 
            this.btnUgasiGrijanje.BackColor = System.Drawing.Color.IndianRed;
            this.btnUgasiGrijanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUgasiGrijanje.Location = new System.Drawing.Point(370, 188);
            this.btnUgasiGrijanje.Name = "btnUgasiGrijanje";
            this.btnUgasiGrijanje.Size = new System.Drawing.Size(86, 50);
            this.btnUgasiGrijanje.TabIndex = 46;
            this.btnUgasiGrijanje.Text = "UGASI";
            this.btnUgasiGrijanje.UseVisualStyleBackColor = false;
            this.btnUgasiGrijanje.Click += new System.EventHandler(this.btnUgasiGrijanje_Click);
            // 
            // btnUpaliGrijanje
            // 
            this.btnUpaliGrijanje.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpaliGrijanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpaliGrijanje.Location = new System.Drawing.Point(269, 188);
            this.btnUpaliGrijanje.Name = "btnUpaliGrijanje";
            this.btnUpaliGrijanje.Size = new System.Drawing.Size(93, 50);
            this.btnUpaliGrijanje.TabIndex = 45;
            this.btnUpaliGrijanje.Text = "UPALI";
            this.btnUpaliGrijanje.UseVisualStyleBackColor = false;
            this.btnUpaliGrijanje.Click += new System.EventHandler(this.btnUpaliGrijanje_Click);
            // 
            // lblStanjeHladenje
            // 
            this.lblStanjeHladenje.AutoSize = true;
            this.lblStanjeHladenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanjeHladenje.Location = new System.Drawing.Point(144, 137);
            this.lblStanjeHladenje.Name = "lblStanjeHladenje";
            this.lblStanjeHladenje.Size = new System.Drawing.Size(29, 31);
            this.lblStanjeHladenje.TabIndex = 48;
            this.lblStanjeHladenje.Text = "0";
            // 
            // lblStanjeGrijanje
            // 
            this.lblStanjeGrijanje.AutoSize = true;
            this.lblStanjeGrijanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanjeGrijanje.Location = new System.Drawing.Point(144, 199);
            this.lblStanjeGrijanje.Name = "lblStanjeGrijanje";
            this.lblStanjeGrijanje.Size = new System.Drawing.Size(29, 31);
            this.lblStanjeGrijanje.TabIndex = 49;
            this.lblStanjeGrijanje.Text = "0";
            // 
            // pbTemperatura
            // 
            this.pbTemperatura.ForeColor = System.Drawing.Color.ForestGreen;
            this.pbTemperatura.Location = new System.Drawing.Point(214, 41);
            this.pbTemperatura.MarqueeAnimationSpeed = 150;
            this.pbTemperatura.Maximum = 120;
            this.pbTemperatura.Name = "pbTemperatura";
            this.pbTemperatura.Size = new System.Drawing.Size(342, 47);
            this.pbTemperatura.TabIndex = 34;
            // 
            // GrijanjeHladenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 308);
            this.ControlBox = false;
            this.Controls.Add(this.lblStanjeGrijanje);
            this.Controls.Add(this.lblStanjeHladenje);
            this.Controls.Add(this.btnUgasiGrijanje);
            this.Controls.Add(this.btnUpaliGrijanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAutoGrijanjeHladenje);
            this.Controls.Add(this.btnUgasiHladenje);
            this.Controls.Add(this.btnUpaliHladenje);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.pbTemperatura);
            this.Name = "GrijanjeHladenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GrijanjeHladenje";
            this.Load += new System.EventHandler(this.GrijanjeHladenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempLabel;
        private my_progress_bar_temp pbTemperatura;
        private System.Windows.Forms.Button btnUgasiHladenje;
        private System.Windows.Forms.Button btnUpaliHladenje;
        private System.Windows.Forms.Button btnAutoGrijanjeHladenje;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUgasiGrijanje;
        private System.Windows.Forms.Button btnUpaliGrijanje;
        private System.Windows.Forms.Label lblStanjeHladenje;
        private System.Windows.Forms.Label lblStanjeGrijanje;
    }
}