//3.	კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ 1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი.
Console.WriteLine("Enter Number");
string number = Console.ReadLine();
int NumberInt = int.Parse(number);
int sum = 0;
int multiple = 1;
for (int i = 1; i <= NumberInt; i += 2) 
{
    sum += i;
    multiple *= i;
}
Console.WriteLine($"Sum is {sum} ;");
Console.WriteLine($"Multiple is {multiple} ");
