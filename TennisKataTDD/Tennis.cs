using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        

        public string GetScore()
        {
            if (_firstPlayerTimes > 0)
            {
                return $"{_lookupScore[_firstPlayerTimes]} Love";
            }

            if (_secondPlayerTimes > 0)
            {
                return $"Love {_lookupScore[_secondPlayerTimes]}";
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