using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis 
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        private Dictionary<int, string> _lookupScores = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            if (IsReadyForWin())
            {
                return GetWinScore();
            }

            if (IsAdvantage())
            {
                return GetAdvantage();
            }

            if (IsDeuce())
            {
                return GetDeuce();
            }

            return IsSameScore() ? GetSameScore() : GetLookupScore();
        }

        private string GetLookupScore()
        {
            return $"{_lookupScores[_firstPlayerTimes]}_{_lookupScores[_secondPlayerTimes]}";
        }

        private string GetSameScore()
        {
            return $"{_lookupScores[_firstPlayerTimes]}_All";
        }

        private bool IsSameScore()
        {
            return _firstPlayerTimes == _secondPlayerTimes;
        }

        private static string GetDeuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes > 2;
        }

        private string GetAdvantage()
        {
            return $"{GetLeadingPlayerName()} Adv";
        }

        private bool IsAdvantage()
        {
            return (_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1;
        }

        private string GetWinScore()
        {
            return $"{GetLeadingPlayerName()} Win";
        }

        private bool IsReadyForWin()
        {
            return (_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) > 1;
        }

        private string GetLeadingPlayerName()
        {
            return _firstPlayerTimes > _secondPlayerTimes ? _firstPlayerName : _secondPlayerName;
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerTimes++;
        }

        public void SecondPlayerScoreTimes()
        {
            _secondPlayerTimes++;
        }
    }
}