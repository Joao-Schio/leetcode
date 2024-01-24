


public class Solution {
    private void puxa(int index, int[] nums){
        int aux = nums[index];
        for(int i = index; i < nums.Length - 1; i++){
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = aux;
    }
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] == val){
                count++;
                puxa(i,nums);
            }
        }
        return count;
    }
}

class Program{
    public static void Main(string[] args){
        //int[] nums = {1,2,3,4,5,5,5,5,6,7,8};
        int[] nums = {0,1,2,2,3,0,4,2};
        // ok, now it should be working but for some reason leetcode doesnt accept it
        // and I cant get it to not work on my machine
        Solution s = new Solution();

        int resposta =  s.RemoveElement(nums,2);
        

        Console.WriteLine(resposta);
        foreach(int n in nums){
            Console.Write(n + " ");
        }

        Console.WriteLine();

    }

}