string f10 = "abcabcabcabcdefabcdef";

M10(f10);

static void M10(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if ((i + 1) % 3 == 0 || (i + 1) % 5 == 0)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(s[i]);
        }

    }
}

Console.WriteLine("------");

