namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA TREINAMENTE JEDI!\n");
            Console.WriteLine("Insira seu número de horas de treino por dia: ");

            float HoursPerDay = InputFloat("Número inválido, tente denovo: ", 0, 24);
            float HoursPerWeek = HoursPerDay * 5; // desconsidera sabadão e domingão
            float HoursPerMonth = HoursPerWeek * 4.5f;

            Quotient RemainingMonths = new(1000, HoursPerMonth);
            Quotient RemainingWeeks = new(RemainingMonths.Remainder, HoursPerWeek);
            float RemainingHours = RemainingWeeks.Remainder / HoursPerDay;

            Console.WriteLine($"Para alcançar 1000 horas de treino, a {HoursPerDay} horas por dia, você precisa treinar por {RemainingMonths.Result} mêses," +
                $" {RemainingWeeks.Result} semanas," +
                $" e {RemainingHours.ToString("F2")} dias.");
            Console.ReadKey();
        }

        static float InputFloat(string errorLog, float? min = null, float? max = null)
        {
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out float output) &&
                    (min is null || output > min) &&
                    (max is null || output <= max))
                {
                    return output;
                }
                Console.WriteLine(errorLog);
            }
        }

        internal struct Quotient
        {
            public Quotient(float dividend, float divisor)
            {
                this.Result = (long)(dividend / divisor);
                this.Remainder = dividend % divisor;
            }
            public long Result { get; set; }
            public float Remainder { get; set; }
        }
    }
}
