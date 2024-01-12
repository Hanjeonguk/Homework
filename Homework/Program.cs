//사용자의 입력으로 숫자를 입력 받아서
//음수는 앞에 추가하고, 양수는 뒤에 추가하여
//음수&양수를 반으로 나누는 연결리스트 구현
//입력 받을 때마다 처음부터 끝까지 출력 진행
using System;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

namespace LinkedList.Task
{
    public class Program
    {
        static void Main1(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            int num = 0;
            int min = 0;
            while (num != null)
            {
                Console.Write("\n숫자(양수, 음수)를 입력하세요 : ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    LinkedListNode<int> node = linkedList.AddLast(num);
                    Console.WriteLine("[입력 받은 수]");
                    foreach (int element in linkedList) { Console.Write(element); }

                    if (min == 0)
                    {
                        min = num;
                    }
                    else if (min >= num)
                    {
                        min = num;
                    }
                }
                else if (num < 0)
                {
                    LinkedListNode<int> node = linkedList.AddFirst(num);
                    Console.WriteLine("[입력 받은 수]");
                    foreach (int element in linkedList) { Console.Write(element); }
                }
                else // 양수 음수 사이에 0 집어넣기??
                {
                    LinkedListNode<int> findNode = linkedList.Find(min);
                    LinkedListNode<int> node = linkedList.AddAfter(findNode, num);

                    Console.WriteLine("[입력 받은 수]");
                    foreach (int element in linkedList) { Console.Write(element); }
                }
            }
        }
    }
}
//요세푸스 순열 문제

//1번부터 n번까지 n명의 사람이 원을 이루면서 앉아있고,
//양의 정수 k(<=n)가 주어진다. 이제 순서대로 k번째 사람을 제거한다.
//한 사람이 제거되면 남은 사람들로 이루어진 원을 따라
//이 과정을 계속해 나간다. 이 과정은 n명의 사람이 모두 제거될 때까지
//계속된다. 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다.
//예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.

//N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오.

namespace LinkedList.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Console.Write("사람의 수를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("제거할 순서를 입력하세요: ");
            int kill = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                linkedList.AddLast(i + 1);
            }





        }

    }
}