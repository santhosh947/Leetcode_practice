// Your C# code here
public class LC128_LongestConsecutiveSequence
{
    // Your code goes here
   public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        int res= 0;
        foreach(int n in nums){
            seen.Add(n);
        }

        foreach(int n in nums){
            int x = n - 1;
            if(!seen.Contains(x)){
                int y = n + 1;
                while(seen.Contains(y)){
                    y+=1;
                }
                res = Math.Max (res, y-x);
            }
        }
        return res;
    }

    public static void run_LongestConsecutiveSequence(){
        LC128_LongestConsecutiveSequence obj = new LC128_LongestConsecutiveSequence();
        //obj.LongestConsecutiveSequence();
    }
}
