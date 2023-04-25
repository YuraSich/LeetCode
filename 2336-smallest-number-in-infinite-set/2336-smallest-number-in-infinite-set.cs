class SmallestInfiniteSet
{
    private HashSet<int> isPresent;
    private PriorityQueue<int, int> addedIntegers;
    private int currentInteger;

    public SmallestInfiniteSet()
    {
        isPresent = new HashSet<int>();
        addedIntegers = new PriorityQueue<int, int>();
        currentInteger = 1;
    }

    public int PopSmallest()
    {
        int answer;
        // If there are numbers in the min-heap, 
        // top element is lowest among all the available numbers.
        if (addedIntegers.Count > 0)
        {
            answer = addedIntegers.Dequeue();
            isPresent.Remove(answer);
        }
        // Otherwise, the smallest number of large positive set 
        // denoted by 'currentInteger' is the answer.
        else
        {
            answer = currentInteger;
            currentInteger += 1;
        }
        return answer;
    }

    public void AddBack(int num)
    {
        if (currentInteger <= num || isPresent.Contains(num))
        {
            return;
        }
        // We push 'num' in the min-heap if it isn't already present.
        addedIntegers.Enqueue(num,num);
        isPresent.Add(num);
    }
}