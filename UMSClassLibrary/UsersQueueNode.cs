namespace UMSClassLibrary
{
    //creating generic node class contained in the queue
    public class UsersQueueNode<T>
    {
        //constructor to create a new node
        public UsersQueueNode(T userFirstName, T userLastName, T userEmail, T userCountry, T userOccupation, T userFavFood)
        {
            this.FirstName = userFirstName;
            this.LastName = userLastName;
            this.Email = userEmail;
            this.Country = userCountry;
            this.Occupation = userOccupation;
            this.FavFood = userFavFood;
        }
        
        public T FirstName { get; set; }
        public T LastName { get; set; }
        public T Email { get; set; }
        public T Country { get; set; }
        public T Occupation { get; set; }
        public T FavFood { get; set; }
        public UsersQueueNode<T> Next { get; set; }
    }
}