namespace ChopKata.Lib
{
    public class RecursiveChoppa : IChoppa
    {
        public int Chop(int find, int[] arrayToSearch)
        {
            return Chop(find, arrayToSearch, 0, arrayToSearch.Length - 1);
        }

        private int Chop(int find, int[] arrayToSearch, int left, int right)
        {
            if (right >= left)
            {
                int middle = (left + right) / 2;
                if (arrayToSearch[middle] == find)
                {
                    return middle;
                }

                if (find < arrayToSearch[middle])
                {
                    return Chop(find, arrayToSearch, 0, middle - 1);
                }

                if (find > arrayToSearch[middle])
                {
                    return Chop(find, arrayToSearch, middle + 1, right);
                }
            }

            return -1;
        }
    }
}
