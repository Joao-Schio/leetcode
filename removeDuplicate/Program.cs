



using System.Collections;

public class Solution {

    private bool contains(ArrayList a, int n){
        foreach(int i in a){
            if(i == n){
                return true;
            }
        }
        return false;
    }
    public int RemoveDuplicates(int[] nums) {
        ArrayList sortNoRep = new ArrayList();
        for(int i = 0; i < nums.Length; i++){
            if (!contains(sortNoRep,nums[i])){
                sortNoRep.Add(nums[i]);
            }
        }
        if(sortNoRep != null){
            for(int i = 0; i < sortNoRep.Count; i++){
                nums[i] = (int)sortNoRep[i];
            }
        
            return sortNoRep.Count;
        }
        else{
            return 0;
        }
    }
}




class Program{
    public static void Main(string[] args){
        int[] nums = {0,0,1,1,1,2,2,3,3,4};
        Solution s = new Solution();
        

        int n = s.RemoveDuplicates(nums);
        Console.WriteLine(n);
        foreach(int i in nums){
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}