using System.Text;

class CheatSheet
{
    public static void adhocOperation(){


        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************     String Ops         **************");
        Console.WriteLine("****************************************************************");

        string str = "abc";
        Console.WriteLine("str -> " + str);
        Console.WriteLine(" Length of Str " + str.Length);
        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************     String to Char Array         **************");
        Console.WriteLine("****************************************************************");

        str = "abc";
        char[] ch_arr = str.ToCharArray();

        foreach(char c1 in ch_arr){
            Console.Write(c1+",");
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************");


        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************     StringBuilder                **************");
        Console.WriteLine("****************************************************************");

        StringBuilder sb = new StringBuilder();
        sb.Append("abc");
        Console.WriteLine("StringBuilder --> " + sb.ToString());
        Console.WriteLine(" Length of sb " + sb.Length);

        sb.ToString().Reverse();  

        if(sb[0] == '/'){
            sb.Remove(0,1);
        }

        if(sb[sb.Length-1] != '/'){
            sb.Append("/");
        }      

        Console.WriteLine("**************  Remove Last char from sb  ********************");

        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine("StringBuilder --> " + sb.ToString());
        Console.WriteLine(" Length of sb " + sb.Length);
        Console.WriteLine();

        Console.WriteLine("**************  Remove First char from sb  ********************");

        sb.Remove(0, 1);
        Console.WriteLine("StringBuilder --> " + sb.ToString());
        Console.WriteLine(" Length of sb " + sb.Length);
        Console.WriteLine();
        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************     Data Type Conversions        **************");
        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************     int and Double to String       **************");

        int a = 10;
        double b = 10.5;
        string str_a = a.ToString();
        string str_b = b.ToString();

        Console.WriteLine("int a -> " + a + " to String str_a -> " + str_a);
        Console.WriteLine("double b -> " + b + " to String str_b -> " + str_b);


        Console.WriteLine("****************   String to int and Double       **************");

        Console.WriteLine("String str_a -> " + str_a + " to int a -> " + int.Parse(str_a));
        Console.WriteLine("String str_b -> " + str_b + " to double b -> " + double.Parse(str_b));


        Console.WriteLine("****************   char to int       **************");

        char c = '1';
        int c_i = c - '0';
        Console.WriteLine("char c -> " + c + " to int c_i -> " + c_i);

        Console.WriteLine("****************   int to char      **************");

        int c_i2 = 1;
        char c2 = (char)(c_i2 + '0');
        Console.WriteLine("int c_i2 -> " + c_i2 + " to char c2 -> " + c2);
        
        Console.WriteLine("****************************************************************");

        
        Console.WriteLine("****************     List to Array       **************");
        List<int> nums = new List<int>(){1,2,3,4,5};
        int[] arr = nums.ToArray();

        foreach(int n in arr){
            Console.Write(n + ",");
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************     Array to List       **************");
        int[] arr2 = new int[]{1,2,3,4,5};
        List<int> nums2 = arr2.ToList();

        foreach(int n in nums2){
            Console.Write(n + ",");
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************     2D array       **************");

        int[][] arr1 = new int[2][];
        arr1[0] = new int[]{1,2,3};
        arr1[1] = new int[]{4,5,6};

        foreach(int[] a1 in arr1){
            foreach(int n in a1){
                Console.Write(n + ",");
            }
            Console.WriteLine();
        }

        //Jagged array

        int[,] arr3 = new int[2,3]{{1,2,3},{4,5,6}};

       // arr3[2,0] = 7;
        arr3[1, 0] = 7;
        arr3[1, 1] = 8;
        arr3[1, 2] = 9;

        for(int i=0; i<2; i++){
            for(int j=0; j<3; j++){
                Console.Write(arr3[i,j] + ",");
            }
            Console.WriteLine();
        }

        Console.WriteLine("****************************************************************");

        Console.WriteLine("****************     2D List       **************");

        List<List<int>> ll = new List<List<int>>(){
            new List<int>(){1,2,3},
            new List<int>(){4,5,6},
            new List<int>(){7,8,9}
        };

        int[][] arr4 = new int[ll.Count][];
        for(int i=0; i<ll.Count; i++){
            arr4[i] = ll[i].ToArray();
        }
        
    }


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

        myDict["Four"] = 4;

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
        intSet.Add(1);

        intSet.Contains(1); // true 



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