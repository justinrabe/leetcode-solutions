 public static int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length == 1) return new int[0];
        Array.Sort(changed);
    
        List<int> list = changed.ToList();
        for (int i = 0; i < changed.Length / 2; i++)
        {
            if (!list.Remove(list[i] * 2)) return new int[0];
        }
        return list.ToArray();

    }