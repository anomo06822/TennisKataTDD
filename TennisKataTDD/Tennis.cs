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
            if (IsDifferentScore())
            {
                return LookupScore();  
            }

            if (IsSameScore())
            {
                if (_firstPlayScoreTimes >= 3)
                {
                    return "Deuce";
                }

                return SameScore();
            }

            return SameScore();
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayScoreTimes]} All";
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayScoreTimes]} {_scoreLookup[_secondPlayScoreTimes]}";
        }

        private bool IsSameScore()
        {
            return _firstPlayScoreTimes == _secondPlayScoreTimes;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayScoreTimes != _secondPlayScoreTimes;
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