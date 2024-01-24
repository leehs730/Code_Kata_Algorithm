// 틀린 오답
// using System;
// using System.Collections.Generic;
// using System.Linq;


// public class Solution {
//     public string solution(int[] food) {
//         int[] foodArray = new int[food.Length];
//         List<int> foodList = new List<int>();
//         for(int i = 1; i<4; i++)
//         {
//             for(int j = 0; j < foodArray[i]/2; j++)
//                 foodList.Add(i);
//         }
//         List<int> LRFood = foodArray.OrderByDescending(i => i).ToList();
//         foodList.Add(0);
//         foodList.AddRange(LRFood);
//         string answer = String.Join("", foodList.ToArray());;
//         return answer;
//     }
// }

using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string str = "";
        
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                answer += i.ToString();
            }
        }
        str = String.Concat(answer.Reverse());
        answer += "0" + str;
        return answer;
    }
}