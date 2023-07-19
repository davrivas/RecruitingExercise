namespace RecruitingExercise
{
    public sealed class Subscription
    {
        /// <summary>
        /// The name of the subscribed service
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The month the subscription expires
        /// </summary>
        public int ExpirationMonth { get; private set; }

        /// <summary>
        /// The year the subscription expires
        /// </summary>
        public int ExpirationYear { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="expirationMonth">The month the subscription expires</param>
        /// <param name="expirationYear">The year the subscription expires</param>
        /// <param name="name">The name of the subscription</param>
        public Subscription(int expirationMonth, int expirationYear, string name)
        {
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            Name = name;
        }
    }
}
