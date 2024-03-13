namespace CalculadoraCSharp.Modules;

public class AdditionModule : CalculatorModule
{
    public void Add()
    {
        Console.Clear();

        GetValues();

        ShowResult(FirstValue + SecondValue);

        Continue();
    }
}
