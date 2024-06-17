// Your C# code here
public class LC2225_FindPlayersWithZeroorOneLosses
{
    // Your code goes here
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        IList<IList<int>> res = new List<IList<int>>();

        int[] losses = new int[100001];
       
        foreach (var match in matches)
        {
           int winner = match[0];
           int looser = match[1];

           if(losses[winner] == 0){
            losses[winner] = -1;
           }
           if(losses[looser] == -1){
             losses[looser] = 1;
           } else {
            losses[looser]++;
           }
        }        

        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        for(int i=1;i< losses.Length;i++){
            if(losses[i] == -1){
                list1.Add(i);
            }

            if(losses[i] == 1){
                list2.Add(i);
            }
        }


        res.Add(list1);
        res.Add(list2);
        return res;
    }

    public static void run_FindPlayersWithZeroorOneLosses()
    {
        LC2225_FindPlayersWithZeroorOneLosses obj = new LC2225_FindPlayersWithZeroorOneLosses();

        int[][] array = new int[][] {
                    new int[] {1, 3},
                    new int[] {2, 3},
                    new int[] {3, 6},
                    new int[] {5, 6},
                    new int[] {5, 7},
                    new int[] {4, 5},
                    new int[] {4, 8},
                    new int[] {4, 9},
                    new int[] {10, 4},
                    new int[] {10, 9}
        };

       IList<IList<int>> res = obj.FindWinners(array);

       foreach(List<int> ll in res){

        for(int i=0;i<ll.Count;i++){
            Console.WriteLine(ll.ElementAt(i) + ", ");
        }

        Console.WriteLine();
       }
    }
}
