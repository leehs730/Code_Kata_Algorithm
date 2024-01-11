public class Solution {
    public string solution(string s, int n) {
        // 아스키 대문자 65~90
        // 아스키 소문자 97~122
        string answer = "";
        for(int i = 0; i < s.Length; i++)
        {
            char asc_ch = s[i];
            int asc_int = (int)asc_ch;
            if(asc_int == 32) answer += " ";
            if(asc_int >= 65 && asc_int <= 90)
            {
                if(asc_int + n >90)
                {
                    asc_int = asc_int + n - 26;
                    asc_ch = (char)asc_int;
                    answer += asc_ch.ToString();
                }
                else
                {
                    asc_int = asc_int + n;
                    asc_ch = (char)asc_int;
                    answer += asc_ch.ToString();
                }
            }
            if(asc_int >= 97 && asc_int <= 122)
            {
                if(asc_int + n > 122)
                {
                    asc_int = asc_int + n - 26;
                    asc_ch = (char)asc_int;
                    answer += asc_ch.ToString();
                }
                else
                {
                    asc_int = asc_int + n;
                    asc_ch = (char)asc_int;
                    answer += asc_ch.ToString();
                }
            }
        }

        return answer;
    }
}