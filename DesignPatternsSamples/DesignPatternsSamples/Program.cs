using DesignPatternsSamples.AbstractFactory;
using DesignPatternsSamples.Builder;
using DesignPatternsSamples.ChainOfResponsibility;
using DesignPatternsSamples.ChainOfResponsibility.Logger;
using DesignPatternsSamples.Factory;
using DesignPatternsSamples.Flyweight;
using DesignPatternsSamples.Kompozyt;
using DesignPatternsSamples.Kompozyt.FileSystem;
using DesignPatternsSamples.Mediator;
using DesignPatternsSamples.Memento;
using DesignPatternsSamples.Memento.FileMemento;
using DesignPatternsSamples.NullObject;
using DesignPatternsSamples.ObjectPool;
using DesignPatternsSamples.Observer.AccountObserver;
using DesignPatternsSamples.Prototype;
using DesignPatternsSamples.State;
using DesignPatternsSamples.Strategy;
using System;

namespace DesignPatternsSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileOperationFactory.GetFileOperation("FTP").DeleteFile(String.Empty);
            //FileOperationFactory.GetFileOperation("FILESYSTEM").DeleteFile(String.Empty);

            //CommunicationFactoryCreator.GetCommunicationFactory(true).GetFTPCommunication(true).DownloadFile(String.Empty);
            //CommunicationFactoryCreator.GetCommunicationFactory(true).GetFTPCommunication(false).DownloadFile(String.Empty);
            //CommunicationFactoryCreator.GetCommunicationFactory(false).GetFTPCommunication(null).DownloadFile(String.Empty);

            //var prototype = new LogoBitmapPrototype();

            //var logoForPdf = prototype.Clone();
            //var logoForWeb = prototype.Clone();

            //EnvironmentBuilder environmentBuilder = new EnvironmentBuilder();
            //environmentBuilder.SetEnvironmentName("PROD")
            //    .SetNotificationMail("prod@example.com")
            //    .SetLogLevel(LogLevel.Error)
            //    .Build();

            /*System.Threading.ThreadPool.SetMinThreads(2, 2);
            System.Threading.ThreadPool.SetMaxThreads(4, 4);
            Action threadSleep = () =>
            {
                var threadGuid = Guid.NewGuid();
                Console.WriteLine($"{threadGuid.ToString()} START");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine($"{threadGuid.ToString()} END");
            };
            for (int i = 0; i < 60; i++)
            {
                System.Threading.ThreadPool.QueueUserWorkItem((state)=>threadSleep());
            }*/
            //IpAddressPool ipAddressPool = new IpAddressPool();
            //Action ipAddressWork = () =>
            //{
            //    var ip = ipAddressPool.GetAddressFromPool();
            //    Console.WriteLine("GET IP " + ip);
            //    System.Threading.Thread.Sleep(5000);
            //    //ipAddressPool.ReturnIPToPool(ip);
            //    //Console.WriteLine("RETURN IP " + ip);
            //};

            //var rnd = new Random();
            //for (int i = 0; i < 5000; i++)
            //{
            //    //System.Threading.Thread.Sleep(rnd.Next(500,2000));
            //    var thread = new System.Threading.Thread(() => ipAddressWork());
            //    thread.Start();
            //    //System.Threading.ThreadPool.QueueUserWorkItem((state) => ipAddressWork());
            //}

            //FlyweightCache flyweightCache = new FlyweightCache();
            //var result = flyweightCache.GetPDFDocument("umowa.pdf");
            //Console.WriteLine(result.Content);
            //result = flyweightCache.GetPDFDocument("umowa1.pdf");
            //Console.WriteLine(result.Content);
            //result = flyweightCache.GetPDFDocument("umowa.pdf");
            //Console.WriteLine(result.Content);
            //result = flyweightCache.GetPDFDocument("umowa2.pdf");
            //Console.WriteLine(result.Content);
            //result = flyweightCache.GetPDFDocument("umowa1.pdf");
            //Console.WriteLine(result.Content);

            //TextPartFlyweight textPartFlyweight = new TextPartFlyweight();
            //Text text = new Text();
            //for (int i = 0; i < 100; i++)
            //{
            //    //TextFooter textFooter = new TextFooter();
            //    //TextHeader textHeader = new TextHeader();

            //    Page page = new Page()
            //    {
            //        Footer = textPartFlyweight.GetTextPart("FOOTER"),
            //        Header = textPartFlyweight.GetTextPart("HEADER"),
            //        Content = "Page " + 1
            //    };
            //    text.Pages.Add(page);
            //}
            //Console.WriteLine("FINISH");
            //var rateCalculator = new RateCalculator();
            //var product1 = new Product() { Price = 100 };
            //Console.WriteLine(rateCalculator.GetMonthRate(10, product1));

            //var product2 = new Product() { Price = 200 };
            //ShopingCart shopingCart = new ShopingCart();
            //shopingCart.Products.Add(product1);
            //shopingCart.Products.Add(product2);

            //Console.WriteLine(rateCalculator.GetMonthRate(10, shopingCart));

            /*File file = new File() { Path = Environment.CurrentDirectory + "/dir1/file1.txt" };
            File file2 = new File() { Path = Environment.CurrentDirectory + "/dir1/dir2/file2.txt" };
            File file3 = new File() { Path = Environment.CurrentDirectory + "/dir1/dir2/file3.txt" };

            Folder folder = new Folder() { Path = Environment.CurrentDirectory + "/dir1/dir2/" };
            folder.Files.Add(file2);
            folder.Files.Add(file3);

            var rootFolder = new Folder() { Path = Environment.CurrentDirectory + "/dir1/" };
            rootFolder.Files.Add(folder);
            rootFolder.Files.Add(file);

            //rootFolder.Create();
            rootFolder.Delete();*/
            /*var president = new PresidentLeaveApprover();
            var director = new DirectorLeaveApprover();
            director.SetSuperior(president);
            var manager = new ManagerLeaveApprover();
            manager.SetSuperior(director);
            var worker = new WorkerLeaveApprover();
            worker.SetSuperior(manager);

            Console.WriteLine(worker.ApproveLeave(Position.President));*/

            /*var errorLogger = new ErrorLogger();
            var warningLogger = new WarningLogger();
            warningLogger.SetHigherLogger(errorLogger);
            var debugLogger = new DebugLogger();
            debugLogger.SetHigherLogger(warningLogger);

            debugLogger.Log(new Exception("Błąd krytyczny!"), ChainOfResponsibility.Logger.LogLevel.Error);
            debugLogger.Log(new Exception("Błąd małokrytyczny"), ChainOfResponsibility.Logger.LogLevel.Debug);
            */
            /*
            ISaleStrategy saleStrategy;
            DateTime today = new DateTime(2018, 11, 26);

            if (today == new DateTime(2018, 11, 23))
            {
                saleStrategy = new BlackFridayStrategy();
            }
            else if (today == new DateTime(2018, 11, 26))
            {
                saleStrategy = new CyberMondayStrategy();
            }
            else
            {
                saleStrategy = new BaseSaleStrategy();
            }

            Strategy.Product product = new Strategy.Product(saleStrategy);
            product.Price = 100;
            product.Count = 10;
            Console.WriteLine(product.GetTotalPrice());*/

            //MementoUsage.Run();
            /*Memento.FileMemento.Originator originator = new Memento.FileMemento.Originator();
            FileCareTaker fileCareTaker = new FileCareTaker();
            originator.Path = Environment.CurrentDirectory + "/test.txt";
            var state1 = originator.SaveState();
            fileCareTaker.Add(state1);

            Console.ReadKey();
            var state2 = originator.SaveState();
            fileCareTaker.Add(state1);

            var rev0State = fileCareTaker.Get(0);
            originator.LoadState(rev0State);*/

            /*var accountSubject = new AccountSubject();
            var lowBalanceObserver = new LowBalanceObserver(accountSubject);
            var creditBalanceObserver = new CreditBalanceObserver(accountSubject);
            accountSubject.Attach(lowBalanceObserver);
            accountSubject.Attach(creditBalanceObserver);

            accountSubject.SetBalance(200);
            accountSubject.SetBalance(80);
            accountSubject.SetBalance(-10);*/

            /*var communication = CommunicationFactory.GetInstance("FTP");
            communication.SaveFile("", "");

            communication = CommunicationFactory.GetInstance("SFTP");
            communication.SaveFile("", "");*/

            /*var mediator = new ChatMediator();

            var joe = new WebChatUser(mediator) { Nickname = "Joe" };
            var ann = new WebChatUser(mediator) { Nickname = "Ann" };
            var jack = new WebChatUser(mediator) { Nickname = "Jack" };

            mediator.AddUser(joe);
            mediator.AddUser(ann);
            mediator.AddUser(jack);

            joe.Send("Cześć");
            ann.Send("Skont jestes?");
            jack.Send("Z pomoża");*/

            Account acc = new Account();
            acc.Withdraw(100);
            acc.Withdraw(100);

            Console.ReadKey();
        }
    }
}
