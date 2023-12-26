public class Solution {
    public bool solution(string s) {
        int i = 0;
        bool answer = false;
        if(s.Length == 4 || s.Length == 6) answer = int.TryParse(s, out i);
        return answer;
    }
}