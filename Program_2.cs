using System;

class GFG
{

    static int R = 4;
    static int C = 4;

    static void rotatematrix(int m,
                        int n, int k, int[,] mat)
    {
        int row = 0, col = 0;
        int prev, curr;
        k = k %= R;

        while (row < m && col < n)
        {
            if (row + 1 == m || col + 1 == n)
                break;

            prev = mat[row + 1, col];

            for (int i = col; i < n-k; i++)
            {
                curr = mat[row, i];
                mat[row, i] = prev;
                prev = curr;
            }
            row++;

            for (int i = row; i < m-k; i++)
            {
                curr = mat[i, n - 1];
                mat[i, n - 1] = prev;
                prev = curr;
            }
            n--;

            if (row < m)
            {
                for (int i = n - 1; i >= col; i--)
                {
                    curr = mat[m - 1, i];
                    mat[m - 1, i] = prev;
                    prev = curr;
                }
            }
            m--;

            if (col < n)
            {
                for (int i = m - 1; i >= row; i--)
                {
                    curr = mat[i, col];
                    mat[i, col] = prev;
                    prev = curr;
                }
            }
            col++;
            {
                for (int j = k; j < R; j++) ;
            }
        }

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
                Console.Write(mat[i, j] + " ");
            Console.Write("\n");
        }
    }

    public static void Main()
    {
        // Test Case 1
        int[,] a = { {12, 2, 3, 4},
                    {1, 6, 31, 8},
                    {9, 23, 11, 12},
                    {13, 13, 15, 123} };

        int k = 1;

        rotatematrix(R, C, k, a);

    }
}