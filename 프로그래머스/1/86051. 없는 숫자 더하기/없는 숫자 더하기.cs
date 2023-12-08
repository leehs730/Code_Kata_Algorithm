using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = numbers.Sum();
        answer = 45 - answer;
        return answer;
    }
}