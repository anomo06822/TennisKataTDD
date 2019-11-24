using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerTimes;

        public string GetScore()
        {
            if (_secondPlayerTimes == 1)
            {
                return $"Love_{_lookupScore[_secondPlayerTimes]}";
            }
            if (_firstPlayerTimes >= 1)
            {
                return $"{_lookupScore[_firstPlayerTimes]}_Love";
            }
            return "Love_All";
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