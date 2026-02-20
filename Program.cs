namespace Program
{
    public class TicTacToe
    {
        public static void Main(string[] args)
        {
            string[,] field = new string[3,3];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i,j] = "x";
                }
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {

                    Console.Write(field[i,j]);

                    if (j != field.GetLength(1)-1)
                    {
                        Console.Write(" | ");
                    }
                    
                }
                Console.WriteLine("");
                for (int z = 0; z < field.GetLength(1)+6; z++)
                {
                    Console.Write("—");
                }
                Console.WriteLine();
                

            }
        }
    }
}
