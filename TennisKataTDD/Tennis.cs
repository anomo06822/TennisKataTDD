using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private string _firstPlayerName;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string GetScore()
        {
            if (IsDifferentScore() && (_firstPlayerTimes > 0 || _secondPlayerTimes > 0))
            {
                if (_firstPlayerTimes > 3 && _firstPlayerTimes - _secondPlayerTimes == 1)
                {
                    return $"{_firstPlayerName} Adv";
                }

                return LookupScore();
            }

            if (IsDeuce())
            {
                return DeuceScore();
            }

            if (IsSameScore() && _firstPlayerTimes > 0)
            { 
                return SameScore();
            }

            return SameScore();
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayerTimes]} All";
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayerTimes]} {_scoreLookup[_secondPlayerTimes]}";
        }

        private static string DeuceScore()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayerTimes >= 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerTimes != _secondPlayerTimes;
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