namespace cinemaAppWihtPdf
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedSeatesLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Increase1 = new System.Windows.Forms.Button();
            this.Increase2 = new System.Windows.Forms.Button();
            this.Increase3 = new System.Windows.Forms.Button();
            this.Decrease1 = new System.Windows.Forms.Button();
            this.Decrease2 = new System.Windows.Forms.Button();
            this.Decrease3 = new System.Windows.Forms.Button();
            this.ColaPiece = new System.Windows.Forms.Label();
            this.PopPiece = new System.Windows.Forms.Label();
            this.ChocoPiece = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(311, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Seates";
            // 
            // SelectedSeatesLbl
            // 
            this.SelectedSeatesLbl.AutoSize = true;
            this.SelectedSeatesLbl.BackColor = System.Drawing.Color.LightGray;
            this.SelectedSeatesLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedSeatesLbl.Font = new System.Drawing.Font("Tahoma", 20F);
            this.SelectedSeatesLbl.Location = new System.Drawing.Point(317, 251);
            this.SelectedSeatesLbl.Name = "SelectedSeatesLbl";
            this.SelectedSeatesLbl.Size = new System.Drawing.Size(25, 35);
            this.SelectedSeatesLbl.TabIndex = 1;
            this.SelectedSeatesLbl.Text = " ";
            this.SelectedSeatesLbl.Click += new System.EventHandler(this.SelectedSeatesLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(89, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cola :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(80, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Popcorn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(79, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chocolate :";
            // 
            // Increase1
            // 
            this.Increase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Increase1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Increase1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Increase1.Location = new System.Drawing.Point(228, 210);
            this.Increase1.Name = "Increase1";
            this.Increase1.Size = new System.Drawing.Size(60, 50);
            this.Increase1.TabIndex = 5;
            this.Increase1.Text = "+";
            this.Increase1.UseVisualStyleBackColor = false;
            this.Increase1.Click += new System.EventHandler(this.Increase1_Click);
            // 
            // Increase2
            // 
            this.Increase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Increase2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Increase2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Increase2.Location = new System.Drawing.Point(228, 265);
            this.Increase2.Name = "Increase2";
            this.Increase2.Size = new System.Drawing.Size(60, 50);
            this.Increase2.TabIndex = 6;
            this.Increase2.Text = "+";
            this.Increase2.UseVisualStyleBackColor = false;
            this.Increase2.Click += new System.EventHandler(this.Increase2_Click);
            // 
            // Increase3
            // 
            this.Increase3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Increase3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Increase3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Increase3.Location = new System.Drawing.Point(228, 321);
            this.Increase3.Name = "Increase3";
            this.Increase3.Size = new System.Drawing.Size(60, 50);
            this.Increase3.TabIndex = 7;
            this.Increase3.Text = "+";
            this.Increase3.UseVisualStyleBackColor = false;
            this.Increase3.Click += new System.EventHandler(this.Increase3_Click);
            // 
            // Decrease1
            // 
            this.Decrease1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Decrease1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrease1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.Decrease1.Location = new System.Drawing.Point(14, 206);
            this.Decrease1.Name = "Decrease1";
            this.Decrease1.Size = new System.Drawing.Size(60, 50);
            this.Decrease1.TabIndex = 8;
            this.Decrease1.Text = "-";
            this.Decrease1.UseVisualStyleBackColor = false;
            this.Decrease1.Click += new System.EventHandler(this.Decrease1_Click);
            // 
            // Decrease2
            // 
            this.Decrease2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Decrease2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrease2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.Decrease2.Location = new System.Drawing.Point(14, 263);
            this.Decrease2.Name = "Decrease2";
            this.Decrease2.Size = new System.Drawing.Size(60, 50);
            this.Decrease2.TabIndex = 9;
            this.Decrease2.Text = "-";
            this.Decrease2.UseVisualStyleBackColor = false;
            this.Decrease2.Click += new System.EventHandler(this.Decrease2_Click);
            // 
            // Decrease3
            // 
            this.Decrease3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Decrease3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrease3.Font = new System.Drawing.Font("Tahoma", 25F);
            this.Decrease3.Location = new System.Drawing.Point(14, 319);
            this.Decrease3.Name = "Decrease3";
            this.Decrease3.Size = new System.Drawing.Size(60, 50);
            this.Decrease3.TabIndex = 10;
            this.Decrease3.Text = "-";
            this.Decrease3.UseVisualStyleBackColor = false;
            this.Decrease3.Click += new System.EventHandler(this.Decrease3_Click);
            // 
            // ColaPiece
            // 
            this.ColaPiece.AutoSize = true;
            this.ColaPiece.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ColaPiece.Location = new System.Drawing.Point(190, 224);
            this.ColaPiece.Name = "ColaPiece";
            this.ColaPiece.Size = new System.Drawing.Size(0, 24);
            this.ColaPiece.TabIndex = 11;
            this.ColaPiece.TextChanged += new System.EventHandler(this.ColaPiece_TextChanged);
            // 
            // PopPiece
            // 
            this.PopPiece.AutoSize = true;
            this.PopPiece.Font = new System.Drawing.Font("Tahoma", 15F);
            this.PopPiece.Location = new System.Drawing.Point(190, 277);
            this.PopPiece.Name = "PopPiece";
            this.PopPiece.Size = new System.Drawing.Size(0, 24);
            this.PopPiece.TabIndex = 12;
            this.PopPiece.TextChanged += new System.EventHandler(this.PopPiece_TextChanged);
            // 
            // ChocoPiece
            // 
            this.ChocoPiece.AutoSize = true;
            this.ChocoPiece.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ChocoPiece.Location = new System.Drawing.Point(190, 337);
            this.ChocoPiece.Name = "ChocoPiece";
            this.ChocoPiece.Size = new System.Drawing.Size(0, 24);
            this.ChocoPiece.TabIndex = 13;
            this.ChocoPiece.TextChanged += new System.EventHandler(this.ChocoPiece_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(527, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price :";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLbl.Font = new System.Drawing.Font("Tahoma", 20F);
            this.PriceLbl.Location = new System.Drawing.Point(623, 204);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(25, 35);
            this.PriceLbl.TabIndex = 15;
            this.PriceLbl.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(7, 388);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(138, 44);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Price :";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Tahoma", 20F);
            this.TotalPriceLbl.Location = new System.Drawing.Point(166, 396);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(23, 33);
            this.TotalPriceLbl.TabIndex = 17;
            this.TotalPriceLbl.Text = " ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 25F);
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(478, 388);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(281, 50);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save & Print";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textBoxName.Location = new System.Drawing.Point(212, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 32);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textBoxEmail.Location = new System.Drawing.Point(212, 75);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(219, 32);
            this.textBoxEmail.TabIndex = 20;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textBoxPhone.Location = new System.Drawing.Point(212, 135);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(219, 32);
            this.textBoxPhone.TabIndex = 21;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lblName.Location = new System.Drawing.Point(6, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 28);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Customer Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lblEmail.Location = new System.Drawing.Point(6, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(158, 28);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email  Addres:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lblPhone.Location = new System.Drawing.Point(6, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(177, 28);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone Number :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChocoPiece);
            this.Controls.Add(this.PopPiece);
            this.Controls.Add(this.ColaPiece);
            this.Controls.Add(this.Decrease3);
            this.Controls.Add(this.Decrease2);
            this.Controls.Add(this.Decrease1);
            this.Controls.Add(this.Increase3);
            this.Controls.Add(this.Increase2);
            this.Controls.Add(this.Increase1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedSeatesLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectedSeatesLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Increase1;
        private System.Windows.Forms.Button Increase2;
        private System.Windows.Forms.Button Increase3;
        private System.Windows.Forms.Button Decrease1;
        private System.Windows.Forms.Button Decrease2;
        private System.Windows.Forms.Button Decrease3;
        private System.Windows.Forms.Label ColaPiece;
        private System.Windows.Forms.Label PopPiece;
        private System.Windows.Forms.Label ChocoPiece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
    }
}

