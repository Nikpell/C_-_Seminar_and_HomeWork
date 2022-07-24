


int [,]CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for (int i =0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1);
            Console.WriteLine(newMatrix[i,j] + "");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
//1



//2
