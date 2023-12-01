public class Solution {
    public int solution(int num) {
        long tmp = num;
        int cnt = 0;
        do{
            if(tmp == 1 ) break;
            else
            {
                if( cnt > 500) {
                    cnt = -1;
                    break;
                }
                else if( tmp % 2 == 0) tmp /= 2;
                else tmp = (tmp*3) +1;
            }
            cnt++;
        }while(tmp != 1);
        return cnt;
    }
}