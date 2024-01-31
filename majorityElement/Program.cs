using System.Collections;
using System.Diagnostics.Metrics;

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> hsh = new Dictionary<int, int>();
        for(int i = 0 ; i < nums.Length; i++){
            if(hsh.ContainsKey(nums[i])){
                hsh[nums[i]]++;
            }
            else{
                hsh.Add(nums[i],0);
            }
        }
        return hsh.Aggregate((x,y) => x.Value > y.Value ? x : y).Key;
    }
}




public class Program{
    public static void Main(string[] Args){
        int[] nums = {1,1,2,3,4,5,1,1,1,1};
        Solution sol = new Solution();
        int resposta = sol.MajorityElement(nums);
        Console.WriteLine(resposta);
    }
}