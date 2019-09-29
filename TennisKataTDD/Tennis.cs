using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }


        public string GetScore()
        {
            if (IsDeuce())
            {
                return DeuceScore();
            }

            if (IsSameScore())
            {

                return SameScore();
            }

            if (IsDifferentScore())
            {
                if ((_firstPlayerTimes > 3 || _secondPlayerTimes > 3)
                    && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1)
                {
                    return $"{LeadingPlayerName()} Adv";
                }

                if ((_firstPlayerTimes > 3 || _secondPlayerTimes > 3)
                    && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) >= 2)
                {
                    return $"{LeadingPlayerName()} Win";
                }

                return LookupScore();
            }

            return SameScore();
        }

        private string LeadingPlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? _firstPlayerName : _secondPlayerName;
        }

        private string LookupScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} {_lookupScore[_secondPlayerTimes]}";
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerTimes != _secondPlayerTimes && (_firstPlayerTimes > 0 || _secondPlayerTimes > 0);
        }

        private string SameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} All";
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes > 0;
        }

        private static string DeuceScore()
        {
            return $"Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes >= 3;
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