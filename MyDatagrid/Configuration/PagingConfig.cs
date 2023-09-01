namespace MyDatagrid.Configuration
{
    public class PagingConfig
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }

        public int NumOfItemsToSkip(int pageNumber)
        {
            if (Enabled)
            {
                return (pageNumber - 1) * PageSize;
            }
            else
            {
                return 0;
            }
        }
        public int NumOfItemsToTake(int TotalItemsCount)
        {
            if (Enabled)
            {
                return PageSize;
            }
            return TotalItemsCount;
        }
        public int PrevPageNumber(int currentPageNumber)
        {
            if (currentPageNumber > 1)
            {
                return currentPageNumber - 1;
            }
            return 1;
        }
        public int NextPageNumber(int currentPageNumber, int totalItemsCount)
        {
            if (currentPageNumber < MaxPageNumber(totalItemsCount))
            {
                return currentPageNumber + 1;
            }
            return currentPageNumber;
        }
        public int MaxPageNumber(int totalItemsCount)
        {
            int maxPageNumber;
            double numberOfPages = (double)totalItemsCount / (double)PageSize;
            if (numberOfPages == Math.Floor(numberOfPages))
                maxPageNumber = (int)numberOfPages;
            else
                maxPageNumber = (int)numberOfPages + 1;
            return maxPageNumber;
        }

    }
}
