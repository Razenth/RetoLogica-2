internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Iniciar programa");
        System.Console.Write("Si(Y) / No(N): ");
        string option = Console.ReadLine().ToUpper();
        switch (option)
        {
            case "Y":
                Console.Clear();
                System.Console.Write("Ingrese Multiplicador: ");
                int multiplicador = int.Parse(Console.ReadLine());
                int mayor = multiplicador;
                int menor = 0;
                System.Console.Write("Ingrese Multiplicando: ");
                int multiplicando = int.Parse(Console.ReadLine());
                if (multiplicando > multiplicador)
                {
                    mayor = multiplicando;
                    menor = multiplicador;
                }
                else
                {
                    menor = multiplicando;
                }
                List<int> list = new List<int>();
                bool flag = true;
                while (flag)
                {
                    if (mayor == 1){
                        list.Add(menor);
                        flag = false;
                    }
                    else if(mayor % 2 != 0)
                    {
                        list.Add(menor);
                    }
                    mayor = mayor / 2;
                    menor = menor * 2;
                }
                System.Console.WriteLine("Resultado: {0}",list.Sum());
                break;
        }
        System.Console.WriteLine("Presione enter para terminar el programa");
        Console.ReadLine();
    }
}