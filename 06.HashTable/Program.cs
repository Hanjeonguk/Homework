namespace _06.HashTable
{
    public class CheatKey//치트키 클래스 생성
    {

        private Dictionary<string, Action> cheatDic;//Dictionary 변수 생성

        public CheatKey() //치트키 생성자
        {
            cheatDic = new Dictionary<string, Action>(); //Dictionary 생성 

            cheatDic.Add("ShowMeTheMoney", ShowMeTheMoney);
            cheatDic.Add("ThereIsNoCowLevel", ThereIsNoCowLevel); //키, 데이터 입력
        }

        public void Run(string cheatKey)//동작 함수
        {
            //if (cheatDic.ContainsKey(cheatKey)) //가독성 좋으나, 두번 확인 필요
            //{
            //    cheatDic[cheatKey]();
            //}

            cheatDic.TryGetValue(cheatKey, out Action action);//입력한 키값이 있으면 output에 데이터입력, 없으면 null
            action?.Invoke();//델리게이트 함수 호출 // ?연산자 null이 아니면 실행, null이면 실행안함

            // if,for 조건문 없이 바로 탐색하여 치트키 발동
        }

        private void ShowMeTheMoney()//골드 치트키
        {
            Console.WriteLine("골드를 얻습니다, 치트키 발동!");
        }

        private void ThereIsNoCowLevel()//승리 치트키
        {
            Console.WriteLine("바로 승리합니다, 치트키 발동!");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            CheatKey cheatKey = new CheatKey();//치트키 인스턴스 생성

            cheatKey.Run("ShowMeTheMoney"); 
            cheatKey.Run("ThereIsNoCowLeve"); //동작함수 입력

        }
    }
}

