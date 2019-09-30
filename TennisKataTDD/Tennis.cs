using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        

        public string GetScore()
        {
            if (_firstPlayerTimes == _secondPlayerTimes)
            {
                if (_firstPlayerTimes >= 3)
                {
                    return "Deuce";
                }

                return $"{_lookupScore[_firstPlayerTimes]} All";
            }

            if ((_firstPlayerTimes > 0 || _secondPlayerTimes > 0) && _firstPlayerTimes != _secondPlayerTimes)
            {
                return $"{_lookupScore[_firstPlayerTimes]} {_lookupScore[_secondPlayerTimes]}";
            }

            return "Love All";;
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