namespace Arrays.ConsoleApp
{
    internal class Program
    {
        static int[] listaOriginal = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
        static int[] listaOrdenada;
        static void Main(string[] args)
        {
            
            while (true)
            {
                listaOrdenada = new int[listaOriginal.Length];
                Array.Copy(listaOriginal, listaOrdenada, listaOriginal.Length);
                Array.Sort(listaOrdenada);

                int menu = Menu();
                switch (menu) {
                    case 0:
                        break;
                    case 1:
                        Ex1();
                        break;
                    case 2:
                        Ex2();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 7:
                        Console.Clear();
                        break;
                }
                if (menu == 0)
                {
                    break;
                }
                else if (menu > 7) Console.WriteLine("Numero invalido!!!");
                

            }
        }

        static int Menu()
        {
            Console.WriteLine("****************************************\nMenu\n");
            Console.WriteLine("Digite 1 para Encontrar o Maior Valor da sequência\n" +
                "Digite 2 para Encontrar o Menor Valor da sequência\n" +
                "Digite 3 para Encontrar os 3 maiores valores da sequência\n" +
                "Digite 4 para Encontrar os valores negativos da sequência\n" +
                "Digite 5 para Mostrar na Tela os valores da sequência\n" +
                "Digite 6 para Remover um item da sequência\n" +
                "Digite 7 para limpar o console\n"+
                "Digite 0 para Sair");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
        static void Ex1()
        {
            Console.WriteLine($"\nO Maior Valor é de {listaOrdenada.Last()}\n");
        }
        static void Ex2()
        {
            Console.WriteLine($"\nO Menor Valor é de {listaOrdenada.First()}\n");
        }
        static void Ex3()
        {
            int[] listaOrdenadaReversa = listaOrdenada.ToArray();
            Array.Reverse( listaOrdenadaReversa );
            Console.Write($"\nOs 3 Maiores Valores São:");
            for ( int i = 0; i < 3;i++ )
            {
                Console.Write($" {listaOrdenadaReversa[i]}");
            }
            Console.WriteLine(";\n");
        }
        static void Ex4()
        {
            Console.Write("\nEstes são os numeros negativos:");
            foreach (var n in listaOrdenada)
            {
                if (n < 0)
                {
                    Console.Write($" {n}");
                }
            }
            Console.WriteLine(";\n");
        }
        static void Ex5()
        {
            Console.Write("\nEstes são os atuais valores da lista:");
            foreach (var n in listaOriginal)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine(";\n");
        }
        static void Ex6()
        {
            Ex5();
            Console.WriteLine("Infome qual valor voce quer excuir:");
            int aux = Convert.ToInt32(Console.ReadLine());
            int[] novoLista = new int[listaOriginal.Length - 1];
            int indexNovoArray = 0;
            foreach (int item in listaOriginal)
            {
                if (item != aux)
                {
                    novoLista[indexNovoArray] = item;
                    indexNovoArray++;
                }
            }
            listaOriginal = novoLista;
            Ex5();
        }
    }
}
