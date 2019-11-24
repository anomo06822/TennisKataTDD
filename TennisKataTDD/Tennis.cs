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
            if (_firstPlayerTimes - _secondPlayerTimes >= 2 && _firstPlayerTimes >= 4)
            {
                return $"{GetLeaderPlayerName()}_Win";
            }

            if (_firstPlayerTimes - _secondPlayerTimes <= -2 && _secondPlayerTimes >= 4)
            {
                return $"{GetLeaderPlayerName()}_Win";
            }

            if (_firstPlayerTimes - _secondPlayerTimes ==1 && _firstPlayerTimes >= 3)
            {
                return $"{GetLeaderPlayerName()}_Adv";
            }

            if (_firstPlayerTimes - _secondPlayerTimes == -1 && _secondPlayerTimes >= 3)
            {
                return $"{GetLeaderPlayerName()}_Adv";
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