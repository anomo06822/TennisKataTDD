using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        private string _firstPlayerName;
        private string _secondPlayerName;

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

            if (IsReadyForGamePoint())
            {
                return AdvScore();
            }

            if (IsReadyForGameOver())
            {
                return WinScore();
            }

            return IsSame() ? SameScore() : lookupScore();
        }

        private bool IsSame()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
        }

        private string SameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} All";
        }

        private string lookupScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]} {_lookupScore[_secondPlayerTimes]}";
        }

        private string WinScore()
        {
            return $"{AdvPlayerName()} Win";
        }

        private bool IsReadyForGameOver()
        {
            return (_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) > 1;
        }

        private string AdvScore()
        {
            return $"{AdvPlayerName()} Adv";
        }

        private bool IsReadyForGamePoint()
        {
            return (_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1;
        }

        private static string DeuceScore()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes >= 3;
        }

        private string AdvPlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? _firstPlayerName : _secondPlayerName;
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