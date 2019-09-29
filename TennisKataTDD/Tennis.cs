namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        public string GetScore()
        {
            if (_firstPlayerTimes == 1)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }

        public void FirstPlayerTimes()
        {
            _firstPlayerTimes++;
        }
    }
}