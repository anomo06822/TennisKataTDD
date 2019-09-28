using System;
using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen"},
            {2, "Thirty" },
            {3, "Forty" }
        };

        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScore()
        {
            return IsScoreDifferent() 
                    ? IsReadyForGamePoint() ? AdvState() : LookupScore() 
                    : IsDeuce() 
                        ? Deuce() 
                        : SameScore();
        }

        private string AdvState()
        {
            return IsAdv() ? AdvScore() : WinScore();
        }

        private string AdvScore()
        {
            return $"{AdvPlayer()}_Adv";
        }

        private string WinScore()
        {
            return $"{AdvPlayer()}_Win";
        }

        private bool IsReadyForGamePoint()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private string AdvPlayer()
        {
            return _firstPlayerScoreTimes > _secondPlayerScoreTimes 
                ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string Deuce()
        {
            return "Deuce";
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}