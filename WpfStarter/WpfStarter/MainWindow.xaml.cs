using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> questionNumbers = Enumerable.Range(1, 10).ToList();
        int questionNumber, score, i;

        public MainWindow()
        {
            InitializeComponent();

            StartQuiz();
            NextQuestion();

            //Button button = new Button();
            //button.Width = 100;
            //button.Height = 30;
            //button.Content = "Custom Btn";
            //button.Background = new SolidColorBrush(Colors.Red);

            //myGrid.Children.Add(button);
        }

        private void NextQuestion()
        {
            if (questionNumber<questionNumbers.Count)
            {
                i = questionNumbers[questionNumber];
            }
            else
            {
                RestartGame();
            }

            foreach (var item in myCanvas.Children.OfType<Button>())
            {
                item.Tag = "0";
            }
            switch (i)
            {
                case 1:
                    QuestionText.Text = "Самое глубокое озеро в мире?";
                    btnAnswer1.Content = "Бaйкал";
                    btnAnswer2.Content = "Гидигич";
                    btnAnswer3.Content = "Онежское";
                    btnAnswer4.Content = "Никарагуа";

                    btnAnswer1.Tag = "1";
                    break;
                case 2:
                    QuestionText.Text = "В каком году Гагарин полетел а космос?";
                    btnAnswer1.Content = "2020";
                    btnAnswer2.Content = "1961";
                    btnAnswer3.Content = "1963";
                    btnAnswer4.Content = "1988";

                    btnAnswer1.Tag = "2";
                    break;

                default:
                    break;
            }
        }

        private void RestartGame()
        {
            score = 0;
            questionNumber = -1;
            i = 0;
            StartQuiz();
        }

        private void StartQuiz()
        {
            var randomList = questionNumbers.OrderBy(x => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
            QuestionOrder.Content = null;
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                QuestionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }

        private void CheckAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString()=="1")
            {
                score++;
            }
            if (questionNumber < 0)
            {
                questionNumber = 0;
            }
            else {

                questionNumber++;
            }
            PointsText.Content = "Answerly correctly" + score + "/" + questionNumbers.Count;
            NextQuestion();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show("Welcome to Wpf lesson One !!!");
        //    /*string tbContent = textBox1.Text;
        //    if (tbContent != "")
        //    {
        //        MessageBox.Show(tbContent);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Input is empty");
        //    }*/

        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    string username = tbUserName.Text;
        //    string password=tbPassword.Text;
        //    if (string.IsNullOrEmpty(username))
        //    {
        //        MessageBox.Show("Username cannot be empty");
        //        tbUserName.Focus();
        //    }
        //    if (string.IsNullOrEmpty(password))
        //    {
        //        MessageBox.Show("Password cannot be empty");
        //        tbPassword.Focus();
        //    }
        //    else
        //    {
        //        MessageBox.Show("");
        //    }
        //}


    }
}
