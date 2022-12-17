using System.Globalization;

namespace CalculoMediaComVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira quantos produtos serão adicionados: ");
            int n = int.Parse(Console.ReadLine());
            
            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                vect[i] = new Product { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("Média de preço dos produtos: " + media.ToString("F2", CultureInfo.InvariantCulture));
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto : {0} | Preço: {1} ", vect[i].Nome, vect[i].Preco);
                
            }
        }
    }
}