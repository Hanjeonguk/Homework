// 사용자에게 숫자를 입력 받아서
// 0부터 숫자까지 가지는 리스트 만들기
// 0요소를 제거
// 리스트가 가지는 모든 요소들을 출력해주는 반복분 작성
/////////////////////
namespace List.task
{
    public class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                list.Add(i);
            }
            list.Remove(0);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}  ");
            }
        }
    }
}
// 사용자의 입력을 받아서 없는 데이터면 추가, 있던 데이터면 삭제하는 보관함
// ex) 1,6,7,8,3 들고 있던 상황이면
// 2입력하면 1,6,7,8,3,2
// 7 입력하면 1,6 8,3
namespace Task24._01._11__2
{
    public class Program
    {
        static void Main1(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(3);

            Console.Write("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());


            bool b = list.IndexOf(input) != -1;


            if (b == true)
            {
                list.Remove(input);
            }
            else
            {
                list.Add(input);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }
}

// 인벤토리 구현(아이템 수집, 아이템 버리기)


// 긁어온 내용 임시보관 //


//namespace Task24._01._11__3
//{


//    using System;
//    using System.Collections.Generic;

//    class Item
//    {
//        public string Name { get; set; }
//        public int Quantity { get; set; }

//        public Item(string name, int quantity)
//        {
//            Name = name;
//            Quantity = quantity;
//        }
//    }

//    class Player
//    {
//        public string Name { get; set; }
//        public Inventory Inventory { get; set; }

//        public Player(string name)
//        {
//            Name = name;
//            Inventory = new Inventory();
//        }
//    }

//    class Inventory
//    {
//        private List<Item> items;

//        public Inventory()
//        {
//            items = new List<Item>();
//        }

//        public void AddItem(string itemName, int quantity)
//        {
//            Item existingItem = items.Find(i => i.Name == itemName);

//            if (existingItem != null)
//            {
//                existingItem.Quantity += quantity;
//            }
//            else
//            {
//                items.Add(new Item(itemName, quantity));
//            }
//        }

//        public void UseItem(string itemName, int quantity)
//        {
//            Item item = items.Find(i => i.Name == itemName);

//            if (item != null && item.Quantity >= quantity)
//            {
//                item.Quantity -= quantity;
//                Console.WriteLine($"Player used {quantity} {itemName}(s).");
//            }
//            else
//            {
//                Console.WriteLine($"Not enough {itemName} in the inventory.");
//            }
//        }

//        public void DisplayInventory()
//        {
//            Console.WriteLine($"Inventory:");

//            foreach (var item in items)
//            {
//                Console.WriteLine($"{item.Name}: {item.Quantity}");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Player player = new Player("John");

//            player.Inventory.AddItem("Health Potion", 5);
//            player.Inventory.AddItem("Sword", 1);
//            player.Inventory.AddItem("Shield", 2);

//            player.Inventory.DisplayInventory();

//            player.Inventory.UseItem("Health Potion", 3);
//            player.Inventory.UseItem("Sword", 1);
//            player.Inventory.UseItem("Arrow", 5);

//            player.Inventory.DisplayInventory();
//        }
//    }

//}

//namespace Task24._01._11__3
//{
//    // 기본 아이템 클래스
//    class Item
//    {
//        public string Name { get; set; }
//        public int Quantity { get; set; }

//        public Item(string name, int quantity)
//        {
//            Name = name;
//            Quantity = quantity;
//        }

//        public virtual void Use()
//        {
//            Console.WriteLine($"Used {Quantity} {Name}(s).");
//        }
//    }

//    // 소모품 아이템 클래스
//    class ConsumableItem : Item
//    {
//        public ConsumableItem(string name, int quantity) : base(name, quantity)
//        {
//        }

//        public override void Use()
//        {
//            base.Use();
//            Console.WriteLine($"{Name} has been consumed.");
//        }
//    }

//    // 장비 아이템 클래스
//    class EquipmentItem : Item
//    {
//        public EquipmentItem(string name, int quantity) : base(name, quantity)
//        {
//        }

//        public override void Use()
//        {
//            base.Use();
//            Console.WriteLine($"{Name} has been equipped.");
//        }
//    }

//    // 플레이어 클래스
//    class Player
//    {
//        public string Name { get; set; }
//        public List<Item> Inventory { get; set; }

//        public Player(string name)
//        {
//            Name = name;
//            Inventory = new List<Item>();
//        }

//        public void AddItem(Item item)
//        {
//            Item existingItem = Inventory.Find(i => i.Name == item.Name);

//            if (existingItem != null)
//            {
//                existingItem.Quantity += item.Quantity;
//            }
//            else
//            {
//                Inventory.Add(item);
//            }
//        }

//        public void UseItem(string itemName, int quantity)
//        {
//            Item item = Inventory.Find(i => i.Name == itemName);

//            if (item != null && item.Quantity >= quantity)
//            {
//                item.Quantity -= quantity;
//                item.Use();
//            }
//            else
//            {
//                Console.WriteLine($"Not enough {itemName} in the inventory.");
//            }
//        }

//        public void DisplayInventory()
//        {
//            Console.WriteLine($"Inventory for {Name}:");

//            foreach (var item in Inventory)
//            {
//                Console.WriteLine($"{item.Name}: {item.Quantity}");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Player player = new Player("Alice");

//            player.AddItem(new ConsumableItem("Health Potion", 5));
//            player.AddItem(new EquipmentItem("Sword", 1));
//            player.AddItem(new ConsumableItem("Mana Potion", 3));

//            player.DisplayInventory();

//            player.UseItem("Health Potion", 3);
//            player.UseItem("Sword", 1);
//            player.UseItem("Arrow", 5);

//            player.DisplayInventory();
//        }
//    }
//}

