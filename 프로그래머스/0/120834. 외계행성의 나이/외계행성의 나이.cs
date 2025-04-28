using System;

// 풀이방법 : 숫자들을 숫자로 분리 후 char로 변환 
//         -> 숫자를 아스키 코드의 영소문자로 변환해야 함
//         -> 소문자 까지의 값은 47 (='a')부터
public class Solution {
    public string solution(int age) {
        string answer = "";
        while(age>0)
        {
            char c = (char)((age%10)+97);
            answer = c.ToString() + answer;
            age /= 10;
        }
        
        
        
        return answer;
    }
}