

using ComputerRegister;

Laptop l1 = new Laptop(16, "Intel", 2022, 16, 2.5);
Laptop l2 = new Laptop(32, "Intel", 2023, 16, 2.2);

Desktop d1 = new Desktop(16, "AMD", 2020, new int[3] {25, 40, 55});



Console.WriteLine("Computer Register");

Console.WriteLine("L1 laptop: " + l1.ToString());
Console.WriteLine("L2 laptop: " + l2.ToString());

Console.WriteLine("D1 desktop: " + d1.ToString());

