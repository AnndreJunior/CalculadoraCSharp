namespace CalculadoraCSharp.Modules;

public class MultiplicationModule : CalculatorModule
{
    public void Multiply()
    {
        Console.Clear();

        GetValues();

        ShowResult(FirstValue * SecondValue);

        Continue();
    }
}
