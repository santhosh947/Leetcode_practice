// Your C# code here
public class LC1_TwoSum
{
    // Your code goes here
    

    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] res = new int[2];

        for(int i=0;i< nums.Length; i++){
            int n = nums[i];
            int residual = target-n;

            if(map.ContainsKey(n)){
                res[0] = i;
                res[1] = map[n];
                break;
            }else{
                map.TryAdd(residual, i);
            }
        }
        return res;
    }

    public static void run_TwoSum(){
        LC1_TwoSum obj = new LC1_TwoSum();

        int[] nums = {1,2,3};

        obj.TwoSum(nums, 4);
    }
}
