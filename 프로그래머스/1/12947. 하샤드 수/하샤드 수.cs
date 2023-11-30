public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int tmp = x;
        while(tmp > 10)
        {
            sum += tmp%10;
            tmp = tmp/10;
        }
        sum += tmp;
        bool answer = true;
        if(x % sum != 0) answer = false;
        return answer;
    }
}