


using Leszarmazas;

Ember ujember = new Ember();
ujember.Eletkor = 11;
ujember.Mozog(12);

Console.WriteLine(ujember);
ujember.Olvas();

string s = ujember.ToString();
Console.WriteLine(s);


Diak  d1 = new Diak();
Console.WriteLine(d1);
d1.Eletkor = 12;
d1.Olvas();
d1.Mozog(22);
d1.Mozog(66);

Tanar t1 = new Tanar();
Console.WriteLine(t1);
t1.Eletkor = 33;
t1.Olvas();
t1.Mozog(33);
t1.Haladas(44);
t1.Haladas(66);

Auto a = new Auto();
Console.WriteLine(a);
a.Halad(11);
a.Haladas(55);
a.Haladas(66);

Ember kiserletiEmber = t1;
// Tanar kiserletiTanar = ujember;

kiserletiEmber.Olvas();

t1.Tanit();
((Tanar) kiserletiEmber).Tanit();


List<Ember> emberek = new List<Ember>();
emberek.Add(kiserletiEmber);
emberek.Add(ujember);
emberek.Add(d1);
emberek.Add(t1);



foreach (Ember ember in emberek)
{
    ember.Olvas();
}

// ALT + Shift
List<IHaladas> haladok = new List<IHaladas>();
haladok.Add(kiserletiEmber);
haladok.Add(ujember);
haladok.Add(d1);
haladok.Add(t1);
haladok.Add(a);

foreach (IHaladas h in haladok)
{
    h.Haladas(66);
}

