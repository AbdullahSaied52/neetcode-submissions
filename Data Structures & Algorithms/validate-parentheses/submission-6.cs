public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> st=new Stack<char>();
        foreach(char x in s)
        {
            if(x =='['|| x=='('||x=='{')
                st.Push(x);
            else
                if(st.Count>0)
                    {
                        if((st.Peek()=='{'&& x=='}')||(st.Peek()=='('&&x==')')
                    ||(st.Peek()=='['&&x==']'))
                        st.Pop();
                        else
                            return false;
                    }
                else
                    return false;    
        }
        return st.Count==0?true:false;
    }
}
