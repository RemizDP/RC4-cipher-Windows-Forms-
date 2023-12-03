namespace CursZD
{
    partial class MessageInput
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
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecipherButton = new System.Windows.Forms.RadioButton();
            this.CipherButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.NumsCheckBox = new System.Windows.Forms.CheckBox();
            this.LatinHighCheckBox = new System.Windows.Forms.CheckBox();
            this.LatinLowCheckBox = new System.Windows.Forms.CheckBox();
            this.MinPasswordPhrazeLengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyLengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(51, 67);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(343, 334);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Текстовое сообщение:";
            // 
            // DecipherButton
            // 
            this.DecipherButton.AutoSize = true;
            this.DecipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecipherButton.Location = new System.Drawing.Point(222, 14);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(148, 24);
            this.DecipherButton.TabIndex = 1;
            this.DecipherButton.TabStop = true;
            this.DecipherButton.Text = "Дешифрование";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.CheckedChanged += new System.EventHandler(this.DecipherRadioButton_CheckedChanged);
            // 
            // CipherButton
            // 
            this.CipherButton.AutoSize = true;
            this.CipherButton.Checked = true;
            this.CipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherButton.Location = new System.Drawing.Point(32, 14);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(127, 24);
            this.CipherButton.TabIndex = 0;
            this.CipherButton.TabStop = true;
            this.CipherButton.Text = "Шифрование";
            this.CipherButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpecialCheckBox);
            this.groupBox1.Controls.Add(this.NumsCheckBox);
            this.groupBox1.Controls.Add(this.LatinHighCheckBox);
            this.groupBox1.Controls.Add(this.LatinLowCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(597, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 166);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложность парольной фразы";
            // 
            // SpecialCheckBox
            // 
            this.SpecialCheckBox.AutoSize = true;
            this.SpecialCheckBox.Location = new System.Drawing.Point(6, 123);
            this.SpecialCheckBox.Name = "SpecialCheckBox";
            this.SpecialCheckBox.Size = new System.Drawing.Size(216, 24);
            this.SpecialCheckBox.TabIndex = 4;
            this.SpecialCheckBox.Text = "Спецсимволы (.,?!@#$%&)";
            this.SpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumsCheckBox
            // 
            this.NumsCheckBox.AutoSize = true;
            this.NumsCheckBox.Location = new System.Drawing.Point(6, 93);
            this.NumsCheckBox.Name = "NumsCheckBox";
            this.NumsCheckBox.Size = new System.Drawing.Size(84, 24);
            this.NumsCheckBox.TabIndex = 2;
            this.NumsCheckBox.Text = "Цифры";
            this.NumsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LatinHighCheckBox
            // 
            this.LatinHighCheckBox.AutoSize = true;
            this.LatinHighCheckBox.Location = new System.Drawing.Point(6, 63);
            this.LatinHighCheckBox.Name = "LatinHighCheckBox";
            this.LatinHighCheckBox.Size = new System.Drawing.Size(303, 24);
            this.LatinHighCheckBox.TabIndex = 1;
            this.LatinHighCheckBox.Text = "Латинские буквы верхнего регистра";
            this.LatinHighCheckBox.UseVisualStyleBackColor = true;
            // 
            // LatinLowCheckBox
            // 
            this.LatinLowCheckBox.AutoSize = true;
            this.LatinLowCheckBox.Location = new System.Drawing.Point(6, 33);
            this.LatinLowCheckBox.Name = "LatinLowCheckBox";
            this.LatinLowCheckBox.Size = new System.Drawing.Size(298, 24);
            this.LatinLowCheckBox.TabIndex = 0;
            this.LatinLowCheckBox.Text = "Латинские буквы нижнего регистра";
            this.LatinLowCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinPasswordPhrazeLengthTextBox
            // 
            this.MinPasswordPhrazeLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinPasswordPhrazeLengthTextBox.Location = new System.Drawing.Point(1130, 300);
            this.MinPasswordPhrazeLengthTextBox.Name = "MinPasswordPhrazeLengthTextBox";
            this.MinPasswordPhrazeLengthTextBox.Size = new System.Drawing.Size(52, 26);
            this.MinPasswordPhrazeLengthTextBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(805, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Минимальная длина парольной фразы:";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(871, 438);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 55);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(490, 438);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(154, 55);
            this.ExecuteButton.TabIndex = 37;
            this.ExecuteButton.Text = "Выполнить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CipherButton);
            this.groupBox2.Controls.Add(this.DecipherButton);
            this.groupBox2.Location = new System.Drawing.Point(587, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 47);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // KeyLengthTextBox
            // 
            this.KeyLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLengthTextBox.Location = new System.Drawing.Point(650, 300);
            this.KeyLengthTextBox.Name = "KeyLengthTextBox";
            this.KeyLengthTextBox.Size = new System.Drawing.Size(60, 26);
            this.KeyLengthTextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(439, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Длина ключа (от 8 до 16):";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(636, 392);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(294, 24);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Проверка шифрации/дешифрации";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MessageInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 505);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.KeyLengthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MinPasswordPhrazeLengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "MessageInput";
            this.Text = "Выбор режима";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageInput_FormClosing);
            this.Load += new System.EventHandler(this.MessageInput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox SpecialCheckBox;
        public System.Windows.Forms.CheckBox NumsCheckBox;
        public System.Windows.Forms.CheckBox LatinHighCheckBox;
        public System.Windows.Forms.CheckBox LatinLowCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton DecipherButton;
        public System.Windows.Forms.RadioButton CipherButton;
        public System.Windows.Forms.TextBox MinPasswordPhrazeLengthTextBox;
        public System.Windows.Forms.TextBox KeyLengthTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox MessageTextBox;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}