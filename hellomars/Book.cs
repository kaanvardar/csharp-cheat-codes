namespace hellomars
{
    //defining method
    class Book
    {
        public string title = "";
        public string author = "";
        public int pages;

        //constructor
        public Book(string aTtitle,string aAuthor,int aPages)
        {
            title = aTtitle;
            author = aAuthor;
            pages = aPages;
        }
    }

    
}