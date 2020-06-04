using System;
using System.Drawing;
using System.Windows.Forms;

namespace Koło_Fortuny_v1
{
    public partial class Form2 : Form
    {
        public Game CurrentGame { get; set; }
        public Form2()
        {
            InitializeComponent();
            CurrentGame = new Game();
            ResetLabels();
            textBoxGuess.Enabled = false;
            UpdateCurrentErrors();
            OffButtons();
        }

        public void ResetLabels()
        {
            lblErrors.Text = CurrentGame.Errors.ToString();
            lblWord.Text = CurrentGame.CurrentState;
            lblCategory.Text = $"Kategoria: {CurrentGame.Category}";
            lblBalance.Text = $"Stan konta: {CurrentGame.BalanceAccount}";
            lblPrice.Text = CurrentGame.Prize.ToString();
            lblNotification.Text = "";
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
        public void OffConsonant()
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button36.Enabled = false;
        }
        public void OnVowel()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button7.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button23.Enabled = true;
            button22.Enabled = true;
            button27.Enabled = true;
            button35.Enabled = true;
        }
        public void OffVowel()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button7.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button23.Enabled = false;
            button22.Enabled = false;
            button27.Enabled = false;
            button35.Enabled = false;
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
            if (button.Text.Equals("A") || button.Text.Equals("Ą") || button.Text.Equals("E") || button.Text.Equals("Ę") ||
               button.Text.Equals("I") || button.Text.Equals("O") || button.Text.Equals("Ó") || button.Text.Equals("Y") || button.Text.Equals("U"))
            {
                CurrentGame.BalanceAccount = CurrentGame.BalanceAccount-300;
                lblBalance.Text = CurrentGame.BalanceAccount.ToString();
            }

            bool result = false;
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
                lblPrice.Text = "Zakręć jeszcze raz";
                btnRoll.Visible = true;
                OffButtons();
                button.Visible = false;
                lblNotification.Text = "Dobry traf";
 
                if (CurrentGame.LettersAndSpacesLeft() <= 0)
                {
                    MessageBox.Show($"Brawo ! Prawidłowa odpowiedź to: {CurrentGame.Word}\n Wygrałeś {CurrentGame.BalanceAccount.ToString()} zł!");
                    CurrentGame = new Game();
                    ResetLabels();
                    UpdateCurrentErrors();
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
                lblNotification.Text = "Brak litery w haśle";
            }
           
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            btnRoll.Enabled = false;
            lblNotification.Text = "";
            OnButtons();
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
                    UpdateCurrentErrors();
                    ResetLabels(); 
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
                if (CurrentGame.BalanceAccount >= 300)
                {
                    
                    lblNotification.Text = "Możesz kupić samogłoskę";
                }
                else
                {
                    OffVowel();
                }
                textBoxGuess.Enabled = true;
            }
            else
            {
                lblPrice.Text = $"Grasz o: {CurrentGame.RandomPrize().ToString()}";
                //OffButtons();
            }
            
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var decision = MessageBox.Show("Czy napewno chcesz rozpocząć nową grę ?","Nowa gra", MessageBoxButtons.YesNoCancel);
            if(decision ==DialogResult.Yes)
            {
                CurrentGame = new Game();
                ResetLabels();
                btnRoll.Enabled = true;
            }
        }
    }
}
