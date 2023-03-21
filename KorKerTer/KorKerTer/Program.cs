
Console.WriteLine("Kérem egy kör sugarát (egész számot):");

int r = 0;


while (!int.TryParse(Console.ReadLine(), out r))
{
    Console.WriteLine("Nem jó szám, másikat kérek!");

}



//if (int.TryParse(Console.ReadLine(), out r))
//{
//    Console.WriteLine("Sikeres parsolás");
//}
//else
//{
//    Console.WriteLine("Sikertelen parsolás");
//}



// r = int.Parse(Console.ReadLine());


double ker = 2 * r * Math.PI;
double ter = Math.Pow(r, 2) * Math.PI;

Console.WriteLine(ker);
Console.WriteLine(ter);

