//2.	დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს რიცხვს n-ს და დაბეჭდავს 1-დან n მდე რიცხვებს ისე როგორც სურათზეა(სურ 1).(თითო ხაზზე ელემენტების რაოდენობა იზრდება 1-ით)
Console.WriteLine("enter a number");
string inputnum = Console.ReadLine();
int num = int.Parse(inputnum);
int numinrow = 1;
int i = 1;
while (i <= num)
{
    for (int counter = 1; counter <= numinrow; counter++)
    {
        Console.Write($" {i++} ");
    }
    Console.WriteLine();
    numinrow++;
}
