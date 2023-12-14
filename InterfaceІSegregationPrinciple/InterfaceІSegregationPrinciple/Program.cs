// Приклад великого інтерфейсу, який не дотримується принципу розділення інтерфейсу
public interface IWorker
{
    void work();
    void eat();
    void sleep();
    void takeVacation();
    // ...
}




// Розділення на більш специфічні інтерфейси
public interface IWorker
{
    void work();
}

public interface IEater
{
    void eat();
}

public interface ISleeper
{
    void sleep();
}

public interface IVacationer
{
    void takeVacation();
}