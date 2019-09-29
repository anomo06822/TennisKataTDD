using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty" },
            {3, "Forty" }
        };

        public string GetScore()
        {
            if (_secondPlayerTimes > 0 && _firstPlayerTimes != _secondPlayerTimes)
            {
                return $"Love {_scoreLookup[_secondPlayerTimes]}";
            }

            if (_firstPlayerTimes > 0 && _firstPlayerTimes != _secondPlayerTimes)
            {
                return $"{_scoreLookup[_firstPlayerTimes]} Love";
            }

            if (_firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes == 1)
            {
                return "Fifteen All";
            }


            return "Love All";
        }

        public void FirstPlayerTimes()
        {
            _firstPlayerTimes++;
        }

        public void SecondPlayerTimes()
        {
            _secondPlayerTimes++;
        }
    }
}