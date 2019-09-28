using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;
        private int _secondPlayScoreTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };

        public string GetScore()
        {
            if (_firstPlayScoreTimes > 0 || _secondPlayScoreTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayScoreTimes]} {_scoreLookup[_secondPlayScoreTimes]}";  
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