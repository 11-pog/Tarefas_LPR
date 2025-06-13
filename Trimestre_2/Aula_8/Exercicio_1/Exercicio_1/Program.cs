namespace Exercicio_1
{
    internal class Program
    {
        const string NullLog = "Digite um valor: ";
        const string ConversionErrorLog = "Valor invalido, tente novamente: ";

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 3 produtos em estoque:");

            Produto[] produtos = new Produto[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Entre com as informações do {i + 1}º produto:");

                Console.Write("Nome: ");
                string nome = IOUtils.NonNullInput(NullLog);

                Console.Write("Preço: ");
                float preco = IOUtils.SecureInput<float>(NullLog, ConversionErrorLog);

                Console.Write("quantidade: ");
                uint quantidade = IOUtils.SecureInput<uint>(NullLog, ConversionErrorLog);

                produtos[i] = new Produto(nome, preco, quantidade);
            }

            float TotalPrice = 0;
            foreach (Produto produto in produtos) TotalPrice += produto.GetStockPrice();

            Console.WriteLine($"O preço total do estoque é {TotalPrice:c2}");
        }
    }
}
