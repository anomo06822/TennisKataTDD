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
            if (_firstPlayerTimes - _secondPlayerTimes ==1 && _firstPlayerTimes >= 3)
            {
                return "FirstPlayerName_Adv";
            }

            if (_firstPlayerTimes == _secondPlayerTimes)
            {
                if (_firstPlayerTimes >= 3)
                {
                    return "Deuce";
                }
                return $"{_lookupScore[_firstPlayerTimes]}_All";
            }

            if (_firstPlayerTimes >= 1 || _secondPlayerTimes >=1){
                return $"{_lookupScore[_firstPlayerTimes]}_{_lookupScore[_secondPlayerTimes]}";
            }

            return $"{_lookupScore[_firstPlayerTimes]}_All";
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