using OOP3;

ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
ICreditManager transportCredit = new TransportCredit();
ICreditManager housingLoanManager = new HousingLoanManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService= new FileLoggerService();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.Application(personalFinanceCredit,databaseLoggerService);

List<ICreditManager> credits = new List<ICreditManager> { };
//applicationManager.CreditInfo(credits);