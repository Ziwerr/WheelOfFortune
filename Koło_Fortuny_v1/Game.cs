using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koło_Fortuny_v1
{
    public class Game
    {
        public string Word { get; set; } = Generate.GenerateWord().ToUpper();
        public List<char> Tried { get; set; } = new List<char>();
        public int Errors { get; set; }
        public string CurrentState { get; set; }
        public string Category { get; set; } 
        public int BalanceAccount { get; set; }
        public int Prize { get; set; }
        public List<int> Prizes { get; set; } = new List<int> { 50, 100, 200, 400, 500, 800, 1000, 1500, 2000, 2500, 3000, 5000 };
        public Game()
        {
            Category = Generate.GenerateCategory(Word.ToString());       
            UpdateCurrentState();
            Prize = 0;
            Errors = 0;
            BalanceAccount = 0;
        }
        public int RandomPrize()
        {
            var prize = Prizes.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            Prize = Convert.ToInt32(prize);
            return Prize;
        }

        public int SumBalance(int price, int balance)
        {
            int p = Convert.ToInt32(price);
            int b = Convert.ToInt32(balance);
            int sum = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                sum = p + b;
            }
            return sum;
        }
        public bool Try(char letter)
        {
            letter = Char.ToUpper(letter);
            Tried.Add(letter);
            if (Word.Contains(letter))
            {
                UpdateCurrentState();
                return true;
            }
            else
            {
                ++Errors;
                return false;
            }
        }
        public bool TryString(string wordguess)
        {
            bool comprasion = string.Equals(wordguess, Word, StringComparison.OrdinalIgnoreCase);
            if (comprasion)
            {
                return true;
            }
            else
            {
                ++Errors;
                return false;
            }
        }
        public void UpdateCurrentState()
        {
            var currentState = new StringBuilder();

            for (var i = 0; i <= Word.Length - 1; i++)
            {
                if (Tried.Contains(Word[i]))
                {
                    currentState.Append($" {Word[i]} ");
                }
                else
                {
                    currentState.Append(" _ ");
                }
            }
            CurrentState = currentState.ToString();
        }

        public int LettersAndSpacesLeft()
        {
            int left = 0;
            int spaces = Word.Count(Char.IsWhiteSpace);

            for (int i = 0; i < Word.Length; ++i)
            {
                if (!Tried.Contains(Word[i]))
                {
                    left++;
                } 
            }
            return left-spaces;
        }
        public int SpacesLeft()
        {
            int spaces = 0;
            foreach (char c in Word)
            {
                if (char.IsWhiteSpace(c))
                {
                    spaces++;
                }
            }
            return spaces;
        }
    }
}
