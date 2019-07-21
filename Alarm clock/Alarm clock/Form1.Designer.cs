namespace Alarm_clock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_SelectFont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(194, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(170, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "button1";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 98);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(194, 56);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(170, 23);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "button2";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // btn_SelectFont
            // 
            this.btn_SelectFont.Location = new System.Drawing.Point(194, 95);
            this.btn_SelectFont.Name = "btn_SelectFont";
            this.btn_SelectFont.Size = new System.Drawing.Size(170, 23);
            this.btn_SelectFont.TabIndex = 4;
            this.btn_SelectFont.Text = "button3";
            this.btn_SelectFont.UseVisualStyleBackColor = true;
            this.btn_SelectFont.Click += new System.EventHandler(this.Btn_SelectFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 145);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SelectFont);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_SelectFont;
        private System.Windows.Forms.Label label2;
    }
}

