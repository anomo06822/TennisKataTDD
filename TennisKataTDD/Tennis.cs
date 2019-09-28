using System;
using System.Collections.Generic;

namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;
        private readonly string _firstPlayerName;

        private int _secondPlayScoreTimes;
        private readonly string _secondPlayerName;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            if (IsDeuce())
            {
                return DeuceScore();
            }

            if (IsReadyForGamePoint())
            {
                return AdvScore();
            }

            if (IsWon())
            {
                return WinScore();
            }

            return IsDifferentScore() ? LookupScore() : SameScore();
        }

        private string AdvScore()
        {
            return $"{AdvantagePlayerName()} Adv";
        }

        private string WinScore()
        {
            return $"{AdvantagePlayerName()} Win";
        }

        private bool IsWon()
        {
            return (_firstPlayScoreTimes >= 4 || _secondPlayScoreTimes >= 4) && Math.Abs(_firstPlayScoreTimes - _secondPlayScoreTimes) > 1;
        }

        private bool IsReadyForGamePoint()
        {
            return (_firstPlayScoreTimes > 3 || _secondPlayScoreTimes > 3) && Math.Abs(_firstPlayScoreTimes - _secondPlayScoreTimes) == 1;
        }

        private string AdvantagePlayerName()
        {
            return _firstPlayScoreTimes > _secondPlayScoreTimes ? _firstPlayerName : _secondPlayerName;
        }

        private string DeuceScore()
        {
            return "DeuceScore";
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