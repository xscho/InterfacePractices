// Определение интерфейса
public interface IWrite
{
    void Write();
}

// Реализация интерфейса логгера
public class ConsoleLogger : IWrite
{
    public void Write()
    {
        Console.WriteLine("Hello! I am Writer!");
    }
}

// Мини-калькулятор
public class MiniCalculator
{
    private readonly IWrite _logger;

    public MiniCalculator(IWrite logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        _logger.Write();
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        _logger.Write();
        return a - b;
    }

}

class Program
{
    static void Main(string[] args)
    {
        IWrite logger = new ConsoleLogger();
        MiniCalculator calculator = new MiniCalculator(logger);

        int sum = calculator.Add(5, 3);
        Console.WriteLine($"Sum: {sum}");

        int difference = calculator.Subtract(5, 3);
        Console.WriteLine($"Difference: {difference}");
    }
}
