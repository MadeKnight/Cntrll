public static class Controller
{
    private static IFix homeworks;
    static void Main()
    {
        Tasker(5);
    }

    static void Tasker(int task)
    {
        switch (task)
        {
            case 1:
                homeworks = new HomeWork1();
                break;
            case 2:
                homeworks = new HomeWork2();
                break;
            case 3:
                homeworks = new HomeWork3();
                break;
            case 4:
                homeworks = new HomeWork4();
                break;
            case 5:
                homeworks = new HomeWork5();
                break;
        }

        homeworks.Start();
    }
}

public interface IFix
{
    void Start();
}

public abstract class BaseRoom : IFix
{
    public abstract void Start();
}
