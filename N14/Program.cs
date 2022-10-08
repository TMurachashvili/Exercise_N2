//14.	დაწერეთ პროგრამა რომელიც ტექსტში დაითვლის ხმოვნებს/თანხმოვნებს.
string input14 = Console.ReadLine();
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
int SumVowels = 0;
int LettersNum = 0;
for (int i = 0; i < input14.Length; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if(char.ToLower(input14[i]) == vowels[j]) { SumVowels++; }
    }
    if(char.IsLetter(input14[i])) { LettersNum++; }
}
Console.WriteLine($"N of Vowels : {SumVowels}");
Console.WriteLine($"N of Consonants : {LettersNum -SumVowels}");