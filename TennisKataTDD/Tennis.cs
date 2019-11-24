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

        public string GetScore()
        {
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
    }
}