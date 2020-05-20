using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koło_Fortuny_v1
{
    public partial class Form2 : Form
    {
        public Game CurrentGame { get; set; }
        public Generate generate { get; set; }
        public Form2()
        {
            InitializeComponent();
            CurrentGame = new Game();
            lblWord.Text = CurrentGame.CurrentState;
            lblCategory.Text = CurrentGame.Category;
            textBoxGuess.Enabled = false;
            UpdateCurrentErrors();
            OffButtons();
        }
        public void UpdateCurrentErrors()
        {
            lblErrors.Text = $"Błędy: {CurrentGame.Errors}";
        }
        public void OffButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
        }
        public void OnButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
        }
        public void ShowButtons()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool result=false;
            OffButtons();
            btnRoll.Visible = false;
            btnRoll.Enabled = true;
            char text;
            text = Char.Parse(button.Text);
            result = CurrentGame.Try(text);

            if (result)
            {
                lblWord.Text = CurrentGame.CurrentState;
                CurrentGame.BalanceAccount = CurrentGame.SumBalance(CurrentGame.BalanceAccount, CurrentGame.Prize);
                lblBalance.Text = $"Stan konta: {CurrentGame.BalanceAccount.ToString()}";
                btnRoll.Visible = true;
                OffButtons();
                button.Visible = false;

                if (CurrentGame.LettersLeft() <= 0)
                {
                    MessageBox.Show($"Brawo ! Prawidłowa odpowiedź to: {CurrentGame.Word}\n Wygrałeś {CurrentGame.BalanceAccount.ToString()} zł!");
                    CurrentGame = new Game();
                    lblWord.Text = CurrentGame.CurrentState;
                    lblCategory.Text = CurrentGame.Category;
                    lblBalance.Text = CurrentGame.BalanceAccount.ToString();
                    lblPrice.Text = CurrentGame.Prize.ToString();
                    OffButtons();
                    ShowButtons();
                    btnRoll.Visible = true;
                }
            }
            else
            {
                UpdateCurrentErrors();
                btnRoll.Visible = true;
                button.Visible = false;
                textBoxGuess.Enabled = false;
            }
           
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            OnButtons();
            btnRoll.Enabled = false;
        }

        private void textBoxGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool result = false;
                result = CurrentGame.TryString(textBoxGuess.Text);

                if (result)
                {
                    CurrentGame.BalanceAccount = CurrentGame.SumBalance(CurrentGame.BalanceAccount, CurrentGame.Prize);
                    MessageBox.Show($"Brawo ! Prawidłowa odpowiedź to: {CurrentGame.Word}\n Wygrałeś {CurrentGame.BalanceAccount.ToString()} zł!");
                    CurrentGame = new Game();
                    lblWord.Text = CurrentGame.CurrentState;
                    lblCategory.Text = CurrentGame.Category;
                    lblBalance.Text = CurrentGame.BalanceAccount.ToString();
                    lblPrice.Text = CurrentGame.Prize.ToString();
                    OffButtons();
                    ShowButtons();
                    btnRoll.Visible = true;
                    btnRoll.Enabled = true;
                    textBoxGuess.Text = "Wpisz odpowiedź...";
                    textBoxGuess.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Zła odpowiedź");
                    textBoxGuess.Text = "Wpisz odpowiedź...";
                    textBoxGuess.Enabled = false;
                }
            }
        }

        private void textBoxGuess_Enter(object sender, EventArgs e)
        {
            if(textBoxGuess.Text == "Wpisz odpowiedź...")
            {
                textBoxGuess.Text = "";

                textBoxGuess.ForeColor = Color.Black;
            }
        }

        private void textBoxGuess_Leave(object sender, EventArgs e)
        {
            if (textBoxGuess.Text == "")
            {
                textBoxGuess.Text = "Wpisz odpowiedź...";

                textBoxGuess.ForeColor = Color.Silver;
            }
        }

        int totalTime = 1000;
        int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime += timer1.Interval;
            if (elapsedTime > totalTime)
            {
                timer1.Stop();
                elapsedTime = 0;
                OnButtons();
                //textBoxGuess.Text = "Wpisz odpowiedź...";
                textBoxGuess.Enabled = true;
            }
            else
            {
                lblPrice.Text = $"Grasz o: {CurrentGame.RandomPrize().ToString()}";
                OffButtons();
                //textBoxGuess.Text = "Wpisz odpowiedź...";
            }
            
        }
    }
}
