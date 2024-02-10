using System.Globalization;

namespace ConsoleTernario{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, desconto;
            Console.Write("Informe o prelo para obter o desconto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else {
            //    desconto = preco * 0.05;
            //}

            desconto  = (preco < 20.0) ? preco * 0.1 : preco * 0.05; /// Usando IF Ternário
            Console.WriteLine("Desconto é: " +desconto.ToString("F2",CultureInfo.InvariantCulture));
        }
    }

}