// Your C# code here
public class LC153_Sum
{
    // Your code goes here
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();

        Dictionary<int, HashSet<int>> cache = new Dictionary<int, HashSet<int>>();

        HashSet<List<int>> interm_res = new HashSet<List<int>>();

        for(int i=0;i<nums.Length;i++){
            HashSet<int> hs = new HashSet<int>();
            int n = nums[i];
            if(cache.ContainsKey(n)){
                cache[n].Add(i);
            } else{
                hs.Add(i);
                cache.Add(n, hs);
            }
        }

        for(int i = 0 ;i < nums.Length-2;i++){
            for(int j= i+1; j<nums.Length-1;j++){
                int sum = nums[i] + nums[j];
                int reminder = 0 - sum;
                if(cache.ContainsKey(reminder)){
                    HashSet<int> set = cache[reminder];

                    for(int v = 0; v<set.Count;v++){
                        int idx = set.ElementAt(v);
                        if((idx != j) && (idx > j) && (idx != i)){
                            List<int> sublist = new List<int>();
                            sublist.Add(nums[i]);
                            sublist.Add(nums[j]);
                            sublist.Add(nums[idx]);   
                            //res.Add(sublist);     
                            sublist.Sort();
                            interm_res.Add(sublist);                    
                        }
                    }
                }
            }
        }

        foreach(var v in interm_res){
            res.Add(v);
        }
        return res;
    }

    public static void run_Sum(){
        LC153_Sum obj = new LC153_Sum();
      //  obj.Sum();
    }
}
