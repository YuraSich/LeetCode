public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        if (temperatures.Length==1) return new int[0];
        Stack<int> s= new Stack<int>();
        s.Push(temperatures.Length-1);
        int[] output=new int[temperatures.Length];
        for(int j=temperatures.Length-2;j>=0;j--){
            while (s.Count!=0){
                if (temperatures[s.Peek()]>temperatures[j]){
                    output[j]=s.Peek()-j;
                    break;
                }
                s.Pop();
            }
            s.Push(j);
        }
        return output;
    }
}