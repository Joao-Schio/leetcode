

public class Solution {
    public int HIndex(int[] citations) {

        Array.Sort(citations);
        int n = citations.Length;
        int h = 0;
        for(int i = 0; i < n; i++){
            int count = n - i;
            if(citations[i] >= count){
                h = Math.Max(h, count);
            }
        }
        return h;
  
    }
}


class Program{
  
  public static void Main(string [] args){
      int[] c = {3,0,6,1,5};

      Solution s = new Solution();

      Console.WriteLine(s.HIndex(c));


  }


}


