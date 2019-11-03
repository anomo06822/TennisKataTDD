using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis 
    {
        private int _firstPlayerTimes;

        public string GetScore()
        {
            var lookupScores = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            if (_firstPlayerTimes > 0)
            {
                return $"{lookupScores[_firstPlayerTimes]}_Love";
            }

            return "Love_All";
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerTimes++;
        }
    }
}