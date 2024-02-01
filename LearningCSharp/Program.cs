// Learning C#

using System.ComponentModel;

int escolha;


do
{
    Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");

    Console.WriteLine("Escolha uma das opções:");
    Console.WriteLine("[1] Soma");
    Console.WriteLine("[2] Subitração");
    Console.WriteLine("[3] Multiplicação");
    Console.WriteLine("[4] Divisão");
    Console.WriteLine("[0] Sair");
    escolha = Convert.ToInt32( Console.ReadLine());


    Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");



    switch (escolha)
    {
        case 1:
            Console.WriteLine("------------Soma------------");
            Console.WriteLine("Digite o primeiro valor:");
            int Value01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int Value02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado ({Value01} + {Value02}): {Value01 + Value02}");
            break;

        case 2:
            Console.WriteLine("------------Subitração------------");
            Console.WriteLine("Digite o primeiro valor:");
            int Value03 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int Value04 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado ({Value03} - {Value04}): {Value03 - Value04}");
            break;

        case 3:
            Console.WriteLine("------------Multiplicação------------");
            Console.WriteLine("Digite o primeiro valor:");
            int Value05 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int Value06 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado ({Value05} x {Value06}): {Value05 * Value06}");
            break;
        case 4:
            Console.WriteLine("------------Divisão------------");
            Console.WriteLine("Digite o primeiro valor:");
            double Value07 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double Value08 = Convert.ToInt32(Console.ReadLine());

            double resultado =  Value07 / Value08;

            Console.WriteLine($"Resultado ({Value07} / {Value08}): {resultado}");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }
}
while (escolha != 0);
