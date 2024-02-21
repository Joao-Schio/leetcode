



public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for(int i = 0; i < n; i++){
            for(int j = 0; j <= i;j++){
                int aux = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = aux;
            }
        }
        for(int i = 0 ; i < n; i++){
            Array.Reverse(matrix[i]);
        }
    }
}

class Program{

    private static void printMatrix(int[][] matrix){
        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix[i].Length; j++){
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }


    public static void Main(string[] Args){
        int n = 4;
        int[][] matrix = new int[n][];
        for(int i = 0 ; i < n; i++){
            matrix[i] = new int[n];
        }
        int count = 1;
        for(int i = 0 ; i < n; i++){
            for(int j = 0; j < n; j++){
                matrix[i][j] = count++;
            }
        }

        printMatrix(matrix);
        Console.Write("\n\n\n");
        Solution sol = new Solution();
        sol.Rotate(matrix);
        printMatrix(matrix);

        

    }


}