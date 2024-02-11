// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 100000.5;


// variables --> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);


//condition
if (isAuthenticated == true)
{
    Console.WriteLine("Button --> Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Button --> sisteme giriş yap");
}

string[] loans = {"kredi1","kredi2","kredi3","kredi4", "kredi5", "kredi6" };

//string[] loans2 = new string[6];
//loans2[0] = "kredi1";


        //start     condition   //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(i+" "+loans[i]);
}

CourseManager courseManager = new();

courseManager.GetAll();

Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678901";
customer1.FirstName = "Özgür";
customer1.LastName = "AY";
customer1.CustomerNumber = "123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678901";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "583212";
customer3.TaxNumber = "12345678212";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "111111";
customer4.TaxNumber = "12345678987";

int number1 = 10;
int number2 = 30;
number1 = number2;

number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Yalova" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

                              //101       102        103        104
BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };


//polymorphism
foreach(BaseCustomer customer in customers)
{

    Console.WriteLine(customer.CustomerNumber);
}