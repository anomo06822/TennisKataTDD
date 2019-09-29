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

        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            if (IsDifferentScore() && (_firstPlayerTimes > 0 || _secondPlayerTimes > 0))
            {
                if (IsAdv())
                {
                    return $"{AdvantagePlayerName()} Adv";
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

        private bool IsAdv()
        {
            return (_firstPlayerTimes > 3 || _secondPlayerTimes > 3) 
                   && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1;
        }

        private string AdvantagePlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? _firstPlayerName : _secondPlayerName;
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