namespace Demo
{
    partial class MaHoaDoiXungCong
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
            this.mr_Key = new System.Windows.Forms.NumericUpDown();
            this.rdo_GiaiMa = new System.Windows.Forms.RadioButton();
            this.rdo_MaHoa = new System.Windows.Forms.RadioButton();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_noidung = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mr_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // mr_Key
            // 
            this.mr_Key.Location = new System.Drawing.Point(347, 168);
            this.mr_Key.Margin = new System.Windows.Forms.Padding(4);
            this.mr_Key.Name = "mr_Key";
            this.mr_Key.Size = new System.Drawing.Size(79, 22);
            this.mr_Key.TabIndex = 21;
            // 
            // rdo_GiaiMa
            // 
            this.rdo_GiaiMa.AutoSize = true;
            this.rdo_GiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_GiaiMa.Location = new System.Drawing.Point(502, 221);
            this.rdo_GiaiMa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_GiaiMa.Name = "rdo_GiaiMa";
            this.rdo_GiaiMa.Size = new System.Drawing.Size(101, 28);
            this.rdo_GiaiMa.TabIndex = 20;
            this.rdo_GiaiMa.TabStop = true;
            this.rdo_GiaiMa.Text = "Giải mã";
            this.rdo_GiaiMa.UseVisualStyleBackColor = true;
            this.rdo_GiaiMa.CheckedChanged += new System.EventHandler(this.rdo_GiaiMa_CheckedChanged);
            // 
            // rdo_MaHoa
            // 
            this.rdo_MaHoa.AutoSize = true;
            this.rdo_MaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaHoa.Location = new System.Drawing.Point(359, 221);
            this.rdo_MaHoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_MaHoa.Name = "rdo_MaHoa";
            this.rdo_MaHoa.Size = new System.Drawing.Size(100, 28);
            this.rdo_MaHoa.TabIndex = 19;
            this.rdo_MaHoa.TabStop = true;
            this.rdo_MaHoa.Text = "Mã hóa";
            this.rdo_MaHoa.UseVisualStyleBackColor = true;
            this.rdo_MaHoa.CheckedChanged += new System.EventHandler(this.rdo_MaHoa_CheckedChanged);
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(347, 339);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(267, 58);
            this.btn_Run.TabIndex = 18;
            this.btn_Run.Text = "Mã hóa Massage";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(546, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "MÃ HÓA ĐỐI XỨNG BẰNG PHÉP CỘNG";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(347, 275);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(265, 22);
            this.txt_Result.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Action:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Message:";
            // 
            // cbb_noidung
            // 
            this.cbb_noidung.FormattingEnabled = true;
            this.cbb_noidung.Location = new System.Drawing.Point(347, 107);
            this.cbb_noidung.Name = "cbb_noidung";
            this.cbb_noidung.Size = new System.Drawing.Size(267, 24);
            this.cbb_noidung.TabIndex = 22;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 393);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 45);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // MaHoaDoiXungCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.cbb_noidung);
            this.Controls.Add(this.mr_Key);
            this.Controls.Add(this.rdo_GiaiMa);
            this.Controls.Add(this.rdo_MaHoa);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MaHoaDoiXungCong";
            this.Text = "MaHoaDoiXungCong";
            this.Load += new System.EventHandler(this.MaHoaDoiXungCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mr_Key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mr_Key;
        private System.Windows.Forms.RadioButton rdo_GiaiMa;
        private System.Windows.Forms.RadioButton rdo_MaHoa;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_noidung;
        private System.Windows.Forms.Button btn_Back;
    }
}