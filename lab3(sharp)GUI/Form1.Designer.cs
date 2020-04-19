namespace lab3_sharp_GUI
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.NumberForm_Label = new System.Windows.Forms.Label();
            this.AlgebraicButton = new System.Windows.Forms.Button();
            this.TrigonometricButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(22, 394);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 33);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(40, 214);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 31);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(40, 121);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 22);
            this.textBox_x.TabIndex = 2;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(40, 162);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 22);
            this.textBox_y.TabIndex = 3;
            // 
            // NumberForm_Label
            // 
            this.NumberForm_Label.AutoSize = true;
            this.NumberForm_Label.Location = new System.Drawing.Point(455, 49);
            this.NumberForm_Label.Name = "NumberForm_Label";
            this.NumberForm_Label.Size = new System.Drawing.Size(214, 17);
            this.NumberForm_Label.TabIndex = 4;
            this.NumberForm_Label.Text = "В какой форме вводить число?";
            // 
            // AlgebraicButton
            // 
            this.AlgebraicButton.Location = new System.Drawing.Point(364, 84);
            this.AlgebraicButton.Name = "AlgebraicButton";
            this.AlgebraicButton.Size = new System.Drawing.Size(155, 46);
            this.AlgebraicButton.TabIndex = 5;
            this.AlgebraicButton.Text = "Алгебраической";
            this.AlgebraicButton.UseVisualStyleBackColor = true;
            // 
            // TrigonometricButton
            // 
            this.TrigonometricButton.Location = new System.Drawing.Point(567, 84);
            this.TrigonometricButton.Name = "TrigonometricButton";
            this.TrigonometricButton.Size = new System.Drawing.Size(160, 46);
            this.TrigonometricButton.TabIndex = 6;
            this.TrigonometricButton.Text = "Тригонометрической";
            this.TrigonometricButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrigonometricButton);
            this.Controls.Add(this.AlgebraicButton);
            this.Controls.Add(this.NumberForm_Label);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label NumberForm_Label;
        private System.Windows.Forms.Button AlgebraicButton;
        private System.Windows.Forms.Button TrigonometricButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

