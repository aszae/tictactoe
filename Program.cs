namespace Program
{
    public class TicTacToe
    {
        public static void Main(string[] args)
        {
            string[,] field = new string[5,5];

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

                    if (j %2 != 0)
                    {
                        field[i,j] = " | ";
                    }
                    if (i%2!=0)
                    {
                       field[i,j] = "——"; 
                    }
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();


            }
        }
    }
}
