using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestsBuilder
{
    public partial class Main : Form
    {

        List<Label> answLabels = new List<Label>();
        List<TextBox> answTextBoxes = new List<TextBox>();
		List<RadioButton> rightAnswerChooseRB = new List<RadioButton>();
		List<PictureBox> questionPicBoxes = new List<PictureBox>();
		List<PictureBox> picBTest = new List<PictureBox>();
		Panel panel;
		Label fix;

		int isDeleting = 0;
        int questionIndex = -100;


        List<Question> questions = new List<Question>();
       



        public Main()
        {
            
            InitializeComponent();
            load();
            

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}









		class Question
		{
			public string questionText;
			public string[] questionBase64Photo = {"","","",""};
			public List<string> answers = new List<string>();
			public string correctAnswer = "1";
			public static int count = 0;

			//конструктор
			public Question()
			{
				count++;
				answers.Add("");
				answers.Add("");
			}
		}



















        //методы


        public void load()
        {
            int dY = 25;
            int TxtBoxHeight = 80;
            int height = dY;
            int TxtBoxWidth = 425;
            bool isVisible = false;
            
            //load
            

            panel = new Panel()
            {
                Location = new Point(290, 266),
                BorderStyle = BorderStyle.FixedSingle,
                Width = 608,
                Height = 459,
                AutoScroll = true
            };
			int picBoxSize = 50;
			int picBoxY = 197;
			int firstPicBoxY = 254;
			for (int i = 0; i < 4; i++)
			{
				questionPicBoxes.Add(new PictureBox()
				{
					Location = new Point(firstPicBoxY + (i * (picBoxSize + 6)),picBoxY),
					Height = picBoxSize,
					Width = picBoxSize,
					BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
				});

				this.Controls.Add(questionPicBoxes[i]);
			}
			for (int i = 0; i < 2; i++)
			{
				picBTest.Add(new PictureBox()
				{
					Location = new Point(12 + (i * (50 + 6)), 120),
					Height = picBoxSize,
					Width = picBoxSize
				});
				
			}
			for (int i = 0; i < 99; i++)
			{
				answTextBoxes.Add(new TextBox()
				{
					Location = new Point(145, height),
					Height = TxtBoxHeight,
					Width = TxtBoxWidth,
					Multiline = true,
					Visible = isVisible,
				});

				answLabels.Add(new Label()
				{
					Location = new Point(0, height),
					Text = "Відповідь №" + (i + 1).ToString(),
					Visible = isVisible,
					Width = 145
				});
				rightAnswerChooseRB.Add(new RadioButton()
				{
					Location = new Point(575, height),
					Text = "",
					Visible = isVisible,
					Width = 13
				});
				panel.Controls.Add(answLabels[i]);
				panel.Controls.Add(answTextBoxes[i]);
				panel.Controls.Add(rightAnswerChooseRB[i]);
				height += TxtBoxHeight + dY;
			}
            panel.Controls.Add(fix);
            this.Controls.Add(panel);
			questions.Add(new Question());
			listBox.Items.Add("Питання №1");
			listBox.SetSelected(0, true);
            //load end
        }




        public void SaveQuestionInformation()
        {
			if (listBox.Items.Count > 0)
			{
				questions[questionIndex].questionText = questionTxt.Text.Replace('"'.ToString(),('\\'.ToString()+'"'.ToString())).Replace("'",('\\'.ToString()+'"'.ToString()));
				for (int i = 0; i < questions[questionIndex].answers.Count; i++)
				{
					questions[questionIndex].answers[i] = answTextBoxes[i].Text.Replace('"'.ToString(), ('\\'.ToString() + '"'.ToString())).Replace("'", ('\\'.ToString() + '"'.ToString()));
				}
				for (int i = 0; i < rightAnswerChooseRB.Count; i++)
				{
					if (rightAnswerChooseRB[i].Checked)
						questions[questionIndex].correctAnswer = (i + 1).ToString();
				}
			}
			
        }


		public void ShowQuestion()
		{
			panel.AutoScrollPosition = new Point(0, 0);
			questionTxt.Text = questions[questionIndex].questionText;
			for (int i = 0; i < questions[questionIndex].answers.Count; i++)
	        {
				answLabels[i].Visible = true;
				answTextBoxes[i].Text = questions[questionIndex].answers[i];
				answTextBoxes[i].Visible = true;
				if ((int.Parse(questions[questionIndex].correctAnswer) - 1) == i)
					rightAnswerChooseRB[i].Checked = true;
				rightAnswerChooseRB[i].Visible = true;
			}
			for (int i = questions[questionIndex].answers.Count; i < answTextBoxes.Count; i++)
			{
				answLabels[i].Visible = false;
				answTextBoxes[i].Visible = false;
				rightAnswerChooseRB[i].Visible = false;
			}
		}

		public void listBox_SelectedIndexChanged1()
		{
			foreach (TextBox txt in answTextBoxes)
			{
				txt.Text = "";
			}
			if (isDeleting == 0)
			{
				questionIndex = listBox.SelectedIndex;
				ShowQuestion();
			}
			
		}
		private void btnAddQuestion_Click1 ()
		{
			questions.Add(new Question());
			listBox.Items.Add("Питання №" + Question.count);
			listBox.SetSelected(Question.count - 1, true);
			if (listBox.Items.Count > 0)
			{
				btnDeleteQuestion.Enabled = true;
				btnDeleteAnswer.Enabled = true;
				btnAddAnswer.Enabled = true;
				panel.Visible = true;
				questionLbl.Visible = true;
				questionTxt.Visible = true;
				btnCreateTest.Enabled = true;
			}

		}

		private void btnDeleteQuestion_Click1()
		{
			isDeleting = 1;
			if (listBox.Items.Count != 0) { 
			questions.RemoveAt(questionIndex);
			Question.count -= 1;
			listBox.Items.RemoveAt(questionIndex);
			if (listBox.Items.Count == 0)
			{

			}
			else if (questionIndex == (listBox.Items.Count - 1)||questionIndex == 0)
			{
				//questionIndex -= 1;
				listBox.SetSelected(questionIndex, true);
				ShowQuestion();
			}
			else
			{
				questionIndex -= 1;
				listBox.SetSelected(questionIndex, true);
				ShowQuestion();
			}
			}
			isDeleting = 0;
			if (listBox.Items.Count == 0)
			{
				btnDeleteQuestion.Enabled = false;
				btnDeleteAnswer.Enabled = false;
				btnAddAnswer.Enabled = false;
				panel.Visible = false;
				questionLbl.Visible = false;
				questionTxt.Visible = false;
				btnCreateTest.Enabled = false;
			}
		}

		private void btnAddAnswer_Click1 ()
		{
			Point pos = new Point();
			pos = panel.AutoScrollPosition;
			pos.Y = Math.Abs(pos.Y);
			panel.AutoScrollPosition = new Point(0, 0);
			questions[questionIndex].answers.Add("");

			if (questions[questionIndex].answers.Count < 99)
				answLabels[questions[questionIndex].answers.Count - 1].Visible = true;
			else
				btnAddAnswer.Enabled = false;

			answLabels[questions[questionIndex].answers.Count - 1].Visible = true;
			answTextBoxes[questions[questionIndex].answers.Count - 1].Visible = true;
			fix = new Label()
			{
				Location = new Point(15, (105 * (questions[questionIndex].answers.Count))),
				Text = " ",
				Visible = true
			};
			panel.Controls.Add(fix);
			rightAnswerChooseRB[questions[questionIndex].answers.Count-1].Visible = true;
			if (questions[questionIndex].answers.Count > 0)
				btnDeleteAnswer.Enabled = true;
			panel.AutoScrollPosition = pos;
		}
		private void btnDeleteAnswer_Click1()
		{
			questions[questionIndex].answers.RemoveAt(questions[questionIndex].answers.Count - 1);
			answLabels[questions[questionIndex].answers.Count].Visible = false;
			answTextBoxes[questions[questionIndex].answers.Count].Visible = false;
			rightAnswerChooseRB[questions[questionIndex].answers.Count].Visible = false;
			if (questions[questionIndex].answers.Count == 0)
				btnDeleteAnswer.Enabled = false;
			if(questions[questionIndex].answers.Count < 100)
				btnAddAnswer.Enabled = true;
		}


		public void simulateAddingNewQuestion()
		{
			SaveQuestionInformation();

			btnAddQuestion_Click1();
		}

		int picBox1IsOpen = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			if (picBox1IsOpen == 0)
			{

				string file_in = "image.jpg";  // назва файлу за замовчанням, такий файл вже існує в папці
				openFileDialog1.Filter = "jpg |*.jpg|Все файлы|*.*|png|*.png"; // створення фільтру
				openFileDialog1.FileName = file_in;   //  заповнення вікна вибору файла
				openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   //  першою буде відкрита папка з  *.ехе файлом
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					file_in = openFileDialog1.FileName;
					//photoExt = Path.GetFileName(file_in).Split('.')[1];
					addQuestionPhoto1.Text = "X";
					addQuestionPhoto1.ForeColor = Color.Red;
					addQuestionPhoto1.Height = 10;
					addQuestionPhoto1.Width = 10;
					addQuestionPhoto1.Location = new Point(294, 197);
					addQuestionPhoto1.BackColor = Color.Red;
					questionPicBoxes[0].BackgroundImage = Image.FromFile(file_in);
					questionPicBoxes[0].Height = 50;
					questionPicBoxes[0].Width = 50;
					questions[questionIndex].questionBase64Photo[0] = Convert.ToBase64String(File.ReadAllBytes(file_in));
					picBox1IsOpen = 1;
				}

			}
			else
			{
				addQuestionPhoto1.Height = 50;
				addQuestionPhoto1.Width = 50;
				addQuestionPhoto1.Location = new Point(254, 197);
				addQuestionPhoto1.BackColor = Color.Transparent;
				questionPicBoxes[0].Height = 0;
				addQuestionPhoto1.ForeColor = Color.Black;
				questions[questionIndex].questionBase64Photo[0] = "";
				addQuestionPhoto1.Text = "+";
				picBox1IsOpen = 0;
			}
		}












		int picBox2IsOpen = 0;
		private void addQuestionPhoto2_Click(object sender, EventArgs e)
		{
			if (picBox2IsOpen == 0)
			{

				string file_in = "viber image.jpg";  // назва файлу за замовчанням, такий файл вже існує в папці
				openFileDialog1.Filter = "jpg |*.jpg|Все файлы|*.*|png|*.png"; // створення фільтру
				openFileDialog1.FileName = file_in;   //  заповнення вікна вибору файла
				openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   //  першою буде відкрита папка з  *.ехе файлом
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					file_in = openFileDialog1.FileName;
					//photoExt = Path.GetFileName(file_in).Split('.')[1];
					addQuestionPhoto2.Text = "X";
					addQuestionPhoto2.ForeColor = Color.Red;
					addQuestionPhoto2.Height = 10;
					addQuestionPhoto2.Width = 10;
					addQuestionPhoto2.Location = new Point(350, 197);
					addQuestionPhoto2.BackColor = Color.Red;
					questionPicBoxes[1].BackgroundImage = Image.FromFile(file_in);
					questionPicBoxes[1].Height = 50;
					questionPicBoxes[1].Width = 50;
					questions[questionIndex].questionBase64Photo[1] = Convert.ToBase64String(File.ReadAllBytes(file_in));
					picBox2IsOpen = 1;
				}

			}
			else
			{
				addQuestionPhoto2.Height = 50;
				addQuestionPhoto2.Width = 50;
				addQuestionPhoto2.Location = new Point(310, 197);
				addQuestionPhoto2.BackColor = Color.Transparent;
				questionPicBoxes[1].Height = 0;
				addQuestionPhoto2.ForeColor = Color.Black;
				questions[questionIndex].questionBase64Photo[1] = "";
				addQuestionPhoto2.Text = "+";
				picBox2IsOpen = 0;
			}
		}
















		int picBox3IsOpen = 0;
		private void addQuestionPhoto3_Click(object sender, EventArgs e)
		{
			if (picBox3IsOpen == 0)
			{

				string file_in = "viber image.jpg";  // назва файлу за замовчанням, такий файл вже існує в папці
				openFileDialog1.Filter = "jpg |*.jpg|Все файлы|*.*|png|*.png"; // створення фільтру
				openFileDialog1.FileName = file_in;   //  заповнення вікна вибору файла
				openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   //  першою буде відкрита папка з  *.ехе файлом
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					file_in = openFileDialog1.FileName;
					//photoExt = Path.GetFileName(file_in).Split('.')[1];
					addQuestionPhoto3.Text = "X";
					addQuestionPhoto3.ForeColor = Color.Red;
					addQuestionPhoto3.Height = 10;
					addQuestionPhoto3.Width = 10;
					addQuestionPhoto3.Location = new Point(406, 197);
					addQuestionPhoto3.BackColor = Color.Red;
					questionPicBoxes[2].BackgroundImage = Image.FromFile(file_in);
					questionPicBoxes[2].Height = 50;
					questionPicBoxes[2].Width = 50;
					questions[questionIndex].questionBase64Photo[2] = Convert.ToBase64String(File.ReadAllBytes(file_in));
					picBox3IsOpen = 1;
				}

			}
			else
			{
				addQuestionPhoto3.Height = 50;
				addQuestionPhoto3.Width = 50;
				addQuestionPhoto3.Location = new Point(366, 197);
				addQuestionPhoto3.BackColor = Color.Transparent;
				questionPicBoxes[2].Height = 0;
				addQuestionPhoto3.ForeColor = Color.Black;
				questions[questionIndex].questionBase64Photo[2] = "";
				addQuestionPhoto3.Text = "+";
				picBox3IsOpen = 0;
			}
		}











		int picBox4IsOpen = 0;
		private void addQuestionPhoto4_Click(object sender, EventArgs e)
		{
			if (picBox4IsOpen == 0)
			{

				string file_in = "viber image.jpg";  // назва файлу за замовчанням, такий файл вже існує в папці
				openFileDialog1.Filter = "jpg |*.jpg|Все файлы|*.*|png|*.png"; // створення фільтру
				openFileDialog1.FileName = file_in;   //  заповнення вікна вибору файла
				openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   //  першою буде відкрита папка з  *.ехе файлом
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					file_in = openFileDialog1.FileName;
					//photoExt = Path.GetFileName(file_in).Split('.')[1];
					addQuestionPhoto4.Text = "X";
					addQuestionPhoto4.ForeColor = Color.Red;
					addQuestionPhoto4.Height = 10;
					addQuestionPhoto4.Width = 10;
					addQuestionPhoto4.Location = new Point(462, 197);
					addQuestionPhoto4.BackColor = Color.Red;
					questionPicBoxes[3].BackgroundImage = Image.FromFile(file_in);
					questionPicBoxes[3].Height = 50;
					questionPicBoxes[3].Width = 50;
					questions[questionIndex].questionBase64Photo[2] = Convert.ToBase64String(File.ReadAllBytes(file_in));
					picBox4IsOpen = 1;
				}

			}
			else
			{
				addQuestionPhoto4.Height = 50;
				addQuestionPhoto4.Width = 50;
				addQuestionPhoto4.Location = new Point(422, 197);
				addQuestionPhoto4.BackColor = Color.Transparent;
				questionPicBoxes[3].Height = 0;
				addQuestionPhoto4.ForeColor = Color.Black;
				questions[questionIndex].questionBase64Photo[2] = "";
				addQuestionPhoto4.Text = "+";
				picBox4IsOpen = 0;
			}
		}

        // методы end







        


      




        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			listBox_SelectedIndexChanged1();
        }



        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
			btnAddQuestion_Click1();
        }

		private void btnDeleteQuestion_Click(object sender, EventArgs e)
		{
			btnDeleteQuestion_Click1();
		}






		private void btnAddAnswer_Click(object sender, EventArgs e)
		{
			btnAddAnswer_Click1();
		}

		private void btnDeleteAnswer_Click(object sender, EventArgs e)
		{
			btnDeleteAnswer_Click1();
		}





		private void listBox_MouseEnter(object sender, EventArgs e)
		{
			SaveQuestionInformation();
		}


		private void btnExample_Click(object sender, EventArgs e)
		{

			titleTxt.Text = "Заголовок";
			subtitleTxt.Text = "Підзаголовок";

			if (listBox.Items.Count == 0)
			{
				btnAddQuestion_Click1();
			}
			questionTxt.Text = "Питання";

			answTextBoxes[0].Text = "Невірна відповідь";
			answTextBoxes[1].Text = "Вірна відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[2].Text = "Невірна відповідь";
			rightAnswerChooseRB[1].Checked = true;

			simulateAddingNewQuestion();

			questionTxt.Text = "Чому дорівнює 5+3?";
			answTextBoxes[0].Text = "6";
			answTextBoxes[1].Text = "7";
			btnAddAnswer_Click1();
			answTextBoxes[2].Text = "8";
			btnAddAnswer_Click1();
			answTextBoxes[3].Text = "9";
			rightAnswerChooseRB[2].Checked = true;

			simulateAddingNewQuestion();

			questionTxt.Text = "Питання";
			answTextBoxes[0].Text = "Перша відповідь";
			answTextBoxes[1].Text = "Друга відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[2].Text = "Третя відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[3].Text = "Четверта відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[4].Text = "Пята відповідь(вірна)";
			btnAddAnswer_Click1();
			answTextBoxes[5].Text = "Шоста відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[6].Text = "Сьома відповідь";
			btnAddAnswer_Click1();
			answTextBoxes[7].Text = "Восьма відповідь";
			rightAnswerChooseRB[4].Checked = true;

			addQuestionPhoto1.Text = "X";
			addQuestionPhoto1.ForeColor = Color.Red;
			addQuestionPhoto1.Height = 10;
			addQuestionPhoto1.Width = 10;
			addQuestionPhoto1.Location = new Point(294, 197);
			addQuestionPhoto1.BackColor = Color.Red;
			questionPicBoxes[0].BackgroundImage = Image.FromFile("./img.jpg");
			questionPicBoxes[0].Height = 50;
			questionPicBoxes[0].Width = 50;
			questions[questionIndex].questionBase64Photo[0] = Convert.ToBase64String(File.ReadAllBytes("./img.jpg"));
			picBox1IsOpen = 1;

		}























		//!!! Создание теста !!!//




		private void btnCreateTest_Click(object sender, EventArgs e)
		{
			SaveQuestionInformation();
			string title = titleTxt.Text.Replace('"'.ToString(), ('\\'.ToString() + '"'.ToString())).Replace("'", ('\\'.ToString() + '"'.ToString()));
			string subtitle = subtitleTxt.Text.Replace('"'.ToString(), ('\\'.ToString() + '"'.ToString())).Replace("'", ('\\'.ToString() + '"'.ToString()));

			//Начало построения файла

			string file_out = "test.html";  
			saveFileDialog1.FileName = file_out;
			saveFileDialog1.Filter = "все файлы |*.*|html|*.html";
			saveFileDialog1.DefaultExt = "html";   
			saveFileDialog1.AddExtension = true;

			saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				file_out = saveFileDialog1.FileName;   
			StreamWriter sw = File.CreateText(file_out);

			sw.WriteLine("<!DOCTYPE html>");
			sw.WriteLine("            <html lang=\"en\">");
			sw.WriteLine("            <head>");					   
			sw.WriteLine("            	<meta charset=\"UTF-8\">");
			sw.WriteLine("            	<title>Test</title>");
			sw.WriteLine("            </head>");
			sw.WriteLine("            <body>");
			sw.WriteLine("            <style>.content{background-color: white; max-width: 640px;margin:auto;margin-top:50px;margin-bottom:50px;padding: 30px;font-family: 'Roboto', sans-serif;-webkit-box-shadow: 0px 0px 14px 2px rgba(0,0,0,0.52);-moz-box-shadow: 0px 0px 14px 2px rgba(0,0,0,0.52);box-shadow: 0px 0px 14px 2px rgba(0,0,0,0.52);}body{background-color: #EDE7F6FF;}</style>");
			sw.WriteLine("            	<script>");
			sw.WriteLine("            		var title =" + '"' + title + '"' + ";");
			sw.WriteLine("            ");
			sw.WriteLine("            		var subtitle = " + '"' + subtitle + '"' + ";");
			sw.WriteLine("            ");
			sw.WriteLine("            		var questions=[");

			for (int i = 0; i < questions.Count; i++)
			{
				sw.WriteLine("            		{");
				sw.WriteLine("            			text:" + '"' + questions[i].questionText + '"' + ",");
				sw.WriteLine("photoBase64:[");
				for (int k = 0; k < questions[i].questionBase64Photo.Length; k++)
				{
					if (questions[i].questionBase64Photo[k] != "")
					{
						listBox.Items.Add(questions[i].questionBase64Photo[k]);
						string photoString = '"' + questions[i].questionBase64Photo[k] + '"';
						if (k != 0)
							photoString = ',' + photoString;
						sw.WriteLine(photoString);
					}
				}
				sw.WriteLine("],");
				string answersString = "            			answers:[";
				for (int j = 0; j < questions[i].answers.Count; j++)
				{
					answersString += '"' + questions[i].answers[j] + '"';
					if (j != (questions[i].answers.Count - 1))
					{
						answersString += ",";
					}
				}
				answersString += "],";
				sw.WriteLine(answersString);
				sw.WriteLine("            			correctAnswer:" + (int.Parse(questions[i].correctAnswer)-1).ToString());
				if (i != (questions.Count - 1))
				{
					sw.WriteLine("            		},");
				}
				else
				{
					sw.WriteLine("            		}");
				}
			}
			sw.WriteLine("            		];");
			sw.WriteLine("            ");
			sw.WriteLine("            		var yourAns = new Array;");
			sw.WriteLine("            		var score = 0;");
			sw.WriteLine("            ");
			sw.WriteLine("            		function Engine(question, answer){");
			sw.WriteLine("            			yourAns[question]=answer;");
			sw.WriteLine("            		}");
			sw.WriteLine("            ");
			sw.WriteLine("            		function Score(){");
			sw.WriteLine("            			var answerText = \"Результаты:\\n\";");
			sw.WriteLine("            			for(var i = 0; i < yourAns.length; ++i){");
			sw.WriteLine("            				var num = i+1;");
			sw.WriteLine("            				answerText=answerText+\"\\n    Вопрос №\"+ num +\"\";");
			sw.WriteLine("            				if(yourAns[i]!=questions[i].correctAnswer){");
			sw.WriteLine("            					answerText=answerText+\"\\n    Правильный ответ: \" +");
			sw.WriteLine("            					questions[i].answers[questions[i].correctAnswer] + \"\\n\";");
			sw.WriteLine("            				}");
			sw.WriteLine("            				else{");
			sw.WriteLine("            					answerText=answerText+\": Верно! \\n\";");
			sw.WriteLine("            					++score;");
			sw.WriteLine("            				}");
			sw.WriteLine("            			}");
			sw.WriteLine("            ");
			sw.WriteLine("            			answerText=answerText+\"\\nВсего правильных ответов: \"+score+\"\\n\";");
			sw.WriteLine("            			alert(answerText);");
			sw.WriteLine("            			yourAns = [];");
			sw.WriteLine("            			score = 0;");
			sw.WriteLine("            			clearForm(\"quiz" + '"' + ");");
			sw.WriteLine("            		}");
			sw.WriteLine("            		function clearForm(name) {");
			sw.WriteLine("            			var f = document.forms[name];");
			sw.WriteLine("            			for(var i = 0; i < f.elements.length; ++i) {");
			sw.WriteLine("            				if(f.elements[i].checked)");
			sw.WriteLine("            					f.elements[i].checked = false;");
			sw.WriteLine("            			}");
			sw.WriteLine("            		}");
			sw.WriteLine("            	</script>");
			sw.WriteLine("            ");
			sw.WriteLine("            	<style>");
			sw.WriteLine("            	span.quest {");
			sw.WriteLine("            		font-weight: bold;");
			sw.WriteLine("            	}");
			sw.WriteLine("            </style>");
			sw.WriteLine("            ");
			sw.WriteLine("<div class=\"content\">");
			sw.WriteLine("            <h1 style=\"font-weight: 900;\"><script>document.write(title)</script></h1>");
			sw.WriteLine("            <h2 style=\"font-size: 15px;font-weight: 100;\"><script>document.write(subtitle)</script></h2>");
			sw.WriteLine("            ");
			sw.WriteLine("<form name=\"quiz\">");
			sw.WriteLine("      <ol style=\"line-height:1.7\">");
			sw.WriteLine("            <script>");
			sw.WriteLine("                  for(var q=0; q<questions.length; ++q) {");
			sw.WriteLine("                        var question = questions[q];");
			sw.WriteLine("                        var idx = 1 + q;");
			sw.WriteLine("");
			sw.WriteLine("                        document.writeln('<li><span class=\"quest\">' + question.text + '</span><br/>');");
			sw.WriteLine("						question.photoBase64.map(photo => {photo?document.writeln(`<img src='data:image/png;base64, ${photo} ' alt='image' /> <br>`):document.writeln('')});");
			sw.WriteLine("                        for(var i in question.answers) {");
			sw.WriteLine("                              document.writeln('<input type=radio name=\"q' + idx + '\" value=\"' + i +");
			sw.WriteLine("                                    '\" onClick=\"Engine(' + q + ', this.value)\">' + question.answers[i] + '<br/>');");
			sw.WriteLine("                        }");
			sw.WriteLine("                  }");
			sw.WriteLine("            </script>");
			sw.WriteLine("      </ol>");
			sw.WriteLine("      <input type=\"button\" onClick=\"Score()\" value=\"Проверить результаты\" />");
			sw.WriteLine("");
			sw.WriteLine("</form>");
			sw.WriteLine("</div>");
			sw.WriteLine("            </body>");
			sw.WriteLine("            </html>");
			sw.Close();



		}

		private void Main_Click(object sender, EventArgs e)
		{

		}























		


		


		


		

		


    }
}
