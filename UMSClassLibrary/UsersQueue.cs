using System;

namespace UMSClassLibrary
{
    //creating a users generic queue class
    public class UsersQueue<T>
    {
        public UsersQueueNode<T> Head { get; set; }
        public UsersQueueNode<T> Tail { get; set; }
        public int Count { get; set; }


        //public static UsersQueue<T> usersqueue = new UsersQueue<T>();

        //method to add users to the queue (add from the back)
        public UsersQueueNode<T> Enqueue(T userFirstName, T userLastName, T userEmail, T userCountry, T userOccupation, T userFavFood)
        {
            UsersQueueNode<T> node = new UsersQueueNode<T>(userFirstName, userLastName, userEmail, userCountry, userOccupation, userFavFood);
            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count++;
                return node;
            }
            this.Tail.Next = node;
            this.Tail = node;
            this.Count++;
            return node;
        }

        public T Dequeue()
        {
            if (Head == null)
            {
                Console.WriteLine("Users queue is empty");
                throw new NullReferenceException("Queue is empty");
            }
            T userFirstName = this.Head.FirstName;
            T userLastName = this.Head.LastName;
            this.Head = this.Head.Next;
            this.Count--;
            return userFirstName;
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                Console.WriteLine($"Name: {temp.FirstName} {temp.LastName}");
                Console.WriteLine($"Email: {temp.Email}");
                Console.WriteLine($"Country: {temp.Country}");
                Console.WriteLine($"Occupation: {temp.Occupation}");
                Console.WriteLine($"Favourite Food: {temp.FavFood}");
                Console.WriteLine("-------------------------------");
                temp = temp.Next;
            }
            Console.WriteLine(Count);
        }
    }
}
