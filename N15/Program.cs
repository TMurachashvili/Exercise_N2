//15.	დაწერეთ პროგრამა რომელიც იპოვნის ტექსტი შეიცავს თუ არა   substring-ს 
//(მაგ: some text    შეიცავს ext-ს ? შეიცავს!)
Console.WriteLine("Enter Text");
string text = Console.ReadLine();
Console.WriteLine("Enter Substring");
string substr = Console.ReadLine();
if (text.Contains(substr))
{
    Console.WriteLine(" Text contains this substring");
}
else Console.WriteLine("Text doesn't contains this substring");
