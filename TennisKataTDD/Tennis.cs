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

        private string _firstPlayerName;

        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string GetScore()
        {
            if (IsDifferentScore())
            {
                if (_firstPlayScoreTimes > 3 && _firstPlayScoreTimes - _secondPlayScoreTimes == 1)
                {
                    return $"{_firstPlayerName} Adv";
                }

                return LookupScore();  
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayScoreTimes >= 3;
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