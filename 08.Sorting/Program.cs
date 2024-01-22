//알고리즘 정렬 구현하기
//1.선택정렬
//2.삽입정렬
//3.병합정렬
//4.버블정렬
//5.퀵 정렬
//6.힙 정렬
//7.안정정렬과 불안정정렬(병합정렬의 사용의의)
namespace _08.Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> selectionList = new List<int>();
            List<int> insetionList = new List<int>();

            Random random = new Random();
            int count = 10;


            Console.Write("랜덤 함수:");
            for (int i = 0; i < count; i++) 
            {
                int rand = random.Next(0,100);
                Console.Write($"{rand,3}");
                selectionList.Add(rand);
                insetionList.Add(rand);
            }
            Console.WriteLine();



            Sorting.SelectionSort(selectionList, 0, selectionList.Count);
            Console.Write("선택 정렬:");
            foreach(int i in selectionList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();

            Sorting.InsertionSort(insetionList,0, insetionList.Count);
            Console.Write("삽입 정렬:");
            foreach (int i in insetionList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();

        }
    }
}
