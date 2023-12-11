public class Solution {
    public string solution(string s) {
        string answer = "";
        int idx = 0;
        if(s.Length % 2 == 0)
        {
            idx = s.Length / 2 - 1;
            answer = s.Substring(idx, 2);
        }
        else
        {
            idx = (s.Length / 2);
            answer = s.Substring(idx, 1);
        }

        return answer;
    }
}