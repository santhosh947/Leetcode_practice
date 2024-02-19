// Your C# code here
public class LC238_ProductofArrayExceptSelf
{
    // Your code goes here
    public int[] ProductExceptSelf(int[] nums) {
        int[] store = new int[nums.Length];
        store[0] = 1;

        for(int i=1; i<nums.Length;i++){
            store[i] = store[i-1] * nums[i-1];
        }

        int multiplier = 1;

        for(int i = nums.Length-2; i > -1;i--){
            multiplier *= nums[i+1];
            store[i] = multiplier * store[i];
        }
        return store;
    }

    public static void run_ProductofArrayExceptSelf(){
        LC238_ProductofArrayExceptSelf obj = new LC238_ProductofArrayExceptSelf();
       // obj.ProductofArrayExceptSelf();
    }
}
