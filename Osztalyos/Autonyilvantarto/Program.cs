
using Autonyilvantarto;

Auto a1 = new Auto("ABC-123", AutoEnum.Ford);
Auto a2 = new Auto("CDC-121", AutoEnum.Fiat);

a1.Megy(2.1);
a1.Megy(2.3);

a2.Megy(8.2);

Console.WriteLine(a1.AtlagFogy());
Console.WriteLine(a2.AtlagFogy());


Console.WriteLine(Auto.Allomany());
