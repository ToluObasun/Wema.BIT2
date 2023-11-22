﻿namespace Wema.BIT
{
    public class User
    {
        public class Users
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

        }

        public class Payment
        {
            public int Id { get; set; }
            public int UserID { get; set; }
            public decimal Amount { get; set; }

        }
    public static void Main(string[] args)
    {

    List<Users> users = new List<Users>()
    {
        new Users() { Id = 1, FirstName = "Aluh", LastName = "Johnson", Email = "johnson@gmail.com" },

        new Users() { Id = 2, FirstName = "Tolu", LastName = "Obasun", Email = "toluobasun@gmail.com" },

        new Users() { Id = 3, FirstName = "Tomi", LastName = "Olaoye", Email = "tomiolaoye@gmail.com" },

        new Users() { Id = 4, FirstName = "Joseph", LastName = "Udoka", Email = "josephudoka@gmail.com" },

        new Users() { Id = 5, FirstName = "Esther", LastName = "Gbadamosi", Email = "esthergbadamosi@gmail.com" },
    };

    List<Payment> payments = new List<Payment>()
    {
        new Payment() { Id = 1, UserID = 1, Amount = 2000 },

        new Payment() { Id = 2, UserID = 1, Amount = 2500 },

        new Payment() { Id = 3, UserID = 1, Amount = 2600 },

        new Payment() { Id = 4, UserID = 2, Amount = 2000 },

        new Payment() { Id = 5, UserID = 2, Amount = 2400 },

        new Payment() { Id = 6, UserID = 2, Amount = 2200 },

        new Payment() { Id = 7, UserID = 3, Amount = 2000 },

        new Payment() { Id = 8, UserID = 3, Amount = 2234 },

        new Payment() { Id = 9, UserID = 3, Amount = 2224 },

        new Payment() { Id = 10, UserID = 4, Amount = 2000 },

        new Payment() { Id = 11, UserID = 4, Amount = 2234 },

        new Payment() { Id = 12, UserID = 4, Amount = 2224 },

        new Payment() { Id = 13, UserID = 5, Amount = 2000 },

        new Payment() { Id = 14, UserID = 5, Amount = 2234 },

        new Payment() { Id = 15, UserID = 5, Amount = 2224 },


    };

            for(int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("Full Details: " + users[i].FirstName + ' '+ users[i].LastName + ' ' + users[i].Email);

                foreach (var payment in payments)
                {
                    if (users[i].Id == payment.UserID)
                    {
                        Console.WriteLine("Payment ID: " + payment.Id + ' '+ "Payment Amount: "+ payment.Amount);
                    }
                }

            }
            
        }

    }
}