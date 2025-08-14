using static System.Net.Mime.MediaTypeNames;

namespace Challenge_Lab_6
{
    //Rotate an nxn matrix 90 degrees in place
    //Status: Complete

    //90 degree rotation mean row 0 is column n-1, row 1 is last column n-2... row n-1 is column 0
    //Flip the matrix across the (0,0) diagonal then reverse each row
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] test1 = new int[3, 3]
            {
                {1 ,2, 3 },
                {4, 5 ,6 },
                {7, 8, 9 }
            };
            int[,] test2 = new int[4, 4]
            {
                {5, 1, 9, 11 },
                {2, 4, 8, 10 },
                {13, 3, 6, 7 },
                {15, 14, 12, 16 }
            };

            Rotate90(test1);
            Rotate90(test2);
            Console.ReadKey();
        }
        static void Rotate90(int[,] matrix)
        {
            Console.WriteLine("Original");
            PrintMatrix(matrix);
            FlipAcrossDiagonal(matrix);
            //PrintMatrix(test1);
            ReverseEachRow(matrix);
            Console.WriteLine("Rotated 90 Degrees");
            PrintMatrix(matrix);
        }
        static void FlipAcrossDiagonal (int[,] matrix)
        {
            int temp = 0;
            for (int i = 0; i< matrix.GetLength(0); i++)
            {
                for(int j = i; j< matrix.GetLength(0); j++)
                {
                    temp = matrix[i,j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }

        static void ReverseEachRow(int[,] matrix)
        {
            int temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0)/2; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(0)-1-j];
                    matrix[i, matrix.GetLength(0) - 1 - j] = temp;
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
