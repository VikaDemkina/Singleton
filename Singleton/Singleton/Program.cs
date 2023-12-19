public class Program
{
    public static void Main(string[] args)
    {
        // Получение экземпляра баристы
        Barista barista = Barista.GetInstance();

        // Вызов методов и функциональности баристы
        barista.MakeCoffee("Фисташковый Раф");
        barista.ServeCustomer("Виктория");
    }
}