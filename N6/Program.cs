// 6.	დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოსულ რიცხვს შეამოწმებს 
//არის თუ არა პალინდრომი (არ გამოიყენოთ სტრინგები)
String inp6 = Console.ReadLine();
int num6 = int.Parse(inp6);
int numx = num6;
int digits = 0;
int x = num6;
while (num6 != 0) 
{
    digits++;
    num6 /= 10;
}
int newnum = 0;
while (digits != 0) 
{
    newnum += x % 10 * (int)Math.Pow(10, digits - 1);
    x /= 10;
    digits--;
}
if (numx == newnum)
{
    Console.WriteLine("Is Palindrome");
}
else Console.WriteLine("Is not Palindrome");
