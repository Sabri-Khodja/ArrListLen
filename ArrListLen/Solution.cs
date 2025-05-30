namespace ArrListLen
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int index = 0, length = 1;
            while (A[index] != -1)
            {
                index = A[index];
                length++;
            }
            return length;
        }
    }
}
