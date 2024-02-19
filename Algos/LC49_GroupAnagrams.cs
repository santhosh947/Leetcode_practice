// Your C# code here
using System;
using System.Collections;
using System.Collections.Generic;
public class LC49_GroupAnagrams
{
    // Your code goes here
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

        for(int i=0;i< strs.Length; i++){
            string s = strs[i];

            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string sorted_str = new string(arr);

            IList<string> vals = new List<string>();

            if(map.ContainsKey(sorted_str)){
                map[sorted_str].Add(s);
            }else{
                vals.Add(s);
            map.TryAdd(sorted_str, vals);
            }
        }

      var res = map.Values.ToList();
      return res;
    }

    public bool IsAnagram(string s, string t){
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> map = new Dictionary<char, int>();

        for(int i=0;i<s.Length; i++){
            map.TryAdd(s[i],0);
            map.TryAdd(t[i],0);

            map[s[i]]++;
            map[t[i]]--;
        }

        return map.Values.All(val => val == 0);
    }

    public static void run_GroupAnagrams(){
        LC49_GroupAnagrams obj = new LC49_GroupAnagrams();
      //  obj.GroupAnagrams();
    }
}
