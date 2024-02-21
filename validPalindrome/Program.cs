

// if you look at my other public repos you will find t1.c
// which contains a palindrome function
// but I wrote it when I just started coding


// Se vc olhar meus outros repositorios publicos vc vai achar t1.c
// que contem uma funcao de palindromo
// mas eu escrevi quando eu estava comecando a programar

public class Solution {
    private void format(ref string s){
        s = s.ToLower();
        for(int i = 0 ; i < s.Length; i++){
            if(!char.IsLetterOrDigit(s[i])){
                s = s.Remove(i, 1);
                i--;
            }
        }
    }
    public bool IsPalindrome(string s) {
        format(ref s);
        if(s.Length <= 1) return true;
        int beg = 0;
        int end = s.Length - 1;
        while(beg < end){
            if(s[beg] != s[end]){
                return false;
            }
            beg++;
            end--;
        }
        return true;
    }
}


class Program{

    static void Main(string[] args){

        string str = "A man, a plan, a canal: Panama";
        Solution sol = new Solution();
        Console.WriteLine(sol.IsPalindrome(str));


    }


}