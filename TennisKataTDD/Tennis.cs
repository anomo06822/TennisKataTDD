using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;

        public string GetScore()
        {
            Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen" },
                {2, "Thirty" }
            };

            if (_firstPlayScoreTimes > 0)
            {
                return $"{scoreLookup[_firstPlayScoreTimes]} Love";  
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayScoreTimes++;
        }
    }
}