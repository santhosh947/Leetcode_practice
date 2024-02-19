// Your C# code here
public class LC125_ValidPalindrome
{
    // Your code goes here
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;

        string mod_s = s.ToLower();
        while(start<end){
            char front_ch = mod_s[start];
            char end_ch = mod_s[end];

            // instead of checking manually, you can use the built in function like.
            //if(char.IsLetterOrDigit(front_ch))
            if(!((front_ch >= 'a' && front_ch <= 'z') || (front_ch >= '0' && front_ch <= '9'))){
                start++;
            }else if(!((end_ch >= 'a' && end_ch <= 'z') || (end_ch >= '0' && end_ch <= '9'))){
                end--;
            } else{
               if( front_ch != end_ch){
                   return false;
               }else{
                   start++;
                   end--;
               }
            }
        }

        return true;
    }

    public static void run_ValidPalindrome(){
        LC125_ValidPalindrome obj = new LC125_ValidPalindrome();
        obj.IsPalindrome("A man, a plan, a canal: Panama");
    }
}
