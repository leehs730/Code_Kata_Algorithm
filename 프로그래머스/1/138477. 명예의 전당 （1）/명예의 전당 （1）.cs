// score의 길이가 발표 점수의 길이로 판단됨
// 발표 점수는 k의 길이에 따른 명에의 전당에서 일차별로 최하위 점수를 기록
// 명예의 전당에서는 k의 길이에 따른 점수들이 입력되지만, 명예의 전당의
// 최하위 점수 이하면 등록이 안된다.
// 명예의 전당 : 1. k의 길이만큼 전당에 선착순 만큼 점수가 들어간다
// 2. 그 이후론 점수에 따라서 갱신된다.()
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        // // k의 수에 따른 명예의 전당 배열
        // int[] honor_list = new int[k];
        // // 일차는 score 배열의 길이로 점수를 기록할 수 있도록 정의함
        // int[] answer = new int[score.Length];
        // int count = 0
        // while(count < k)
        // {
        //     honor_list[count] = score[count];
        //     honor_list.Reverse();
        //     answer[count] = honor_list[count];
        //     count++;
        // }
        // while(count < score.Length)
        // {
        //     for(int i = 0; i<honor_list.Length; i++)
        //     {
        //         if(honor_list[i])
        //     }
        // }
        // return answer;
        int[] answer = new int[score.Length];
        List<int> board = new List<int>();
        
        for(int i = 0; i < score.Length; i++)
        {
            if(board.Count == k)
            {
                if(board[0] > score[i])
                {
                    answer[i] = board[0];
                    continue;
                }
                board.RemoveAt(0);
            }
            board.Add(score[i]);
            board.Sort();
            answer[i] = board[0];
        }
        return answer;
    }
}