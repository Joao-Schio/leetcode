using System.Collections;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        List<int> al = new List<int>();
        for(int i = 0 ; i < nums.Length; i++){
            al.Add(nums[i]);
        }
        al.Sort();

        
        return al.ElementAt(nums.Length - k);

    }
}


public class Program{
    public static void Main(string[] args){
        int[] nums = {3,2,3,1,2,4,5,5,6};
        
        Solution s = new Solution();


        Console.WriteLine(s.FindKthLargest(nums,4));
    

    }
}