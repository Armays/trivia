using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Players
    {
        private readonly List<Player> _players = new List<Player>();
        private readonly DisplayMessage _console;

        public Players(DisplayMessage console)
        {
            _console = console;
        }
        public Player Current { get; private set; }

        public void NextPlayer()
        {
            var nextPlayer = _players.IndexOf(Current) + 1;
            if (nextPlayer == _players.Count) nextPlayer = 0;
            Current = _players[nextPlayer];
        }

        public bool Add(string playerName)
        {
            var player = new Player(playerName, _console);
            if (!_players.Any())
            {
                Current = player;
            }
            _players.Add(player);

            _console.Display(playerName + " was added");
            _console.Display("They are player number " + _players.Count);
            return true;
        }
    }
}
