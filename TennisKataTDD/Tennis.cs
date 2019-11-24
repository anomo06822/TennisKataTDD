using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerTimes;

        public string GetScore()
        {
            if (IsReadyForWin())
            {
                return GetWinScore();
            }

            if (IsAdvantage())
            {
                return GetAdvantageScore();
            }

            if (IsDeuce())
            {
                return GetDeuce();
            }
            return IsSameScore() ? GetSameScore() : GetNormalScore();
        }

        private string GetNormalScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]}_{_lookupScore[_secondPlayerTimes]}";
        }

        private string GetSameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]}_All";
        }

        private static string GetDeuce()
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

        private string GetAdvantageScore()
        {
            return $"{GetLeaderPlayerName()}_Adv";
        }

        private bool IsAdvantage()
        {
            return GetrDifferentScore() == 1 && (_firstPlayerTimes >= 3 || _secondPlayerTimes >= 3);
        }

        private string GetWinScore()
        {
            return $"{GetLeaderPlayerName()}_Win";
        }

        private bool IsReadyForWin()
        {
            return GetrDifferentScore() >= 2 && (_firstPlayerTimes >= 4 || _secondPlayerTimes >= 4);
        }

        private int GetrDifferentScore()
        {
            return Math.Abs(_firstPlayerTimes - _secondPlayerTimes);
        }

        private string GetLeaderPlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? "FirstPlayerName" : "SecondPlayerName";
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