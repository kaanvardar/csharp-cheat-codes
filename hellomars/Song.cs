namespace hellomars
{
    class Song
    {
        public string sTitle;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string asTitle, string aArtist, int aDuration)
        {
            sTitle = asTitle;
            artist = aArtist;
            duration = aDuration;
        }
    }
}