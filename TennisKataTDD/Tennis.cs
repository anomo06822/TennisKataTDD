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
            if (IsWin())
            {
                return WinScore();
            }

            if (IsAdv())
            {
                return AdvScore();
            }

            if (IsDeuce())
            {
                return DeuceScore();
            }

            return IsDifferentScore() ? LookupScore() : SameScore();
        }

        private string AdvScore()
        {
            return $"{AdvantagePlayerName()} Adv";
        }

        private string WinScore()
        {
            return $"{AdvantagePlayerName()} Win";
        }

        private bool IsWin()
        {
            return (_firstPlayerTimes >= 4 || _secondPlayerTimes >= 4 )&& Math.Abs(_firstPlayerTimes - _secondPlayerTimes) > 1;
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