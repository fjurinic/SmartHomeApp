namespace SmartHomeApp
{
    partial class Rolete
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNacinRadaRoleta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoRolete = new System.Windows.Forms.Button();
            this.btnSpusti = new System.Windows.Forms.Button();
            this.btnDigni = new System.Windows.Forms.Button();
            this.btnSredina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(403, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 41);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNacinRadaRoleta
            // 
            this.lblNacinRadaRoleta.AutoSize = true;
            this.lblNacinRadaRoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacinRadaRoleta.Location = new System.Drawing.Point(210, 12);
            this.lblNacinRadaRoleta.Name = "lblNacinRadaRoleta";
            this.lblNacinRadaRoleta.Size = new System.Drawing.Size(24, 25);
            this.lblNacinRadaRoleta.TabIndex = 53;
            this.lblNacinRadaRoleta.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 31);
            this.label7.TabIndex = 52;
            this.label7.Text = "Rolete";
            // 
            // btnAutoRolete
            // 
            this.btnAutoRolete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutoRolete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoRolete.Location = new System.Drawing.Point(403, 15);
            this.btnAutoRolete.Name = "btnAutoRolete";
            this.btnAutoRolete.Size = new System.Drawing.Size(93, 50);
            this.btnAutoRolete.TabIndex = 51;
            this.btnAutoRolete.Text = "AUTO";
            this.btnAutoRolete.UseVisualStyleBackColor = false;
            this.btnAutoRolete.Click += new System.EventHandler(this.btnAutoRolete_Click);
            // 
            // btnSpusti
            // 
            this.btnSpusti.BackColor = System.Drawing.Color.IndianRed;
            this.btnSpusti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpusti.Location = new System.Drawing.Point(403, 183);
            this.btnSpusti.Name = "btnSpusti";
            this.btnSpusti.Size = new System.Drawing.Size(93, 50);
            this.btnSpusti.TabIndex = 50;
            this.btnSpusti.Text = "SPUSTI";
            this.btnSpusti.UseVisualStyleBackColor = false;
            this.btnSpusti.Click += new System.EventHandler(this.btnSpusti_Click);
            // 
            // btnDigni
            // 
            this.btnDigni.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDigni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigni.Location = new System.Drawing.Point(403, 71);
            this.btnDigni.Name = "btnDigni";
            this.btnDigni.Size = new System.Drawing.Size(93, 50);
            this.btnDigni.TabIndex = 49;
            this.btnDigni.Text = "DIGNI";
            this.btnDigni.UseVisualStyleBackColor = false;
            this.btnDigni.Click += new System.EventHandler(this.btnDigni_Click);
            // 
            // btnSredina
            // 
            this.btnSredina.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSredina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSredina.Location = new System.Drawing.Point(403, 127);
            this.btnSredina.Name = "btnSredina";
            this.btnSredina.Size = new System.Drawing.Size(93, 50);
            this.btnSredina.TabIndex = 54;
            this.btnSredina.Text = "SREDINA";
            this.btnSredina.UseVisualStyleBackColor = false;
            this.btnSredina.Click += new System.EventHandler(this.btnSredina_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartHomeApp.Properties.Resources.ON;
            this.pictureBox1.Location = new System.Drawing.Point(47, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Rolete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 308);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSredina);
            this.Controls.Add(this.lblNacinRadaRoleta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAutoRolete);
            this.Controls.Add(this.btnSpusti);
            this.Controls.Add(this.btnDigni);
            this.Controls.Add(this.btnBack);
            this.Name = "Rolete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rolete";
            this.Load += new System.EventHandler(this.Rolete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNacinRadaRoleta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAutoRolete;
        private System.Windows.Forms.Button btnSpusti;
        private System.Windows.Forms.Button btnDigni;
        private System.Windows.Forms.Button btnSredina;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}