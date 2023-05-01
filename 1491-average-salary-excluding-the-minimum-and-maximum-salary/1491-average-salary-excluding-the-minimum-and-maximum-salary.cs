public class Solution {
    public double Average(int[] salary) {
            int max = salary[0];
            int min = salary[0];
            int sum = 0;
            foreach (var i in salary)
            {
                sum += i;
                if (i >= max)
                    max = i;
                if (i <= min)
                    min = i;

            }
            return (double)(sum - max - min) / (double)(salary.Length - 2);
    }
}