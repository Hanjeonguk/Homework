// 1.아래와 같이 추가와 삭제가 순서대로 진행될 경우 스택, 큐가 출력을 적어주자.

// a.(1,2,3,4,5), 모두 꺼내기
// Stack : 54321
// Queue : 12345
// b.추가(1,2,3), 꺼내기(2번), 추가(4,5,6),꺼내기(1번) 추가(7), 모두꺼내기 
// Stack : 3267541
// Queue : 1234567
// c.추가(3,2,1), 꺼내기(1번), 추가(6,5,4), 꺼내기(3번), 추가(9,8,7), 모두꺼내기 
// Stack : 145678923
// Queue : 321654987
// d.추가(1, 3, 5), 꺼내기(1번), 추가(2, 4, 8), 꺼내기(2번), 추가(1, 3), 모두꺼내기
// Stack : 58431231  
// Queue : 13524813
// e.추가(3, 2, 1), 꺼내기(2번), 추가(3, 2, 1), 꺼내기(2번), 추가(3, 2, 1), 모두꺼내기
// Stack : 121212333
// Queue : 321321321


// 2. 아래 문제를 보고 스택 또는 큐를 써서 해결하시오.

//<괄호 검사기를 구현하자>
//괄호: 괄호가 바르게 짝지어져 있다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻이다.

//텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수
//bool IsOk(string text){}

//검사할 괄호 : [],{},()

//예시: 괄호는 ()완성, (()미완성, [)미완성, [[(){}]] 완성
namespace _03.Stack
{
    public class Program
    {
        public static bool IsOk(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c=='(')
                {
                    stack.Push(c);
                }
                else if (c=='{') 
                {
                    stack.Push(c);
                }
                else if (c == '[')
                {
                    stack.Push(c);
                }
                else if(c == ')')
                {
                    if(stack.Count ==0)
                        return false;

                    char bracket = stack.Pop();
                    if (bracket == '(') 
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    char bracket = stack.Pop();
                    if (bracket == '{')
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char bracket = stack.Pop();
                    if (bracket == '[')
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
        static void Main1(string[] args)
        {
            do
            {
                string text = Console.ReadLine();
                Console.WriteLine(IsOk(text));
            } while (true);
        }
    }
}


// 3. 아래 문제를 보고 스택 또는 큐를 써서 해결하시오.
//<작업프로세스>
//각 작업이 몇시간이 걸리는 작업인지 포함한 배열이 있으며,
//하루에 8시간씩 일할 수 있는 회사가 있음.
//남는시간없이 주어진 일을 계속한다고 했을때.
//각각의 작업이 끝나는 날짜를 결과 배열로 출력

//int[] ProcessJob(int[] jobList){}

//예시 : [4,4,12,10,2,10]
//결과: [1,1,3,4,4,6]
//해석 : 1일차에 0, 1 클리어 : 0번째 작업의 4/4 + 1번째 작업의 4/4 완료,
//       2일차에             : 2번째 작업의 8/12 완료
//       3일차에 2 클리어    : 2번째 작업의 4/12 완료 + 3번째 작업의 4/10 완료
//       4일차에 3, 4 클리어 : 3번째 작업의 6/10 완료 + 4번째 작업의 2/2 완료
//       5일차에             : 5번째 작업의 8/10 완료
//       6일차에 5 클리어    : 5번째 작업의 2/10 완료

namespace _03.Stack02
{
    public class Program
    {
        public const int WorkTime = 8;

        public static int[] ProcessJob(int[] jobList) 
        {
            Queue<int> queue = new Queue<int>();
            int remainTime = 8;
            int day = 1;
            List<int>days = new List<int>();

            for (int i=0; i<jobList.Length; i++)
            {
                queue.Enqueue(jobList[i]);
            }
            while (queue.Count > 0)
            {
                int workTime = queue.Dequeue();
                while (true)
                {
                    if (workTime <= remainTime)
                    {
                        remainTime -= workTime;
                        // 작업 완료
                        days.Add(day);
                        break;
                    }
                    else
                    {
                        workTime -= remainTime;
                        // 다음날 이어서
                        day++;
                        remainTime = 8;
                    }
                }
            }
         return days.ToArray();
        }

        static void Main(String[] args)
        {
            int[] result = ProcessJob(new int[] { 4, 4, 12, 10, 2, 10 });
            foreach(int day in result)
            {
                Console.WriteLine($"{day}");
            }
        }
    }
}