using System;

// Приклад класу, що відповідає за роботу з користувачами
// Цей клас відповідає тільки за роботу з користувачами
public class UserManager
{
    private UserRepository userRepository;

    public UserManager()
    {
        // Ініціалізація репозиторію користувачів
        this.userRepository = new UserRepository();
    }

    // Метод для створення нового користувача
    public void CreateUser(string username, string email)
    {
        // Виклик методу репозиторію для створення користувача в базі даних
        userRepository.SaveUserToDatabase(username, email);

        
    }

    // Метод для видалення користувача
    public void DeleteUser(int userId)
    {
        // Виклик методу репозиторію для видалення користувача з бази даних
        userRepository.DeleteUserFromDatabase(userId);

       
    }
}

// Приклад класу репозиторію для роботи з базою даних користувачів
public class UserRepository
{
    // Метод для збереження користувача в базі даних
    public void SaveUserToDatabase(string username, string email)
    {
        // Логіка збереження користувача в базі даних
        Console.WriteLine($"Saving user {username} with email {email} to the database");
    }

    // Метод для видалення користувача з бази даних
    public void DeleteUserFromDatabase(int userId)
    {
        // Логіка видалення користувача з бази даних
        Console.WriteLine($"Deleting user with ID {userId} from the database");
    }
}