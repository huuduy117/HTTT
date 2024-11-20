namespace Demo
{
    partial class MaHoa
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
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ HÓA ĐỐI XỨNG";
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(68, 166);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(211, 44);
            this.btn_Cong.TabIndex = 1;
            this.btn_Cong.Text = "Mã Hóa Đối Xứng Cộng";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Location = new System.Drawing.Point(311, 166);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(211, 44);
            this.btn_Nhan.TabIndex = 2;
            this.btn_Nhan.Text = "Mã Hóa Đối Xứng Nhân";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.btn_Nhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn phương thức mã hóa";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MaHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 315);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.label1);
            this.Name = "MaHoa";
            this.Text = "MaHoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}