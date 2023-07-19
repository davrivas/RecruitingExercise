namespace RecruitingExercise
{
    public sealed class RecruitingTest
    {
        [Test]
        public void SubscriptionsExpiredPreviousMonth()
        {
            var date = DateTime.Now.AddMonths(-1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            Assert.That(user.ExpiredSubscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", user.ExpiredSubscriptions);
        }

        [Test]
        public void SubscriptionsExpiringNextMonth()
        {
            var date = DateTime.Now.AddMonths(1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            Assert.That(user.ExpiredSubscriptions, Is.EqualTo(0), "Expected expired subscriptions: 0 - Your code returns: {0}", user.ExpiredSubscriptions);
        }


        [Test]
        public void SubscriptionsExpiredLastYear()
        {
            var date = DateTime.Now.AddYears(-1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            Assert.That(user.ExpiredSubscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", user.ExpiredSubscriptions);
        }


        [Test]
        public void SubscriptionsExpiredLastYearPreviousMonth()
        {
            Assert.Fail("Implement this test and remove this line");
        }


        [Test]
        public void SubscriptionsExpiringNextYearNextMonth()
        {
            Assert.Fail("Implement this test and remove this line");
        }


        [Test]
        public void SubscriptionsExpiringLastYearNextMonth()
        {
            Assert.Fail("Implement this test and remove this line");
        }


        [Test]
        public void SubscriptionsExpiringNextYearPreviousMonth()
        {
            Assert.Fail("Implement this test and remove this line");
        }
    }
}