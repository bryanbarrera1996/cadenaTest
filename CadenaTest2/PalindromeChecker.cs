using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PalindromeChecker
{
    public bool IsPalindrome(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;
        
        string cleaned = Normalize(text);
        return cleaned.SequenceEqual(cleaned.Reverse());
    }

    private string Normalize(string text)
    {
        return Regex.Replace(text.ToLower(), "[^a-z0-9]", "");
    }
}