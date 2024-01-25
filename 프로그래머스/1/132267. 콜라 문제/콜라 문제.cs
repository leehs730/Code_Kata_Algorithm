// 빈명 a개를 가져다 주면 콜라 b병을 준다.
// 빈명 2개를 가져다 주면 콜라 1병을 준다. => 10개는 5병, 5개는 2병, 2개는 1병
using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        // 빈병이 정책의 기준보다 작을 때까지 돌린다
        while(n >= a)
        {
            // 반환 정책에 따라 마신 콜라의 수는 answer로 답하기에
            // 한번 정책을 거치고 나온 콜라의 수를 answer에 더하고
            answer += (b * (n / a));
            // 마시고 남은 빈병의 수는 정책에서 제외된 빈병을 더해야 한다.
            n = (b*(n/a)) + (n % a);
        }
        
        return answer;
    }
}