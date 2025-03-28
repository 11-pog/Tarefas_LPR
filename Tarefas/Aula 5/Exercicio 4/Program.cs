namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número, e a soma dos digitos do quadrado desse número sera calculado: ");

            int Input = InputInt("Número inválido, tente novamente: ");
            string InputSquared = (Input*Input).ToString();

            int sum = 0;
            foreach (char num in InputSquared)
            {
                sum += num - 48;
            }

            Console.WriteLine($"O resultado é {sum}");
            Console.ReadKey();
        }

        static int InputInt(string Error_Log)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int Output))
                {
                    return Output;
                }
                Console.WriteLine(Error_Log);
            }
        }
    }
}
