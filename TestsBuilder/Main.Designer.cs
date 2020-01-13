namespace TestsBuilder
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnAddQuestion = new System.Windows.Forms.Button();
			this.btnCreateTest = new System.Windows.Forms.Button();
			this.subtitleTxt = new System.Windows.Forms.TextBox();
			this.titleTxt = new System.Windows.Forms.TextBox();
			this.subtitleLbl = new System.Windows.Forms.Label();
			this.titleLbl = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.questionLbl = new System.Windows.Forms.Label();
			this.questionTxt = new System.Windows.Forms.TextBox();
			this.btnAddAnswer = new System.Windows.Forms.Button();
			this.btnDeleteAnswer = new System.Windows.Forms.Button();
			this.btnExample = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.btnDeleteQuestion = new System.Windows.Forms.Button();
			this.addQuestionPhoto1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.addQuestionPhoto2 = new System.Windows.Forms.Button();
			this.addQuestionPhoto4 = new System.Windows.Forms.Button();
			this.addQuestionPhoto3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddQuestion
			// 
			this.btnAddQuestion.Location = new System.Drawing.Point(21, 604);
			this.btnAddQuestion.Name = "btnAddQuestion";
			this.btnAddQuestion.Size = new System.Drawing.Size(228, 45);
			this.btnAddQuestion.TabIndex = 32;
			this.btnAddQuestion.Text = "Додати питання";
			this.btnAddQuestion.UseVisualStyleBackColor = true;
			this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
			// 
			// btnCreateTest
			// 
			this.btnCreateTest.AllowDrop = true;
			this.btnCreateTest.Location = new System.Drawing.Point(21, 12);
			this.btnCreateTest.Name = "btnCreateTest";
			this.btnCreateTest.Size = new System.Drawing.Size(241, 38);
			this.btnCreateTest.TabIndex = 31;
			this.btnCreateTest.Text = "Створити файл тесту";
			this.btnCreateTest.UseVisualStyleBackColor = true;
			this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
			// 
			// subtitleTxt
			// 
			this.subtitleTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.subtitleTxt.Location = new System.Drawing.Point(154, 90);
			this.subtitleTxt.Margin = new System.Windows.Forms.Padding(6);
			this.subtitleTxt.Multiline = true;
			this.subtitleTxt.Name = "subtitleTxt";
			this.subtitleTxt.Size = new System.Drawing.Size(746, 74);
			this.subtitleTxt.TabIndex = 28;
			// 
			// titleTxt
			// 
			this.titleTxt.Location = new System.Drawing.Point(154, 58);
			this.titleTxt.Margin = new System.Windows.Forms.Padding(6);
			this.titleTxt.Name = "titleTxt";
			this.titleTxt.Size = new System.Drawing.Size(746, 29);
			this.titleTxt.TabIndex = 27;
			// 
			// subtitleLbl
			// 
			this.subtitleLbl.AutoSize = true;
			this.subtitleLbl.Location = new System.Drawing.Point(17, 93);
			this.subtitleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.subtitleLbl.Name = "subtitleLbl";
			this.subtitleLbl.Size = new System.Drawing.Size(131, 24);
			this.subtitleLbl.TabIndex = 26;
			this.subtitleLbl.Text = "Підзаголовок";
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Location = new System.Drawing.Point(17, 58);
			this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(105, 24);
			this.titleLbl.TabIndex = 25;
			this.titleLbl.Text = "Заголовок";
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 24;
			this.listBox.Location = new System.Drawing.Point(21, 183);
			this.listBox.Margin = new System.Windows.Forms.Padding(6);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(228, 412);
			this.listBox.TabIndex = 24;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			this.listBox.MouseEnter += new System.EventHandler(this.listBox_MouseEnter);
			// 
			// questionLbl
			// 
			this.questionLbl.AutoSize = true;
			this.questionLbl.Location = new System.Drawing.Point(296, 170);
			this.questionLbl.Name = "questionLbl";
			this.questionLbl.Size = new System.Drawing.Size(141, 24);
			this.questionLbl.TabIndex = 34;
			this.questionLbl.Text = "Текст питання";
			// 
			// questionTxt
			// 
			this.questionTxt.Location = new System.Drawing.Point(478, 173);
			this.questionTxt.Multiline = true;
			this.questionTxt.Name = "questionTxt";
			this.questionTxt.Size = new System.Drawing.Size(420, 78);
			this.questionTxt.TabIndex = 35;
			// 
			// btnAddAnswer
			// 
			this.btnAddAnswer.Location = new System.Drawing.Point(323, 733);
			this.btnAddAnswer.Name = "btnAddAnswer";
			this.btnAddAnswer.Size = new System.Drawing.Size(185, 38);
			this.btnAddAnswer.TabIndex = 36;
			this.btnAddAnswer.Text = "Додати відповідь";
			this.btnAddAnswer.UseVisualStyleBackColor = true;
			this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
			// 
			// btnDeleteAnswer
			// 
			this.btnDeleteAnswer.Location = new System.Drawing.Point(514, 733);
			this.btnDeleteAnswer.Name = "btnDeleteAnswer";
			this.btnDeleteAnswer.Size = new System.Drawing.Size(204, 38);
			this.btnDeleteAnswer.TabIndex = 37;
			this.btnDeleteAnswer.Text = "Видалити відповідь";
			this.btnDeleteAnswer.UseVisualStyleBackColor = true;
			this.btnDeleteAnswer.Click += new System.EventHandler(this.btnDeleteAnswer_Click);
			// 
			// btnExample
			// 
			this.btnExample.BackColor = System.Drawing.Color.Coral;
			this.btnExample.Location = new System.Drawing.Point(550, 12);
			this.btnExample.Name = "btnExample";
			this.btnExample.Size = new System.Drawing.Size(348, 37);
			this.btnExample.TabIndex = 40;
			this.btnExample.Text = "Заповнити форму для прикладу";
			this.btnExample.UseVisualStyleBackColor = false;
			this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
			// 
			// btnDeleteQuestion
			// 
			this.btnDeleteQuestion.Location = new System.Drawing.Point(21, 655);
			this.btnDeleteQuestion.Name = "btnDeleteQuestion";
			this.btnDeleteQuestion.Size = new System.Drawing.Size(228, 45);
			this.btnDeleteQuestion.TabIndex = 43;
			this.btnDeleteQuestion.Text = "Видалити питання";
			this.btnDeleteQuestion.UseVisualStyleBackColor = true;
			this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
			// 
			// addQuestionPhoto1
			// 
			this.addQuestionPhoto1.BackColor = System.Drawing.Color.Transparent;
			this.addQuestionPhoto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addQuestionPhoto1.ForeColor = System.Drawing.Color.Black;
			this.addQuestionPhoto1.Location = new System.Drawing.Point(254, 197);
			this.addQuestionPhoto1.Name = "addQuestionPhoto1";
			this.addQuestionPhoto1.Size = new System.Drawing.Size(50, 50);
			this.addQuestionPhoto1.TabIndex = 44;
			this.addQuestionPhoto1.Text = "+";
			this.addQuestionPhoto1.UseVisualStyleBackColor = false;
			this.addQuestionPhoto1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// addQuestionPhoto2
			// 
			this.addQuestionPhoto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addQuestionPhoto2.Location = new System.Drawing.Point(310, 197);
			this.addQuestionPhoto2.Name = "addQuestionPhoto2";
			this.addQuestionPhoto2.Size = new System.Drawing.Size(50, 50);
			this.addQuestionPhoto2.TabIndex = 45;
			this.addQuestionPhoto2.Text = "+";
			this.addQuestionPhoto2.UseVisualStyleBackColor = true;
			this.addQuestionPhoto2.Click += new System.EventHandler(this.addQuestionPhoto2_Click);
			// 
			// addQuestionPhoto4
			// 
			this.addQuestionPhoto4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addQuestionPhoto4.Location = new System.Drawing.Point(422, 197);
			this.addQuestionPhoto4.Name = "addQuestionPhoto4";
			this.addQuestionPhoto4.Size = new System.Drawing.Size(50, 50);
			this.addQuestionPhoto4.TabIndex = 46;
			this.addQuestionPhoto4.Text = "+";
			this.addQuestionPhoto4.UseVisualStyleBackColor = true;
			this.addQuestionPhoto4.Click += new System.EventHandler(this.addQuestionPhoto4_Click);
			// 
			// addQuestionPhoto3
			// 
			this.addQuestionPhoto3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addQuestionPhoto3.Location = new System.Drawing.Point(366, 197);
			this.addQuestionPhoto3.Name = "addQuestionPhoto3";
			this.addQuestionPhoto3.Size = new System.Drawing.Size(50, 50);
			this.addQuestionPhoto3.TabIndex = 47;
			this.addQuestionPhoto3.Text = "+";
			this.addQuestionPhoto3.UseVisualStyleBackColor = true;
			this.addQuestionPhoto3.Click += new System.EventHandler(this.addQuestionPhoto3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(72, 120);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(50, 50);
			this.pictureBox2.TabIndex = 49;
			this.pictureBox2.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(915, 783);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.addQuestionPhoto3);
			this.Controls.Add(this.addQuestionPhoto4);
			this.Controls.Add(this.addQuestionPhoto2);
			this.Controls.Add(this.addQuestionPhoto1);
			this.Controls.Add(this.btnDeleteQuestion);
			this.Controls.Add(this.btnExample);
			this.Controls.Add(this.btnDeleteAnswer);
			this.Controls.Add(this.btnAddAnswer);
			this.Controls.Add(this.questionTxt);
			this.Controls.Add(this.questionLbl);
			this.Controls.Add(this.btnAddQuestion);
			this.Controls.Add(this.btnCreateTest);
			this.Controls.Add(this.subtitleTxt);
			this.Controls.Add(this.titleTxt);
			this.Controls.Add(this.subtitleLbl);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.listBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tests builder";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.Main_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.TextBox subtitleTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label subtitleLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.Button btnAddAnswer;
		private System.Windows.Forms.Button btnDeleteAnswer;
		private System.Windows.Forms.Button btnExample;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnDeleteQuestion;
		private System.Windows.Forms.Button addQuestionPhoto1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button addQuestionPhoto2;
		private System.Windows.Forms.Button addQuestionPhoto4;
		private System.Windows.Forms.Button addQuestionPhoto3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;

    }
}

