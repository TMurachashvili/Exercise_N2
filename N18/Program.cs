//A. String Task
/*Petya started to attend programming lessons. On the first lesson his task was to write a simple program. The program was supposed to do the following: in the given string, consisting if uppercase and lowercase Latin letters, it:
deletes all the vowels,
inserts a character "." before each consonant,
replaces all uppercase consonants with corresponding lowercase ones.
Vowels are letters "A", "O", "Y", "E", "U", "I", and the rest are consonants. The program's input is exactly one string, it should return the output as a single string, resulting after the program's processing the initial string.
 */
Console.WriteLine("Enter String");
string inp18 = Console.ReadLine();
string lowstr = inp18.ToLower();
for (int i = 0; i < lowstr.Length; i++)
{
    if (lowstr[i] == 'a' || lowstr[i] == 'o' || lowstr[i] == 'y' || lowstr[i] == 'e' || lowstr[i] == 'u' || lowstr[i] == 'i') { continue; }
    else Console.Write("." + lowstr[i]);
}