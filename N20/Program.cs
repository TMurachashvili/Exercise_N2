// Print the corrected word s. If the given word s has strictly more uppercase letters, 
//make the word written in the uppercase register, otherwise - in the lowercase one.
//Exercise 20
string str20 = Console.ReadLine();
int low = 0;
int upp = 0;
for (int i = 0; i <= str20.Length - 1; i++)
{
    if (char.IsUpper(str20[i]))
    {
        upp++;
    }
    else if (char.IsLower(str20[i]))
    {
        low++;
    }

}
if (low >= upp)
{
    Console.WriteLine(str20.ToLower());
}
else Console.WriteLine(str20.ToUpper());

