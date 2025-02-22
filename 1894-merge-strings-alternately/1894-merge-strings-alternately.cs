public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
         string result = string.Empty;
    string maxString = word1.Length > word2.Length ? word1 : word2;
    string minString = word1.Length > word2.Length ? word2 : word1;

    for (int i = 0; i < maxString.Length; i++)
    {
        if (minString.Length > i)
        {
            result += word1[i].ToString() + word2[i].ToString();
        }
        else
        {
            result += maxString[i];
        }
    }

    return result;
    }
}