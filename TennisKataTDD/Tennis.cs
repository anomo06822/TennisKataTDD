using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis 
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        private Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private string _secondPlayerName;
        private string _firstPlayerName;

        public Tennis(string secondPlayerName, string firstPlayerName)
        {
            _secondPlayerName = secondPlayerName;
            _firstPlayerName = firstPlayerName;
        }

        public string GetScore()
        {
            if (IsAdvantage())
            {
                return GetAdvantageScore();
            }

            if (IsReadyForWin())
            {
                return GetWinScore();
            }

            if (IsDeuce())
            {
                return GetDeuce();
            }

            return IsSameScore() ? GetSameScore() : GetNormalScore();
        }

        private bool IsReadyForWin()
        {
            return Math.Abs(_firstPlayerTimes - _secondPlayerTimes) >= 2 && (_firstPlayerTimes >= 4 || _secondPlayerTimes >=4 );
        }

        private bool IsAdvantage()
        {
            return Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1 && (_secondPlayerTimes >= 3 || _firstPlayerTimes >=3);
        }

        private string GetSameScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]}_All";
        }

        private string GetNormalScore()
        {
            return $"{_lookupScore[_firstPlayerTimes]}_{_lookupScore[_secondPlayerTimes]}";
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayerTimes >= 3;
        }

        private static string GetDeuce()
        {
            return "Deuce";
        }

        private string GetWinScore()
        {
            return $"{GetLeaderPlayerName()}_Win";
        }

        private string GetAdvantageScore()
        {
            return $"{GetLeaderPlayerName()}_Adv";
        }

        private string GetLeaderPlayerName()
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