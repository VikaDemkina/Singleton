public class Barista
{
    private static Barista instance;

    private Barista()
    {
        // Код инициализации и настройки баристы
    }

    public static Barista GetInstance()
    {
        if (instance == null)
        {
            instance = new Barista();
        }
        return instance;
    }

    public void MakeCoffee(string coffeeType)
    {
        Console.WriteLine("Бариста готовит кофе " + coffeeType);
    }

    public void ServeCustomer(string customerName)
    {
        Console.WriteLine("Бариста обслуживает посетителя " + customerName);
    }
}
