namespace ConsoleApp1
{
    public class CheatKey
    {
        private Dictionary<string, Action> cheatDic;

        public CheatKey() 
        {
            cheatDic = new Dictionary<string, Action>();


        }

        public void Run(string cheatKey)
        {

        }

        private void ShowMeTheMoney()
        {
            Console.WriteLine("골드를 얻습니다, 치트키 발동!");
        }

        private void ThereIsNoCowLevel()
        {
            Console.WriteLine("바로 승리합니다, 치트키 발동!");
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {

        }
    }
}
