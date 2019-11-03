using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis 
    {
        private int _firstPlayerTimes;
        private int _secondPlayerTimes;

        public string GetScore()
        {
            var lookupScores = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            if (_firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes == 2)
            {
                return "Thirty_All";
            }

            if (_firstPlayerTimes == _secondPlayerTimes && _firstPlayerTimes == 1)
            {
                return "Fifteen_All";
            }

            if (_firstPlayerTimes > 0)
            {
                return $"{lookupScores[_firstPlayerTimes]}_Love";
            }

            if (_secondPlayerTimes > 0)
            {
                return $"Love_{lookupScores[_secondPlayerTimes]}";
            }

            return "Love_All";
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