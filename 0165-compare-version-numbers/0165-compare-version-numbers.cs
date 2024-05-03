public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] version1Arr=version1.Split(".");
        string[] version2Arr=version2.Split(".");
        int len1=version1Arr.Length;
        int len2=version2Arr.Length;

        for(int i=0;i<len1 || i<len2;i++)
        {
            int num1=0;
            if(i<len1) 
                Int32.TryParse(version1Arr[i], out num1);
            
            int num2=0;
            if(i<len2) 
                Int32.TryParse(version2Arr[i], out num2);

            if(num1>num2)
                return 1;
            else if(num2>num1)
                return -1;
        }
        return 0;
    }
}