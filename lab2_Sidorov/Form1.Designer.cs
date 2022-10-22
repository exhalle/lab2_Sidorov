namespace lab2_Sidorov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_XOR_Click = new System.Windows.Forms.Button();
            this.groupBox1_Xor_encoder = new System.Windows.Forms.GroupBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.label_Key = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1_Xor_encoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_XOR_Click
            // 
            this.button_XOR_Click.Location = new System.Drawing.Point(259, 91);
            this.button_XOR_Click.Name = "button_XOR_Click";
            this.button_XOR_Click.Size = new System.Drawing.Size(75, 23);
            this.button_XOR_Click.TabIndex = 0;
            this.button_XOR_Click.Text = "XOR";
            this.button_XOR_Click.UseVisualStyleBackColor = true;
            this.button_XOR_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1_Xor_encoder
            // 
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_C);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_Key);
            this.groupBox1_Xor_encoder.Controls.Add(this.textBox_P);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_C);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_Key);
            this.groupBox1_Xor_encoder.Controls.Add(this.label_P);
            this.groupBox1_Xor_encoder.Controls.Add(this.button_Clear);
            this.groupBox1_Xor_encoder.Controls.Add(this.button_XOR_Click);
            this.groupBox1_Xor_encoder.Location = new System.Drawing.Point(12, 21);
            this.groupBox1_Xor_encoder.Name = "groupBox1_Xor_encoder";
            this.groupBox1_Xor_encoder.Size = new System.Drawing.Size(356, 231);
            this.groupBox1_Xor_encoder.TabIndex = 1;
            this.groupBox1_Xor_encoder.TabStop = false;
            this.groupBox1_Xor_encoder.Text = "XOR Encoder";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(130, 129);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 7;
            this.textBox_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(130, 91);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 6;
            this.textBox_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(130, 61);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 5;
            this.textBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(50, 132);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(26, 16);
            this.label_C.TabIndex = 4;
            this.label_C.Text = "C =";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(50, 97);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(40, 16);
            this.label_Key.TabIndex = 3;
            this.label_Key.Text = "Key =";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(50, 67);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(26, 16);
            this.label_P.TabIndex = 2;
            this.label_P.Text = "P =";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(155, 192);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 282);
            this.Controls.Add(this.groupBox1_Xor_encoder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1_Xor_encoder.ResumeLayout(false);
            this.groupBox1_Xor_encoder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_XOR_Click;
        private System.Windows.Forms.GroupBox groupBox1_Xor_encoder;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Button button_Clear;
    }
}

