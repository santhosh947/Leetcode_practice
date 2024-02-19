// Your C# code here
public class LC217_ContainsDuplicates
{
    // Your code goes here
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                set.Add(nums[i]);
            }
        }
        return false;
    }

    public static void run_ContainsDuplicates()
    {
        LC217_ContainsDuplicates lc = new LC217_ContainsDuplicates();
        int[] nums = { 1, 2, 3, 4 };
        Console.WriteLine(lc.ContainsDuplicate(nums));

        Console.WriteLine("*************");

        nums = new int[] { 1, 2, 1 };

        Console.WriteLine(lc.ContainsDuplicate(nums));


    }
}
