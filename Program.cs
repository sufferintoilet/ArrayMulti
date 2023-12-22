using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[,] array ={{1,2,3,4,5},
                        {6,7,8,9,10},
                        {11,12,13,14,15},
                        {16,17,18,19,20}};
        int max = array[0,0];
        int n=0;
        int m=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j]>max)
                {
                    max = array[i,j];
                    n=i;
                    m=j;
                }
            }
        }
        Console.WriteLine("gia tri lon nhat cuar mang la "+max+ m+n);
    
    }   
}