

using static System.Int32;

namespace HomeWork6;

class Program
{
    private class ListTask
    {
        private readonly List<string?> _stringList = ["s1","s2","s3"];

        public void TaskLoop()
        {
            Console.WriteLine("Введите строку: ");
            _stringList.Add(Console.ReadLine());
            Console.Write("Текущая строка: ");
            _stringList.ForEach(s => Console.Write(s + ", "));
            Console.WriteLine();
            Console.WriteLine("Введите строку: ");
            _stringList.Insert(_stringList.Count / 2, Console.ReadLine());
            Console.Write("Текущая строка: ");
            _stringList.ForEach(s => Console.Write(s + ", "));
        }
    }
    private class DictionaryTask
    {
        // Напишите программу, которая создает словарь, связывая имена студентов с их средними оценками.
        //
        //     Попросите пользователя ввести имя студента и его оценку. Обязательно сделайте проверку на корректность ввода оценки: она должна быть от 2 до 5.
        // Затем попросите пользователя ввести имя студента, и выведите оценку. Если студента нет в словаре, напишите, что студента с таким именем не существует.
        private readonly Dictionary<string, float> _dictionary  = [];

        public void TaskLoop()
        {
            Console.WriteLine("Введите имя студента");
            string? name = Console.ReadLine();
            Console.WriteLine("Введите оценку студента");
            float assessment = Convert.ToSingle(Console.ReadLine());
            while (assessment is < 2 or > 5)
            {
                Console.WriteLine("Некорректный ввод оценки. Введите оценку студента");
                assessment = Convert.ToSingle(Console.ReadLine());
            }

            if (name != null) _dictionary.Add(name, assessment);
            Console.WriteLine("Введите имя студента");
            name = Console.ReadLine();
            if (_dictionary.TryGetValue(name, out var value))
            {
                Console.WriteLine("Оценка студента: " + value);
            }
            else
            {
                Console.WriteLine("Cтудента с таким именем не существует");
            }
        }
    }
    private class LinkedListTask
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
        public class DoublyLinkedList<T>
        {
            public Node<T> Head { get; private set; }
            public Node<T> Tail { get; private set; }
            public int Count { get; private set; }

            public DoublyLinkedList()
            {
                Head = null;
                Tail = null;
                Count = 0;
            }

            public void Add(T value)
            {
                Node<T> node = new Node<T>(value);
                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Tail.Next = node;
                    node.Previous = Tail;
                    Tail = node;
                }
                Count++;
            }

            public void Remove(T value)
            {
                Node<T> current = Head;
                while (current != null)
                {
                    if (current.Value.Equals(value))
                    {
                        if (current.Previous != null)
                        {
                            current.Previous.Next = current.Next;
                        }
                        else
                        {
                            Head = current.Next;
                        }
                        if (current.Next != null)
                        {
                            current.Next.Previous = current.Previous;
                        }
                        else
                        {
                            Tail = current.Previous;
                        }
                        Count--;
                        return;
                    }
                    current = current.Next;
                }
            }

            public bool Contains(T value)
            {
                Node<T> current = Head;
                while (current != null)
                {
                    if (current.Value.Equals(value))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            public void Clear()
            {
                Head = null;
                Tail = null;
                Count = 0;
            }
        }

        public void TaskLoop()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            Console.Write("Введите количество эдементов (3-6): ");
            int numElements = Convert.ToInt32(Console.ReadLine());
            if (numElements < 3 || numElements > 6)
            {
                Console.WriteLine("Неверный ввод");
                return;
            }

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"Ввод значения {i + 1}: ");
                int element = Convert.ToInt32(Console.ReadLine());
                list.Add(element);
            }

            Console.WriteLine("В прямом порядке:");
            Node<int> current = list.Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();

            Console.WriteLine("В противоположном порядке:");
            current = list.Tail;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Previous;
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {

        Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
        TryParse(Console.ReadLine(), out int task);
        switch (task) 
        {
            case 1:
                CheckTaskFirst();
                break;
            case 2:
                CheckTaskSecond();
                break;
            case 3:
                CheckTaskThird();
                break;
            default:
                Console.WriteLine("EXIT!");
                break;
        }
    }
    private static void CheckTaskFirst()
    {
        var listTask = new ListTask();
        listTask.TaskLoop();
    }
    private static void CheckTaskSecond()
    {
        var dictionaryTask = new DictionaryTask();
        dictionaryTask.TaskLoop();
    }
    private static void CheckTaskThird()
    {
        var linkedListTask = new LinkedListTask();
        linkedListTask.TaskLoop();
    }
    
}