string uzivateldobre = "negr";
string heslodobre = "negrnegr";

Console.WriteLine("zadej uziv jsmeno");
string uzivatel = (Console.ReadLine());
Console.WriteLine("zadej heslo");
string heslo = (Console.ReadLine());

if (uzivatel == uzivateldobre && heslo == heslodobre)
{
    Console.WriteLine("vítejte");
}
else
{
    Console.WriteLine("ses pica a mas tam spatny heslo");
}