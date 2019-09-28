namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayScoreTimes;

        public string GetScore()
        {
            if (_firstPlayScoreTimes == 1)
            {
                return "Fifteen Love";  
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayScoreTimes++;
        }
    }
}