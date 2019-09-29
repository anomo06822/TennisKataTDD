using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty" },
        };

        public string GetScore()
        {
            if (_firstPlayerTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayerTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerTimes()
        {
            _firstPlayerTimes++;
        }
    }
}