// 5.	დაწერეთ პროგრამა რომელიც შეამოწმებს არის თუ არა სტრინგი პალინდრომი.
//(პალინდრომია სტრინგი თუ ის შებრუნებული სახითაც იგივენაირად იკითხება) asdffdsa
Console.WriteLine("Enter string");
string input = Console.ReadLine();
bool isPalindrome = true;
for (int i = 0; i < input.Length / 2; i++)
{
    if (input[i] != input[input.Length - 1 - i]) 
    {   isPalindrome = false;
        Console.WriteLine("Your Input Is not Palindrome");
        break; 
    }
}
if (isPalindrome)
{
    Console.WriteLine("Your Input is Palindrome");
}
