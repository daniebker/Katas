namespace ChopKata.Lib
{
    public class WhileChoppa : IChoppa
    {
        public int Chop(int find, int[] arrayToChop)
        {
            int left = 0;
            int right = arrayToChop.Length - 1;
            bool notFound = arrayToChop.Length != 0;

            while (notFound)
            {
                if (right >= left)
                {
                    int middle = (left + right) / 2;
                    if (arrayToChop[middle] == find)
                    {
                        return middle;
                    }

                    if (find < arrayToChop[middle])
                    {
                        right = middle - 1;
                    }

                    if (find > arrayToChop[middle])
                    {
                        left = middle + 1;
                    }
                }
                else
                {
                    notFound = false;
                }

            }

            return -1;
        }
    }
}
