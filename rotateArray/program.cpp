#include <iostream>
#include <vector>



using std::vector;


class Solution {
public:
    void rotate(vector<int>& nums, int k) {
        if(nums.size() == 1){
            return;
        }
        vector<int> aux(nums.size());
        for(unsigned i = 0 ; i < nums.size(); i++){
            unsigned int index = i + k;
            if(index >= nums.size())
                index = index % nums.size();
            
            aux.at(index) = nums.at(i);
        }
        for(unsigned i = 0 ; i < nums.size(); i++){
            nums[i] = aux[i];
        }
    }
};







int main(void){
    vector<int> v = {1,2};
    int k = 3;

    Solution sol = Solution();
    sol.rotate(v,k);

    for(int n : v){
        std::cout << n << " ";
    }
    std::cout << std::endl;

}