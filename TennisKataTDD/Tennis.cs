namespace TennisKata
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;

        public string GetScore()
        {
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore(int score)
        {
            _firstPlayerScoreTimes++;
        }
    }
}