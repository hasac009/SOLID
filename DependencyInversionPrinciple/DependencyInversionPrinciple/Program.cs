// Абстракція сервісу
public interface IDataService
{
    void GetData();
}

// Конкретна реалізація сервісу
public class DatabaseService : IDataService
{
    public void GetData()
    {
        // Логіка отримання даних з бази даних
    }
}

// Високорівневий модуль, який використовує сервіс
public class AppService
{
    private readonly IDataService _dataService;

    public AppService(IDataService dataService)
    {
        _dataService = dataService;
    }

    public void ProcessData()
    {
        _dataService.GetData(); // Виклик методу для отримання даних
        // Додаткові операції обробки даних
    }
}
