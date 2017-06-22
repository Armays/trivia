using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {

        private readonly Players _players;

        private readonly Questions _questions;

        private readonly DisplayMessage _console;

        bool isGettingOutOfPenaltyBox;


        public Game(Players players, Questions questions, DisplayMessage console)
        {
            _players = players;
            _questions = questions;
            _console = console;
        }

        public void Roll(int roll)
        {
            _console.Display(_players.Current.Name + " is the current player");
            _console.Display("They have rolled a " + roll);

            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    isGettingOutOfPenaltyBox = true;

                    _console.Display(_players.Current.Name + " is getting out of the penalty box");
                    _players.Current.Move(roll);

                    _console.Display(_players.Current.Name
                            + "'s new location is "
                            + _players.Current.Place);
                    _questions.AskQuestion(_players.Current.Place);
                }
                else
                {
                    _console.Display(_players.Current.Name + " is not getting out of the penalty box");
                    isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);

                _console.Display(_players.Current.Name
                        + "'s new location is "
                        + _players.Current.Place);
                _questions.AskQuestion(_players.Current.Place);
            }

        }

        public bool WasCorrectlyAnswered()
        {
            bool winner;
            if (_players.Current.InPenaltyBox)
            {
                if (isGettingOutOfPenaltyBox)
                {
                    _console.Display("Answer was correct!!!!");
                    _players.Current.WinAGoldCoin();

                    winner = _players.Current.IsWinner();
                    _players.NextPlayer();

                    return winner;
                }

                _players.NextPlayer();
                return false;
            }

            _console.Display("Answer was corrent!!!!");
            _players.Current.WinAGoldCoin();

            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            _console.Display("Question was incorrectly answered");
            _console.Display(_players.Current.Name + " was sent to the penalty box");
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }
}
