namespace ConsoleApp1
{

    public class Solution
    {
        public int[] solution(long n) // 자연수 12345 입력
        {
            string str = n.ToString(); // 정수를 문자열로 변환
            int[] answer = new int[str.Length]; // answer 배열 생성, 크기는 [문자열 길이]
            Stack<int>stack = new Stack<int>();
            char a = str[1];
            for (int i = 0; i < str.Length; i++) // 문자열 길이 만큼 반복
            {
                stack.Push(int.Parse(str[i].ToString()));  //정수로 변환하여 answer배열에 입력
            }
            for (int i = 0; i < str.Length; i++) // 문자열 길이 만큼 반복
            {
                answer[i] = stack.Pop(); //배열에 하나씩 입력
            }
            return answer;// 배열 54321 출력
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = sol.solution(12345);
            foreach (int i in array)
            {
                Console.Write($"{i,3}");
            }
        }
    }
}

//public class CheatKey
//{
//    private Dictionary<string, Action> cheatDic;

//    public CheatKey() 
//    {
//        cheatDic = new Dictionary<string, Action>();


//    }

//    public void Run(string cheatKey)
//    {

//    }

//    private void ShowMeTheMoney()
//    {
//        Console.WriteLine("골드를 얻습니다, 치트키 발동!");
//    }

//    private void ThereIsNoCowLevel()
//    {
//        Console.WriteLine("바로 승리합니다, 치트키 발동!");
//    }
//}

