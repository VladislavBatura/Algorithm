namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linResult = new System.Windows.Forms.RichTextBox();
            this.linZ = new System.Windows.Forms.TextBox();
            this.linY = new System.Windows.Forms.TextBox();
            this.linX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioExp = new System.Windows.Forms.RadioButton();
            this.radioSqrt = new System.Windows.Forms.RadioButton();
            this.radioCos = new System.Windows.Forms.RadioButton();
            this.treeY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linResult);
            this.tabPage1.Controls.Add(this.linZ);
            this.tabPage1.Controls.Add(this.linY);
            this.tabPage1.Controls.Add(this.linX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Линейный алгоритм";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linResult
            // 
            this.linResult.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linResult.Location = new System.Drawing.Point(59, 314);
            this.linResult.Name = "linResult";
            this.linResult.ReadOnly = true;
            this.linResult.Size = new System.Drawing.Size(404, 210);
            this.linResult.TabIndex = 8;
            this.linResult.Text = "Результат";
            // 
            // linZ
            // 
            this.linZ.Location = new System.Drawing.Point(345, 244);
            this.linZ.Name = "linZ";
            this.linZ.Size = new System.Drawing.Size(100, 25);
            this.linZ.TabIndex = 7;
            // 
            // linY
            // 
            this.linY.Location = new System.Drawing.Point(345, 193);
            this.linY.Name = "linY";
            this.linY.Size = new System.Drawing.Size(100, 25);
            this.linY.TabIndex = 6;
            // 
            // linX
            // 
            this.linX.Location = new System.Drawing.Point(345, 139);
            this.linX.Name = "linX";
            this.linX.Size = new System.Drawing.Size(100, 25);
            this.linX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите значение Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите значение Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите значение Х:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeResult);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.treeY);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.treeX);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Разветвляющийся алгоритм";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeResult
            // 
            this.treeResult.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeResult.Location = new System.Drawing.Point(42, 358);
            this.treeResult.Name = "treeResult";
            this.treeResult.ReadOnly = true;
            this.treeResult.Size = new System.Drawing.Size(379, 163);
            this.treeResult.TabIndex = 11;
            this.treeResult.Text = "Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioExp);
            this.groupBox1.Controls.Add(this.radioSqrt);
            this.groupBox1.Controls.Add(this.radioCos);
            this.groupBox1.Location = new System.Drawing.Point(324, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции";
            // 
            // radioExp
            // 
            this.radioExp.AutoSize = true;
            this.radioExp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioExp.Location = new System.Drawing.Point(20, 100);
            this.radioExp.Name = "radioExp";
            this.radioExp.Size = new System.Drawing.Size(90, 32);
            this.radioExp.TabIndex = 2;
            this.radioExp.TabStop = true;
            this.radioExp.Text = "exp(x)";
            this.radioExp.UseVisualStyleBackColor = true;
            // 
            // radioSqrt
            // 
            this.radioSqrt.AutoSize = true;
            this.radioSqrt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioSqrt.Location = new System.Drawing.Point(20, 62);
            this.radioSqrt.Name = "radioSqrt";
            this.radioSqrt.Size = new System.Drawing.Size(93, 32);
            this.radioSqrt.TabIndex = 1;
            this.radioSqrt.TabStop = true;
            this.radioSqrt.Text = "sqrt(x)";
            this.radioSqrt.UseVisualStyleBackColor = true;
            // 
            // radioCos
            // 
            this.radioCos.AutoSize = true;
            this.radioCos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioCos.Location = new System.Drawing.Point(20, 24);
            this.radioCos.Name = "radioCos";
            this.radioCos.Size = new System.Drawing.Size(87, 32);
            this.radioCos.TabIndex = 0;
            this.radioCos.TabStop = true;
            this.radioCos.Text = "cos(x)";
            this.radioCos.UseVisualStyleBackColor = true;
            // 
            // treeY
            // 
            this.treeY.Location = new System.Drawing.Point(94, 247);
            this.treeY.Name = "treeY";
            this.treeY.Size = new System.Drawing.Size(100, 25);
            this.treeY.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y=";
            // 
            // treeX
            // 
            this.treeX.Location = new System.Drawing.Point(94, 205);
            this.treeX.Name = "treeX";
            this.treeX.Size = new System.Drawing.Size(100, 25);
            this.treeX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "X=";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Расчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Алгоритмер";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox linResult;
        private System.Windows.Forms.TextBox linZ;
        private System.Windows.Forms.TextBox linY;
        private System.Windows.Forms.TextBox linX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox treeY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox treeX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioExp;
        private System.Windows.Forms.RadioButton radioSqrt;
        private System.Windows.Forms.RadioButton radioCos;
        private System.Windows.Forms.RichTextBox treeResult;
    }
}

