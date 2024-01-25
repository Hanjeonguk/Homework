/* 문제
 * 웅찬이는 과제가 많다. 하루에 한 과제를 끝낼 수 있는데, 
 * 과제마다 마감일이 있으므로 모든 과제를 끝내지 못할 수도 있다. 
 * 과제마다 끝냈을 때 얻을 수 있는 점수가 있는데, 마감일이 지난 
 * 과제는 점수를 받을 수 없다. 웅찬이는 가장 점수를 많이 받을 수 
 * 있도록 과제를 수행하고 싶다. 웅찬이를 도와 얻을 수 있는 점수의 
 * 최댓값을 구하시오.
 * 
 * 입력
 * 첫 줄에 정수 N (1 ≤ N ≤ 1,000)이 주어진다.
 * 다음 줄부터 N개의 줄에는 각각 두 정수 d (1 ≤ d ≤ 1,000)와 
 * w (1 ≤ w ≤ 100)가 주어진다. d는 과제 마감일까지 남은 일수를 의미하며, 
 * w는 과제의 점수를 의미한다.
 * 
 * 출력
 * 얻을 수 있는 점수의 최댓값을 출력한다.
 */
namespace _05.Heap
{
    internal class Program
    {
        public struct Homework
        {
            public string name;
            public int deadline;
            public int score;

            public Homework(string name, int deadline, int score)
            {
                this.name = name;
                this.deadline = deadline;
                this.score = score;
            }
        }

        public void Run()
        {
            int sumScore = 0;
            List<Homework> homeworks = new List<Homework>();

            homeworks.Add(new Homework("A", 4, 60));
            homeworks.Add(new Homework("B", 4, 40));
            homeworks.Add(new Homework("C", 1, 20));
            homeworks.Add(new Homework("D", 2, 50));
            homeworks.Add(new Homework("E", 3, 30));
            homeworks.Add(new Homework("F", 4, 10));
            homeworks.Add(new Homework("G", 6, 5));

            // 마감일이 많이 남은 순서대로 꺼내기 위해 내림차순 우선순위 큐에 추가
            PriorityQueue<Homework, int> remainPQ = new PriorityQueue<Homework, int>();
            foreach (Homework work in homeworks)
            {
                remainPQ.Enqueue(work, -work.deadline);
            }

            // 뒤에서부터 가장 높은 점수 순서대로 처리
            PriorityQueue<Homework, int> scorePQ = new PriorityQueue<Homework, int>();
            for (int day = remainPQ.Peek().deadline; day >= 1; day--)
            {
                while (remainPQ.Count > 0 && remainPQ.Peek().deadline == day)
                {
                    Homework homework = remainPQ.Dequeue();
                    scorePQ.Enqueue(homework, -homework.score);
                }

                if (scorePQ.Count > 0)
                {
                    Homework target = scorePQ.Dequeue();
                    sumScore += target.score;
                    Console.WriteLine($"{target.name} 과제를 {day} 일차에 수행해야 한다. 총점 : {sumScore}");
                }

                if (remainPQ.Count == 0)
                    break;
            }
        }
       
    }
    public class Test
    {
        public static void Main(string[] args)
        { 
          
        }
    }
}


