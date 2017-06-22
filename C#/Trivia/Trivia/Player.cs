using System;

namespace Trivia
{
    public class Player
    {
        public string Name { get; private set; }
        private DisplayMessage _console;

        public int Place { get; private set; }

        public int GoldCoins { get; private set; }

        public bool InPenaltyBox { get; set; }

        public Player(string name, DisplayMessage console)
        {
            Name = name;
            Place = 0;
            GoldCoins = 0;
            InPenaltyBox = false;
            _console = console;
        }


        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }

        public void WinAGoldCoin()
        {
            GoldCoins++;
            _console.Display(Name + " now has " + GoldCoins + " Gold Coins.");
        }

        public void GoToPenaltyBox()
        {
            InPenaltyBox = true;
        }

        public bool IsWinner()
        {
            return GoldCoins == 6;
        }
    }
}