


public class Solution{
  public int[] ProductExceptSelf(int[] nums){
    int[] output = new int[nums.Length];
    int result = 1;
    int hasZero = -1;
    int zeroCount = 0;

    for(int i = 0; i < nums.Length; i++){
      if(nums[i] != 0){
        result *= nums[i];
      }
      else{
        hasZero = i;
        zeroCount++;
      }
    }

    if(hasZero == -1){
      for(int i = 0 ; i < nums.Length; i++){
        output[i] = result / nums[i];
      }
    }
    else{
      if(zeroCount > 1){
        return output;
      }
      else{
        for(int i = 0 ; i < hasZero; i++){
          output[i] = 0;
        }
        output[hasZero] = result;
        for(int i = hasZero + 1; i < nums.Length; i++){
          output[i] = 0;
        }
      }
    }
    return output;   
  }
}


class Program{
  public static void Main(string [] args){
    
    int [] nums = {-1,1,0,-3,3};
    Solution s = new Solution();
    int[] resposta = s.ProductExceptSelf(nums);

    foreach(int i in resposta){
      Console.Write(i + " ");
    }
    Console.WriteLine();

  }
}


