public class SnapshotArray {

    private int SnapID = 0;
    private Dictionary<int, int>[] dicArray;

    public SnapshotArray(int length)
    {
        dicArray = new Dictionary<int, int>[length];
    }

    public void Set(int index, int val)
    {
        if (dicArray[index] == null)
            dicArray[index] = new Dictionary<int, int>();

        if (dicArray[index].ContainsKey(SnapID))
            dicArray[index][SnapID] = val;
        else dicArray[index].Add(SnapID, val);
    }

    public int Snap()
    {
        return SnapID++;
    }

    public int Get(int index, int snap_id)
    {
        if (dicArray[index] == null)
            return 0;

        if (dicArray[index].ContainsKey(snap_id))
            return dicArray[index][snap_id];

        while (!dicArray[index].ContainsKey(snap_id) && snap_id != -1)
            snap_id--;

        return snap_id == -1 ? 0 : dicArray[index][snap_id];
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */