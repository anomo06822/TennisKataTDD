using System;

namespace TennisKataTDD
{
    public class Tennis 
    {
        private int _firstPlayerTimes;

        public string GetScore()
        {
            if (_firstPlayerTimes == 2)
            {
                return "Thirty_Love";
            }

            if (_firstPlayerTimes == 1)
            {
                return "Fifteen_Love";
            }
            return "Love_All";
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerTimes++;
        }
    }
}