using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitingExercise
{
    public class User
    {
        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The user's chosen payment type
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// The user's subscriptions
        /// </summary>
        public IEnumerable<Subscription> Subscriptions { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="subscriptions">The subscriptions the user has.</param>
        /// <param name="name">Name of the user</param>
        /// <param name="paymentType">The payment type that the user has used for the subscriptions</param>
        public User(IEnumerable<Subscription> subscriptions, string name, PaymentType paymentType)
        {
            Subscriptions = subscriptions;
            Name = name;
            PaymentType = paymentType;
        }

        /// <summary>
        /// The number of expired subscriptions the user has
        /// </summary>
        public int ExpiredSubscriptions => 0;
    }
}
