

class Solution {
    public int RemoveDuplicates(int[] nums) {
        

        Dictionary<int,int> dc = new Dictionary<int, int>();
        int k                  = 0;

        for(int i = 0; i < nums.Length; i++){
            if(dc.ContainsKey(nums[i])){
                if(dc[nums[i]] < 2){
                    k++;
                }
                dc[nums[i]] = dc[nums[i]] + 1;
            }
            else{
                dc.Add(nums[i],1);
                k++;
            }
        }

        int ind = 0;
        foreach(KeyValuePair<int, int> i in dc){
            if(ind > k){
                break;
            }
            nums[ind] = i.Key;
            if(i.Value >= 2){
                nums[ind + 1] = i.Key;
                ind          += 2;
            }
            else{
                ind += i.Value;
            }
        }
        return k;
    }
}



class Program{

    public static void Main(string [] args){

        
        int [] nums = {0,0,1,1,1,1,2,3,3};

        Solution s = new Solution();
        
        int k = s.RemoveDuplicates(nums);

        Console.WriteLine(k);
        foreach(int i in nums){
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}