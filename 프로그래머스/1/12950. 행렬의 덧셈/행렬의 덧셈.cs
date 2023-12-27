public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        // 2차원 배열을 정의할 때, 들어가야 할 길이를 구하려면
        // Length() 메서드를 사용하는 것이 아닌 GetLength() 메서드를 사용한다
        // 여기서 GetLength() 괄호 안에 들어가는건 행의 번호를 입력한다
        int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            for(int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j]; 
            }
        }
        return answer;
    }
}