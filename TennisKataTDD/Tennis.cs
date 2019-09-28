using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty" },
            {3, "Forty" }
        };

        public string GetScore()
        {
            if (_secondPlayerScoreTimes == 2)
            {
                return $"Love Thirty";
            }

            if (_secondPlayerScoreTimes == 1)
            {
                return $"Love Fifteen";
            }

            if (_firstPlayerScoreTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayerScoreTimes]} Love";
            }
            
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}