using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new Logger();
        IDatabase database = new PostgresDataBase(logger);
        IMessageService emailService = new EmailService(logger, database);
        NotificationService notificationService = new NotificationService(emailService);
        IMessageService telegramService = new TelegramService();
        NotificationService notification = new NotificationService(telegramService);
        notificationService.Notify();
        notification.Notify();
        Console.ReadKey();
    } 
}

class NotificationService
{
    private readonly IMessageService _MessageService;
    public NotificationService(IMessageService messageService)
    {
        _MessageService = messageService;
    }
    public void Notify()
    {
        _MessageService.SendMessage(" ассалам алекум ");
    }
    public void NotifyAll()
    {
        _MessageService.SendMessage(" ассалам алекум ");
    }
}
interface IMessageService
{
    void SendMessage(string message);
}


class EmailService : IMessageService
{
    private readonly ILogger _logger;
    private readonly IDatabase _database;

    public EmailService(ILogger logger, IDatabase database)
    {
        _logger = logger;
        _database = database;
    }
    public void SendMessage(string Message)
    {
        Console.WriteLine("Email" + Message);

        _database.Save();
        _logger.log("сообщение доставлено email");
    }
}
class TelegramService : IMessageService
{
    public void SendMessage(string Message)
    {
        Console.WriteLine("telegram" + Message);
    }
}
public class Logger : ILogger
{
    public void log(string message)
    {
        Console.WriteLine(message);
    }
}
public class PostgresDataBase : IDatabase
{
    private readonly ILogger _logger;
    public PostgresDataBase(ILogger logger)
    {
        _logger = logger;
    }

    public void Save()
    {
        Console.WriteLine("данные сохранены");
        _logger.log("успешно");
    }
}