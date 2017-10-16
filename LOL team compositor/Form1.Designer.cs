namespace LOL_team_compositor
{
    partial class Form1
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
            this.Reroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sup = new System.Windows.Forms.PictureBox();
            this.Adc = new System.Windows.Forms.PictureBox();
            this.Jng = new System.Windows.Forms.PictureBox();
            this.Mid = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            this.SuspendLayout();
            // 
            // Reroll
            // 
            this.Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reroll.Location = new System.Drawing.Point(206, 131);
            this.Reroll.Name = "Reroll";
            this.Reroll.Size = new System.Drawing.Size(112, 108);
            this.Reroll.TabIndex = 6;
            this.Reroll.Text = "LOSUJ";
            this.Reroll.UseVisualStyleBackColor = true;
            this.Reroll.Click += new System.EventHandler(this.Reroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "JGL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(225, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "MID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(343, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "ADC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(458, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "SUP";
            // 
            // Sup
            // 
            this.Sup.Image = global::LOL_team_compositor.Properties.Resources._1_empty;
            this.Sup.Location = new System.Drawing.Point(464, 50);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(60, 60);
            this.Sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sup.TabIndex = 5;
            this.Sup.TabStop = false;
            this.Sup.Click += new System.EventHandler(this.Sup_Click);
            // 
            // Adc
            // 
            this.Adc.Image = global::LOL_team_compositor.Properties.Resources._1_empty;
            this.Adc.Location = new System.Drawing.Point(349, 50);
            this.Adc.Name = "Adc";
            this.Adc.Size = new System.Drawing.Size(60, 60);
            this.Adc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Adc.TabIndex = 4;
            this.Adc.TabStop = false;
            this.Adc.Click += new System.EventHandler(this.Adc_Click);
            // 
            // Jng
            // 
            this.Jng.Image = global::LOL_team_compositor.Properties.Resources._1_empty;
            this.Jng.Location = new System.Drawing.Point(122, 50);
            this.Jng.Name = "Jng";
            this.Jng.Size = new System.Drawing.Size(60, 60);
            this.Jng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jng.TabIndex = 3;
            this.Jng.TabStop = false;
            this.Jng.Click += new System.EventHandler(this.Jng_Click);
            // 
            // Mid
            // 
            this.Mid.Image = global::LOL_team_compositor.Properties.Resources._1_empty;
            this.Mid.Location = new System.Drawing.Point(231, 50);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(60, 60);
            this.Mid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mid.TabIndex = 2;
            this.Mid.TabStop = false;
            this.Mid.Click += new System.EventHandler(this.Mid_Click);
            // 
            // Top
            // 
            this.Top.Image = global::LOL_team_compositor.Properties.Resources._1_empty;
            this.Top.Location = new System.Drawing.Point(12, 50);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(60, 60);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 1;
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 258);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reroll);
            this.Controls.Add(this.Sup);
            this.Controls.Add(this.Adc);
            this.Controls.Add(this.Jng);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "LOLOWY LOSOWACZ";
            ((System.ComponentModel.ISupportInitialize)(this.Sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox Mid;
        private System.Windows.Forms.PictureBox Jng;
        private System.Windows.Forms.PictureBox Adc;
        private System.Windows.Forms.PictureBox Sup;
        private System.Windows.Forms.Button Reroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

