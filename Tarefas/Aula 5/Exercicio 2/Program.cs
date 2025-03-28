namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            byte Target = (byte)random.Next(0, 100);
            byte Guess;

            Console.WriteLine("Um número aleatorio entre 1 e 100 foi gerado, tente adivinhar!");

            do
            {
                Console.WriteLine("Entre com um número: ");
                Guess = LimitedByteInput(1, 100, Error_Log: "Número inválido, tente denovo: ");

                if (Guess < Target)
                {
                    Console.WriteLine("O Numero é maior.");
                }
                else if (Guess > Target)
                {
                    Console.WriteLine("O Numero é menor.");
                }
            }
            while (Guess != Target);

            Console.WriteLine($"Você acertou, o numero era {Target}!");
        }

        public static byte LimitedByteInput(byte? min = null, byte? max = null, string Error_Log = "")
        {
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out byte output) && 
                    (min is null || output >= min) &&
                    (max is null || output < max))
                {
                    return output;
                }

                Console.WriteLine(Error_Log);
            }
        }
    }
}
