public class LC242_ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

        for(int i =0;i <s.Length;i ++){
            keyValuePairs.TryAdd(s[i],0);
            keyValuePairs.TryAdd(t[i], 0);

            keyValuePairs[s[i]]++;
            keyValuePairs[t[i]]--;
        }
       // return keyValuePairs.Values.All(val => val == 0);       

       for(int i=0; i<keyValuePairs.Count;i++){
        if(keyValuePairs.ElementAt(i).Value != 0){
            return false;
        }        
       }

       return true;
    }

    public static void run_ValidAnagram()
    {
        LC242_ValidAnagram obj = new LC242_ValidAnagram();
        Console.WriteLine(obj.IsAnagram("tart", "ratt"));
    }   
}
