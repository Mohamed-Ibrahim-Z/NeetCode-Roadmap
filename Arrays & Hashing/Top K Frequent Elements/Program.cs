int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();

    foreach(int x in nums)
    {
        if (dic.ContainsKey(x))
            dic[x]++;
        else
            dic.Add(x, 1);
    }
    var sortedDict = from entry in dic orderby entry.Value descending select entry;
    int[] res = new int[k];
    for(int i =0; i<k;i++)
    {
        res[i] = sortedDict.ElementAt(i).Key;
    }
    return res;
}
