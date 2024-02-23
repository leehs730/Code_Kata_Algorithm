using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        
        Queue<string> queue1 = new Queue<string>();
        Queue<string> queue2 = new Queue<string>();
        
        string answer = "";
        
        foreach(string card in cards1)
        {
            queue1.Enqueue(card);
        }
        
        foreach(string card in cards2)
        {
            queue2.Enqueue(card);
        }
        
        for(int i = 0; i< goal.Length; i++)
        {
            if(queue1.Count != 0)
            {
                string check1 = queue1.Peek();
                
                if(check1 == goal[i])
                {
                    queue1.Dequeue();
                    
                    continue;
                }
            }
            
            if(queue2.Count != 0)
            {
                string check2 = queue2.Peek();
                
                if(check2 == goal[i])
                {
                    queue2.Dequeue();
                    
                    continue;
                }
            }
            
            answer = "No";
            return answer;
        }
        
        answer = "Yes";
        return answer;
    }
}