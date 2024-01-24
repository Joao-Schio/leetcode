


public class Solution {
    
    private void troca(ref int x, ref int y){ 
        int aux = x;
        x = y;
        y = aux;
    }

    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        int end = nums.Length - 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] == val){
                count++;
                troca(ref nums[i], ref nums[end]);
                end--;
            }
        }
        return count;
    }
}



class Program{
    public static void Main(string[] args){
        //int[] nums = {1,2,3,4,5,5,5,5,6,7,8};
        int[] nums = {0,1,2,2,3,0,4,2};
        // I legit the it works on my machine meme
        // I cannot get it to bug here, but on leetcode it doesnt accept it
        // maybe we're using a different .NET version ?

        Solution s = new Solution();

        int resposta =  s.RemoveElement(nums,2);
        

        Console.WriteLine(resposta);
        foreach(int n in nums){
            Console.Write(n + " ");
        }

        Console.WriteLine();

    }

}