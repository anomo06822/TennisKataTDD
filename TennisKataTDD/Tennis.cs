namespace TennisKataTDD
{
    public class Tennis
    {
        private int _firstPlayerTimes;

        public string GetStore()
        {
            if (_firstPlayerTimes == 2)
            {
                return "Thirty Love";
            }
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