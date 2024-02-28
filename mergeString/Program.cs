

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        string output = "";

        while(i < word1.Length && i < word2.Length){
            output += word1[i];
            output += word2[i];
            i++;
        }
        while(i < word1.Length){
            output += word1[i];
            i++;
        }
        while(i < word2.Length){
            output += word2[i];
            i++;
        }
        return output;
    }
}



class Program{
    public static void Main(string[] args){
        string s = "abc";
        string s2 = "pqrs";

        Solution sol = new Solution();

        Console.WriteLine(sol.MergeAlternately(s,s2));

    }
}