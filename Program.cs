
class PrimeiroProjeto
{
    public static void Main(string[] args)
    {
        string nome = "Gabriel"; //Comentario de uma linha
        Console.WriteLine("Digite seu nome: "); // Exibe uma mensagem no console
        nome = Console.ReadLine();
        Console.WriteLine("Digite um número");
        int num = int.Parse(Console.ReadLine()); // Lê um número inteiro do console
        Console.WriteLine("O número digitado foi: " + num); // Exibe o número lido
        Console.WriteLine("Olá " + " " + nome);  // Concatenação
        Console.WriteLine("Digite qualquer coisa para sair");
        Console.ReadLine();

        //Exercicio

        Console.WriteLine("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 % num2 == 0)
        {
            Console.WriteLine("O número " + num1 + " é par" + num2);
        }
        else
        {
            Console.WriteLine("O número " + num1 + " é impar" + num2);
        }

        Console.WriteLine("Receber um valor de um saque e calcule quantas notas o caixa eletronico deve devolver(Considere apenas notas de 100, 50, 10, 5, 2)");
        Console.WriteLine("Digite o valor do saque: ");
        int saque = int.Parse(Console.ReadLine());
        int notas100 = saque / 100;
        saque %= 100;
        int notas50 = saque / 50;
        saque %= 50;
        int notas10 = saque / 10;
        saque %= 10;
        int notas5 = saque / 5;
        saque %= 5;
        int notas2 = saque / 2;
        Console.WriteLine("Notas de 100: " + notas100);
        Console.WriteLine("Notas de 50: " + notas50);
        Console.WriteLine("Notas de 10: " + notas10);
        Console.WriteLine("Notas de 5: " + notas5);
        Console.WriteLine("Notas de 2: " + notas2);

    }
}