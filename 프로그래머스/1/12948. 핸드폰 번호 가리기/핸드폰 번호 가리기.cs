public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        int length = phone_number.Length - 4;
        answer = phone_number.Substring(length, 4);
        for(int i = 0; i < length; i++)
        {
            answer = "*" + answer;   
        }
        return answer;
    }
}