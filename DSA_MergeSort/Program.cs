    // See https://aka.ms/new-console-template for more information

    //Merge sort

    using System.Security.Cryptography;

    int[] array = { 23, 4, 1, 56, 3, 7, 8, 98, 100 };

    int length  = array.Length;
    int[] sorted= sortArray(0, length - 1);
    displayResult(sorted);

    int[] sortArray(int start,int end)
    {
    
        if (start == end)
        {
            int value = array[start];
            return new int[] { value };

        }

        int mid = (start + end) / 2;
        int[] array1 = sortArray(start,mid);
        int[] array2 = sortArray(mid+1,end);

        int x=0, y=0; List<int> sortedArray = new List<int>();
        while (x<array1.Length && y<array2.Length)
        {
            if (array1[x] > array2[y])
            {
                sortedArray.Add(array2[y]);
                y++;
            }
            else
            {
                sortedArray.Add(array1[x]);
                x++;
            }
        }

        if(x < array1.Length)
        {
            for(int i=x;i<array1.Length;i++)
            {
                sortedArray.Add(array1[i]);
            }
        }
        else
        {
            for (int i = y; i < array2.Length; i++)
            {
                sortedArray.Add(array2[i]);
            }
        }

        return sortedArray.ToArray();

    }




    void displayResult(int[] sorted)
    {
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }