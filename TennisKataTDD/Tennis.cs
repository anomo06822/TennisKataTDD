using System;
using System.Collections.Generic;
using System.Globalization;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        private int _secondPlayerTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetStore()
        {
            if (IsReadyForGamePoint())
            {
                return AdvantageScore();
            }

            if (IsReadyForGameOver())
            {
                return WinScore();
            }

            if (IsDeuce())
            {
                return DeuceScore();
            }

            return IsSameScore() ? SameScore() : LookupScore();
        }

        private string LookupScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} {_lookupScore[_secondPlayerTimes]}";
        }

        private string SameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} All";
        }

        private static string DeuceScore()
        {
            return "Deuce";
        }

        private string WinScore()
        {
            return $"{AdvantagePlayerName()} Win";
        }

        private string AdvantageScore()
        {
            return $"{AdvantagePlayerName()} Adv";
        }

        private bool IsReadyForGameOver()
        {
            return (IsDifferentScore() && _firstPlayerTimes > 3 || _secondPlayerTimes > 3)
                   && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) > 1;
        }

        private bool IsReadyForGamePoint()
        {
            return (IsDifferentScore() && _firstPlayerTimes > 3 || _secondPlayerTimes > 3)
                   && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1;
        }

        private string AdvantagePlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerTimes != _secondPlayerTimes;
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayerTimes == 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
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