/*
char[] DuplicateCharacters( string testString ) returns an array of all characters that appear more than once in a string. 

For example, the argument “Programmatic Python” would return “[p,r,o,a,m,t]”. */

DuplicateCharacters("aabbbbcdd");

char[] DuplicateCharacters(string testString)
{
    char[] testChars = testString.ToLower().ToCharArray();
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach(char character in testChars)
    {
        if (charCount.ContainsKey(character))
        {
            charCount[character] = charCount[character] + 1;
        } else
        {
            charCount.Add(character, 1);
        }
    }

    char[] duplicateChars = new char[charCount.Count];
    int dupeCount = 0;

    foreach(KeyValuePair<char, int> pair in charCount)
    {
        if(pair.Value > 1)
        {
            duplicateChars[dupeCount] = pair.Key;
            dupeCount++;
        } else
        {
            Array.Resize(ref duplicateChars, duplicateChars.Length - 1);
        }
    }

    return duplicateChars;
}