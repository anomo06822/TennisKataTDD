using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;
        private int _secondPlayScoreTimes;

        public string GetScore()
        {
            Dictionary<int, string> scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen" },
                {2, "Thirty" },
                {3, "Forty" }
            };

            if (_firstPlayScoreTimes > 0)
            {
                return $"{scoreLookup[_firstPlayScoreTimes]} Love";  
            }

            if (_secondPlayScoreTimes > 0)
            {
                return $"Love {scoreLookup[_secondPlayScoreTimes]}";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayScoreTimes++;
        }
    }
}