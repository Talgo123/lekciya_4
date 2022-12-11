// Двухмерные массивы
//                          строка столбец 
// string[,] table = new string[2, 5];
// // String.Empty
// // table [0, 0]  table [0, 1]  table [0, 2]  table [0, 3] table [0, 4]
// // table [1, 0]  table [1, 1]  table [1, 2] и тд
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"{table[rows, columns]}_");
//     }
// }




void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write($"{matr[rows, j]} ");
        }
System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // от 1 до 9.
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);