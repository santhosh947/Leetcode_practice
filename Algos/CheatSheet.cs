class CheatSheet
{
    public static SortedDictionary<string, int> getTrees()
    {
        //Trees (TreeSet and TreeMap are not directly available, but you can use SortedSet and SortedDictionary):
        // SortedSet
        SortedSet<int> sortedSet = new SortedSet<int> { 5, 4, 3, 2, 1 };

        // SortedDictionary
        SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>
        {
            { "One", 1 },
            { "Two", 2 },
            { "Three", 3 }
        };

        return sortedDict;
    }

    public static void getLinkedList()
    {
        // Declaration and initialization
        LinkedList<int> linkedList = new LinkedList<int>();

        // Adding elements
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // Iterating through linked list
        foreach (int num in linkedList)
        {
            Console.WriteLine(num);
        }
    }

    public static void getStack()
    {
        // Declaration and initialization
        Stack<int> intStack = new Stack<int>();

        // Push
        intStack.Push(1);

        // Pop
        while (intStack.Count > 0)
        {
            Console.WriteLine(intStack.Pop());
        }
    }

    public static void getQueue()
    {
        // Declaration and initialization
        Queue<int> intQueue = new Queue<int>();

        // Enqueue
        intQueue.Enqueue(1);
        // Dequeue
        //  int dequeuedItem = intQueue.Dequeue();

        while (intQueue.Count > 0)
        {
            Console.WriteLine(intQueue.Dequeue());
        }
    }

    public static void getDictonary()
    {
        // Declaration and initialization
        Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 }
            };

        // Accessing values
        int value = myDict["Two"];

        Console.WriteLine(value);
    }

    public static void getArray()
    {
        // Declaration and initialization
        int[] intArray = new int[] { 1, 2, 3, 4, 5 };

        // Accessing elements
        int element = intArray[2];

        // Iterating through array
        foreach (int num in intArray)
        {
            Console.WriteLine(num);
        }

    }


    public static void getList()
    {
        // Declaration and initialization
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

        // Adding elements
        intList.Add(6);

        // Iterating through list
        foreach (int num in intList)
        {
            Console.WriteLine(num);
        }

Console.WriteLine("*********");
        List<List<int>> ll = new List<List<int>>(){
            new List<int>(){1,2,3},
            new List<int>(){4,5,6},
            new List<int>(){7,8,9}
        };

        ll[1].Add(10);

        foreach (List<int> l in ll)
        {
            foreach (int num in l)
            {
                Console.WriteLine(num);
            }
        }
    }

    public static void getPriorityQueue(){
        // Declaration and initialization
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        // Enqueue
        pq.Enqueue(1, -1);
        pq.Enqueue(2, -2);
        pq.Enqueue(3,-3 );

        // Dequeue
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }

        PriorityQueue<(int, List<int>), int> pq2 = new PriorityQueue<(int, List<int>), int>();
        List<int> l1 = new List<int>(){1,2,3};
        List<int> l2 = new List<int>(){4,5,6};

        pq2.Enqueue((1, l1), -1);
        pq2.Enqueue((2, l2), -2);

        while (pq2.Count > 0)
        {
            Console.WriteLine(pq2.Dequeue());
        }

    }


    public static void getHashSet()
    {
        // HashSet
        HashSet<int> intSet = new HashSet<int> { 10, 2, 3, 4, 5 };

        // SortedSet
        SortedSet<int> sortedIntSet = new SortedSet<int> { 5, 4, 3, 2, 1 };

        for (int i = 0; i < intSet.Count; i++)
        {
            Console.WriteLine(intSet.ElementAt(i));
        }

        Console.WriteLine("*********");
        for (int i = 0; i < sortedIntSet.Count; i++)
        {
            Console.WriteLine(sortedIntSet.ElementAt(i));
        }

    }
}