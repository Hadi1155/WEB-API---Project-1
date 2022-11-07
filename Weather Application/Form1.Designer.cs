
namespace Weather_Application
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
            this.LabCity = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabCondition = new System.Windows.Forms.Label();
            this.LabDetail = new System.Windows.Forms.Label();
            this.LabSunset = new System.Windows.Forms.Label();
            this.LabSunrise = new System.Windows.Forms.Label();
            this.LabNA = new System.Windows.Forms.Label();
            this.labNA2 = new System.Windows.Forms.Label();
            this.labNA4 = new System.Windows.Forms.Label();
            this.labNA3 = new System.Windows.Forms.Label();
            this.labpresssure = new System.Windows.Forms.Label();
            this.labwinspeed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabCity
            // 
            this.LabCity.AutoSize = true;
            this.LabCity.BackColor = System.Drawing.Color.Transparent;
            this.LabCity.Font = new System.Drawing.Font("Calibri", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCity.ForeColor = System.Drawing.Color.Transparent;
            this.LabCity.Location = new System.Drawing.Point(139, 145);
            this.LabCity.Name = "LabCity";
            this.LabCity.Size = new System.Drawing.Size(110, 64);
            this.LabCity.TabIndex = 0;
            this.LabCity.Text = "City";
            this.LabCity.Click += new System.EventHandler(this.TBCity_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(296, 142);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(547, 72);
            this.TBCity.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(880, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabCondition
            // 
            this.LabCondition.AutoSize = true;
            this.LabCondition.BackColor = System.Drawing.Color.Transparent;
            this.LabCondition.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondition.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabCondition.Location = new System.Drawing.Point(142, 486);
            this.LabCondition.Name = "LabCondition";
            this.LabCondition.Size = new System.Drawing.Size(214, 59);
            this.LabCondition.TabIndex = 4;
            this.LabCondition.Text = "Condition";
            this.LabCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabDetail
            // 
            this.LabDetail.AutoSize = true;
            this.LabDetail.BackColor = System.Drawing.Color.Transparent;
            this.LabDetail.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabDetail.Location = new System.Drawing.Point(142, 570);
            this.LabDetail.Name = "LabDetail";
            this.LabDetail.Size = new System.Drawing.Size(139, 59);
            this.LabDetail.TabIndex = 5;
            this.LabDetail.Text = "Detail";
            // 
            // LabSunset
            // 
            this.LabSunset.AutoSize = true;
            this.LabSunset.BackColor = System.Drawing.Color.Transparent;
            this.LabSunset.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabSunset.Location = new System.Drawing.Point(142, 787);
            this.LabSunset.Name = "LabSunset";
            this.LabSunset.Size = new System.Drawing.Size(180, 59);
            this.LabSunset.TabIndex = 7;
            this.LabSunset.Text = "Sunset :";
            this.LabSunset.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabSunrise
            // 
            this.LabSunrise.AutoSize = true;
            this.LabSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LabSunrise.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunrise.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabSunrise.Location = new System.Drawing.Point(142, 703);
            this.LabSunrise.Name = "LabSunrise";
            this.LabSunrise.Size = new System.Drawing.Size(192, 59);
            this.LabSunrise.TabIndex = 6;
            this.LabSunrise.Text = "Sunrise :";
            this.LabSunrise.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LabNA
            // 
            this.LabNA.AutoSize = true;
            this.LabNA.BackColor = System.Drawing.Color.Transparent;
            this.LabNA.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LabNA.Location = new System.Drawing.Point(361, 703);
            this.LabNA.Name = "LabNA";
            this.LabNA.Size = new System.Drawing.Size(101, 59);
            this.LabNA.TabIndex = 8;
            this.LabNA.Text = "N/A";
            // 
            // labNA2
            // 
            this.labNA2.AutoSize = true;
            this.labNA2.BackColor = System.Drawing.Color.Transparent;
            this.labNA2.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNA2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labNA2.Location = new System.Drawing.Point(361, 787);
            this.labNA2.Name = "labNA2";
            this.labNA2.Size = new System.Drawing.Size(101, 59);
            this.labNA2.TabIndex = 9;
            this.labNA2.Text = "N/A";
            // 
            // labNA4
            // 
            this.labNA4.AutoSize = true;
            this.labNA4.BackColor = System.Drawing.Color.Transparent;
            this.labNA4.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNA4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labNA4.Location = new System.Drawing.Point(1275, 570);
            this.labNA4.Name = "labNA4";
            this.labNA4.Size = new System.Drawing.Size(101, 59);
            this.labNA4.TabIndex = 13;
            this.labNA4.Text = "N/A";
            this.labNA4.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labNA3
            // 
            this.labNA3.AutoSize = true;
            this.labNA3.BackColor = System.Drawing.Color.Transparent;
            this.labNA3.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNA3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labNA3.Location = new System.Drawing.Point(1275, 486);
            this.labNA3.Name = "labNA3";
            this.labNA3.Size = new System.Drawing.Size(101, 59);
            this.labNA3.TabIndex = 12;
            this.labNA3.Text = "N/A";
            this.labNA3.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // labpresssure
            // 
            this.labpresssure.AutoSize = true;
            this.labpresssure.BackColor = System.Drawing.Color.Transparent;
            this.labpresssure.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpresssure.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labpresssure.Location = new System.Drawing.Point(962, 570);
            this.labpresssure.Name = "labpresssure";
            this.labpresssure.Size = new System.Drawing.Size(217, 59);
            this.labpresssure.TabIndex = 11;
            this.labpresssure.Text = "Pressure :";
            this.labpresssure.Click += new System.EventHandler(this.label3_Click);
            // 
            // labwinspeed
            // 
            this.labwinspeed.AutoSize = true;
            this.labwinspeed.BackColor = System.Drawing.Color.Transparent;
            this.labwinspeed.Font = new System.Drawing.Font("Calibri", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwinspeed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labwinspeed.Location = new System.Drawing.Point(962, 486);
            this.labwinspeed.Name = "labwinspeed";
            this.labwinspeed.Size = new System.Drawing.Size(284, 59);
            this.labwinspeed.TabIndex = 10;
            this.labwinspeed.Text = "Wind Speed :";
            this.labwinspeed.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(152, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_Application.Properties.Resources.kul1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1925, 1122);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labNA4);
            this.Controls.Add(this.labNA3);
            this.Controls.Add(this.labpresssure);
            this.Controls.Add(this.labwinspeed);
            this.Controls.Add(this.labNA2);
            this.Controls.Add(this.LabNA);
            this.Controls.Add(this.LabSunset);
            this.Controls.Add(this.LabSunrise);
            this.Controls.Add(this.LabDetail);
            this.Controls.Add(this.LabCondition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.LabCity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCity;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabCondition;
        private System.Windows.Forms.Label LabDetail;
        private System.Windows.Forms.Label LabSunset;
        private System.Windows.Forms.Label LabSunrise;
        private System.Windows.Forms.Label LabNA;
        private System.Windows.Forms.Label labNA2;
        private System.Windows.Forms.Label labNA4;
        private System.Windows.Forms.Label labNA3;
        private System.Windows.Forms.Label labpresssure;
        private System.Windows.Forms.Label labwinspeed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

