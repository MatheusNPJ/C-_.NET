using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando
            Product mouse = new Product(1, "Mouse gamer", 255.55, Etype.Joia);

            mouse.Name = "Hiro";

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type);

        }
    }

    struct Product
    {

        //Construtor
        public Product(int id, string name, double price, Etype type)
        {
            //Propriedade recebe parâmetro
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        //Propriedades da Struct        
        public int Id;
        public string Name;
        public double Price;
        public Etype Type;

        //Metodo
        public double PriceInDolar(double dolar)
        {
            return dolar * Price;
        }
    }

    enum Etype
    {
        Biju = 1,
        Joia = 2,
        Banhado = 3
    }
}