using System.Diagnostics.Metrics;

class Program
{
    // Класс Медіатор, тобто Посередник.
    static void Main(string[] args)
    {
        ManagerMediator mediator = new ManagerMediator();
        User whatsapp = new Messager1(mediator);
        User wechat = new Messager2(mediator);
        User monobank = new Messager3(mediator);
        mediator.Messager1 = whatsapp;
        mediator.Messager2 = wechat;
        mediator.Messager3 = monobank;
        Console.WriteLine("User! Вам надiйшло три сповiщення вiд одного банку! : "); // Так, так можна було реалізувати вибір користувача через ReadLine але я заплутався як((
        whatsapp.Send("У вас закiнчились кошти :(");
        wechat.Send("У вас закiнчились кошти :(");
        monobank.Send("У вас закiнчились кошти :(");

        Console.ReadKey();
    }
}
 
abstract class Mediator
{
    public abstract void Send(string msg, User user);
}
abstract class User
{
    protected Mediator mediator;
 
    public User(Mediator mediator)
    {
        this.mediator = mediator;
    }
 
    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }
    public abstract void Notify(string message);
}

class Messager1 : User
{
    public Messager1(Mediator mediator)
        : base(mediator)
    { }
 
    public override void Notify(string message)
    {
        Console.WriteLine("WhatsApp : " + message);
    }
}

class Messager2 : User
{
    public Messager2(Mediator mediator)
        : base(mediator)
    { }
 
    public override void Notify(string message)
    {
        Console.WriteLine("WeChat : " + message);
    }
}

class Messager3 : User
{
    public Messager3(Mediator mediator)
        : base(mediator)
    { }
 
    public override void Notify(string message)
    {
        Console.WriteLine("MonoBank : " + message);
    }
}
 
class ManagerMediator : Mediator
{
    public User Messager1 { get; set; }
    public User Messager2 { get; set; }
    public User Messager3 { get; set; }
    public override void Send(string msg, User user)
    {
        if (Messager1 == user)
            Messager1.Notify(msg);

        else if (Messager2 == user)
            Messager2.Notify(msg);

        else if (Messager3 == user)
            Messager3.Notify(msg);
    }
}