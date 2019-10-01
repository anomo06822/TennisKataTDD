using System.Collections.Generic;
using System.Globalization;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen" },
            {2, "Thirty" },
        };

        public string GetStore()
        {
            if (_firstPlayerTimes > 0)
            {
                return $"{_lookupScore[_firstPlayerTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerTimes()
        {
            _firstPlayerTimes++;
        }
    }
}