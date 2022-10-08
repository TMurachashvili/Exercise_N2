// 13.	დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიყვანს ტექსტ და დაითვლის ტექსტში სიტყვების რაოდენობას. 
//(პუნქტუაციური ნიშნების რაოდენობას, და მაღალი და დაბალი რეგისტრის სიმბოლოებს)
Console.WriteLine("Enter string");
string input13 = Console.ReadLine();
int words = 1;
int lowercase =0, uppercase =0, punct = 0;
for(int i=0; i< input13.Length; i++)
{
    if (char.IsWhiteSpace(input13[i])) { words++; }
    if (char.IsLower(input13[i])) { lowercase++; }
    if (char.IsUpper(input13[i])) { uppercase++; }
    if (char.IsPunctuation(input13[i])) { punct++; }
}
Console.WriteLine($"Words - {words}");
Console.WriteLine($"LowerCase Letters - {lowercase}");
Console.WriteLine($"UpperCase Letters - {uppercase}");
Console.WriteLine($"Punctuation symbols - {punct}");