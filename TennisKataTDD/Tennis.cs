﻿using System;
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
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            if (_firstPlayerTimes > 3 && _firstPlayerTimes - _secondPlayerTimes == 1)
            {
                return "FirstPlayerName Adv";
            }

            if (_secondPlayerTimes > 3 && _secondPlayerTimes - _firstPlayerTimes == 1)
            {
                return "SecondPlayerName Adv";
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