// Your C# code here
public class LC36_ValidSudoku
{
    // Your code goes here
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<string> seen = new HashSet<string>();

        for(int i =0;i<9; i++){
            for(int j=0;j < 9; j++){
                char currVal = board[i][j];

                if(currVal != '.'){
                    if(!seen.Add(currVal + " in row " + i) || !seen.Add(currVal + " in col " + j) || !seen.Add(currVal + " in grid " + i/3 + j/3)){
                        return false;
                    }
                }
            }
        }
        return true;
    }

    public static void run_ValidSudoku(){
        LC36_ValidSudoku obj = new LC36_ValidSudoku();
       // obj.IsValidSudoku();
    }
}
