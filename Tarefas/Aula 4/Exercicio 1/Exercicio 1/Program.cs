// See https://aka.ms/new-console-template for more information


namespace tarefa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero e direi se é par ou impar: ");
            long Input = InputLong("Numero inválido, tente novamente");

            if (Input % 2 == 0)
            {
                Console.WriteLine("É par.");
            }
            else
            {
                Console.WriteLine("É ímpar.");
            }
        }

        static long InputLong(string error_Log = "")
        {
            while (true)
            {
                if (long.TryParse(Console.ReadLine(), out long output))
                {
                    return output;
                }
                else IfStringWrite(error_Log);
            }
        }

        static void IfStringWrite(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(input);
            }
        }
    }
}
