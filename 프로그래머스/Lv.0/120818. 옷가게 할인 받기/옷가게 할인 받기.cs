using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;
        double temp = 0;
        if(price >= 500000) 
        {
            temp = (double)price*0.80;
            answer = (int)temp;
        }
        else if(price >= 300000 && price < 500000) {
            temp = (double)price*0.90;
            answer = (int)temp;
        }
        else if(price >= 100000 && price < 300000) {
            temp = (double)price*0.95;
            answer = (int)temp;
        }
        else
            answer = price;
        return answer;
    }
}