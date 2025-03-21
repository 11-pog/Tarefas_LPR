namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma classe de RPG:\n" +
                "- Guerreiro(a)\n" +
                "- Mago\n" +
                "- Arqueiro(a)");

            bool Exit = false;
            
            while (!Exit)
            {
                string? input = Console.ReadLine();
                if (input is null) return;

                switch (input.ToLower())
                {
                    case "guerreira":
                    case "guerreiro":
                        Console.WriteLine("Suas habilidades são Ataque Pesado e Defesa Total");
                        Exit = true;
                        break;

                    case "mago":
                        Console.WriteLine("Suas habilidades são Bola de Fogo e Escudo de Gelo");
                        Exit = true;
                        break;

                    case "arqueiro":
                    case "arqueira":
                        Console.WriteLine("Suas habilidades são Flecha Precisa e Disparo Triplo");
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("Essa classe não existe, tente denovo");
                        break;
                }
            }
        }
    }
}
