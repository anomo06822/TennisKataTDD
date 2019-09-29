using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };


        public string GetScore()
        {
            if (_firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes > 0)
            {
                return $"{_lookupScore[_firstPlayerTimes]} All";
            }

            if (_firstPlayerTimes != _secondPlayerTimes && _secondPlayerTimes > 0)
            {
                return $"Love {_lookupScore[_secondPlayerTimes]}";
            }

            if (_firstPlayerTimes != _secondPlayerTimes && _firstPlayerTimes > 0)
            {
                return $"{_lookupScore[_firstPlayerTimes]} Love";
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