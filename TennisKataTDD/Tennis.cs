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

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            var lookupScores = new Dictionary<int, string>()
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            if ((_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) > 1)
            {
                return $"{GetLeadingPlayerName()} Win";
            }

            if ((_firstPlayerTimes > 3 || _secondPlayerTimes > 3) && Math.Abs(_firstPlayerTimes - _secondPlayerTimes) == 1)
            {
                return $"{GetLeadingPlayerName()} Adv";
            }

            if (_firstPlayerTimes == _secondPlayerTimes)
            {
                if (_firstPlayerTimes > 2)
                {
                    return "Deuce";
                }

                return $"{lookupScores[_firstPlayerTimes]}_All";
            }

            if (_firstPlayerTimes != _secondPlayerTimes)
            {
                return $"{lookupScores[_firstPlayerTimes]}_{lookupScores[_secondPlayerTimes]}";
            }

            return string.Empty;
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