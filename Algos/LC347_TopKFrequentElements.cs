// Your C# code here
//using NUnit.Framework;

public class LC347_TopKFrequentElements
{
    // Your code goes here
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Initialize an array to store the result
        int[] result = new int[k];
        // Initialize a dictionary to store the frequency of each element
        Dictionary<int, int> countDict = new Dictionary<int, int>();

        // Count the frequency of each element in the input array
        for (int i = 0; i < nums.Length; i++)
        {
            if (countDict.ContainsKey(nums[i]))
            {
                countDict[nums[i]]++;
            }
            else
            {
                countDict.Add(nums[i], 1);
            }
        }

        // Initialize an array of lists to group elements by their frequency
        List<int>[] freq = new List<int>[nums.Length + 1];

        // Initialize the lists in the array
        for (int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        // Add elements to the appropriate list based on their frequency
        foreach (var keyval in countDict)
        {
            freq[keyval.Value].Add(keyval.Key);
        }

        // Initialize a variable to keep track of the number of elements added to the result array
        int countofresultelements = 0;
        // Iterate through the array of lists in descending order of frequency
        for (int i = freq.Length - 1; i >= 1; i--)
        {
            // Add elements from the list to the result array
            int elementsTobeAdded = freq[i].Count;
            while (elementsTobeAdded > 0)
            {
                result[countofresultelements] = freq[i][elementsTobeAdded - 1];
                elementsTobeAdded--;
                countofresultelements++;
            }
            // If k elements have been added, break out of the loop
            if (countofresultelements == k)
            {
                break;
            }
        }
        // Return the result array
        return result;

    }
    

    public static void run_TopKFrequentElements()
    {
        LC347_TopKFrequentElements obj = new LC347_TopKFrequentElements();

        int[] nums = { -1,-1 };
        int k = 1;
        int[] expected = { 1, 2 };
        // Assert.AreEqual(expected, obj.TopKFrequent(nums, k));

        //  Assert.Equals(expected, obj.TopKFrequent(nums, k));

        int[] res = obj.TopKFrequent(nums, k);

        foreach (var r in res)
        {
            Console.WriteLine(r);
        }


    }
}
