// Your C# code here
using System.Formats.Tar;

public class LC167_TwoSumIIInputArrayIsSorted
{
    // Your code goes here
    public void TwoSumIIInputArrayIsSorted()
    {
        Console.WriteLine("****** TwoSumIIInputArrayIsSorted *********");
    }

    public int[] TwoSum(int[] numbers, int target)
    {
        int[] res = new int[2];

        for(int i  =0; i<numbers.Length; i++){
            int n = numbers[i];
            int reminder = target - n;

            int idx = binarySearch(numbers, i +1, numbers.Length-1, reminder);
            if(idx != -1){
                res[0] = i;
                res[1] = idx;
            }
        }
        return res;
    }

    private int binarySearch(int[] numbers, int st, int end, int reminder)
    {
        int idx = -1;

        while(st <= end){
            int mid = st + end/2;

            if(numbers[mid] == reminder){
                return mid;
            }else if(numbers[mid] < reminder){
                st = mid + 1;
            }else{
                end = mid -1;
            }
        }
        return idx;
    }

    public static void run_TwoSumIIInputArrayIsSorted()
    {
        LC167_TwoSumIIInputArrayIsSorted obj = new LC167_TwoSumIIInputArrayIsSorted();
        int[] nums = {2,7,11,15};

        int[] res = obj.TwoSum(nums, 9);

        foreach(int r in res){
            Console.WriteLine(r + ",");
        }
    }
}
