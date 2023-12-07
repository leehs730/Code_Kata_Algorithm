using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        answer = my_string.Remove(s, overwrite_string.Length);
        answer = answer.Insert(s, overwrite_string);
        /***
        char[] myArray = my_string.ToCharArray();
        char[] overArray = overwrite_string.ToCharArray();
        for(int i = 0; i < overwrite_string.Length; i ++)
        {
            myArray[s+i] = overArray[i];
        }
        answer = new string(myArray);
        ***/
        return answer;
    }
}