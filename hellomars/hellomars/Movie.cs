namespace hellomars
{
    class Movie
    {
        //private yaptigimiz zaman sadece Movie class'i icinden erisebiliriz. Yani program.cs de bu title'i degistiremeyiz.
        public string title2="";
        public string director="";
        private string rating="";

        public Movie(string aTtitle2, string aDirector,string aRating)
        {
            title2 = aTtitle2;
            director = aDirector;
            rating = aRating;
        }

        //private'a aldigimiz koda disardan erismek icin GETTER ve SETTER kullaniriz.
        public string Rating
        {
            get {return rating;}
            set {
                if((rating == "G")|| (rating == "PG")||(rating == "PG-13")|| (rating == "R")|| (rating == "NR"))
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}