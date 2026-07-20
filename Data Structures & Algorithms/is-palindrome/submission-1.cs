public class Solution {
    public bool IsPalindrome(string s) 
    {
        s=s.Replace(" ","");
        string y="";
        foreach(char x in s)
        {
            if(char.IsLetterOrDigit(x))
                y+=char.ToLower(x);
        }
        return new string(y.Reverse().ToArray())==y;
    }
}
