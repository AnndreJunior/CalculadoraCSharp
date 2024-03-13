namespace CalculadoraCSharp.Modules;

public static class MainMenuModule
{
    public static void MainMenu()
    {
        Console.Clear();

        Console.WriteLine("Olá meu caro ser! Escolha uma operação:\n");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Sair");
        Console.WriteLine("---------------------------------------");
        Console.Write("Opção: ");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                new AdditionModule().Add();
                MainMenu();
                break;
            case 2:
                new SubtractionModule().Subtract();
                MainMenu();
                break;
            case 3:
                new MultiplicationModule().Multiply();
                MainMenu();
                break;
            case 4:
                new DivisionModule().Divide();
                MainMenu();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                MainMenu();
                break;
        }
    }
}
