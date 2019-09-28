using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;
        private int _secondPlayScoreTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };

        private string _firstPlayerName;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            if (IsDifferentScore())
            {
                if (IsReadyForGamePoint())
                {
                    return $"{AdvantagePlayerName()} Adv";
                }

                if (_firstPlayScoreTimes >= 4 
                    && Math.Abs(_firstPlayScoreTimes - _secondPlayScoreTimes) > 1)
                {
                    return $"{AdvantagePlayerName()} Win";
                }

                return LookupScore();  
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private bool IsReadyForGamePoint()
        {
            return (_firstPlayScoreTimes > 3 || _secondPlayScoreTimes > 3) && Math.Abs(_firstPlayScoreTimes - _secondPlayScoreTimes) == 1;
        }

        private string AdvantagePlayerName()
        {
            return _firstPlayScoreTimes > _secondPlayScoreTimes ? _firstPlayerName : _secondPlayerName;
        }

        private string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return IsSameScore() && _firstPlayScoreTimes >= 3;
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayScoreTimes]} All";
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayScoreTimes]} {_scoreLookup[_secondPlayScoreTimes]}";
        }

        private bool IsSameScore()
        {
            return _firstPlayScoreTimes == _secondPlayScoreTimes;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayScoreTimes != _secondPlayScoreTimes;
        }

        public void FirstPlayerScore()
        {
            _firstPlayScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayScoreTimes++;
        }
    }
}