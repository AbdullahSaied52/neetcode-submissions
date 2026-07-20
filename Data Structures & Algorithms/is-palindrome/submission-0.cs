public class Solution {
    public bool IsPalindrome(string s) 
    {
        s=s.Replace(" ","");
        int y=s.Length-1;
        for(int i=0;i<s.Length;i++)
        {
            if(char.IsLetterOrDigit(s[i]))
                if(char.IsLetterOrDigit(s[y]))
                    if(char.ToLower(s[i])==char.ToLower(s[y]))
                        y--;
                    else
                        return false;
                else
                    {
                        y--;
                        i--;
                    }

        }
        return true;
    }
}
