namespace museum_server_project
{
    public class Museum
    {
        public string startTime { get; set; }
        public int availablePlaces { get; set; }
        public bool isClosed { get; set; }



        public Museum(string startTime, int availablePlaces, bool isClosed)
        {
            this.startTime = startTime;
            this.availablePlaces = availablePlaces;
            this.isClosed = isClosed;

        }
    
}
}
