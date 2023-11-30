public class Solution {
    public long solution(int a, int b) {
        int tmp = 0;
        long sum = 0;
        if(a>b)
        {
            tmp = b;
            b = a;
            a = tmp;
        }
        for(int i = a; i <= b; i++)
        {
            sum += i;
        }
        long answer = 0;
        answer = sum;
        return answer;
    }
}