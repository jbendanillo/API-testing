using NUnit.Framework;
using NUnitTestProject.API;
using RestSharp;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        BillingOrderAPI billingOrder = new BillingOrderAPI();

        [Test]
        public void TC_GetOrder()
        {

            IRestResponse response = billingOrder.GetOrderById("2");
            TestContext.WriteLine(response.Content);

            IRestResponse response1 = billingOrder.GetOrderById("1");
            TestContext.WriteLine(response1.Content);
        }

        [Test]
        public void TC_GetAllOrder()
        {

            IRestResponse response = billingOrder.GetOrderAll();
            TestContext.WriteLine(response.Content);


        }


        [Test]
        public void TC_PostOrder()
        {
            for (int i = 0; i < 5; i++)
            {
                string body = $"{{\"addressLine1\": \"Park\",\"addressLine2\": \"Street\", \"city\": \"Holroyd\", \"comment\": \"Newrecord\",\"email\": \"john_nel@gmail.com\",\"firstName\": \"John\",\"itemNumber\":{i},\"lastName\": \"Nelson\",\"phone\": \"0987654432\",\"state\": \"AL\",\"zipCode\": \"879652\"}}";

                //for (int i = 1; i <= 100; i++)
                //{
                //    string body = $"{{\"firstName\":\"Csharp{i}\",\"itemNumber\":{i},\"addressLine1\":\"test\",\"addressLine2\": \"ddd\",\"city\": \"CA\",\"comment\": \"testing\",\"email\": \"aa@aa.com\", \"lastName\": \"dddd\",\"phone\": \"1111111111\", \"state\": \"AK\",\"zipCode\": \"222222\"}}";

                // string body = "{\"addressLine1\": \"Home\",\"addressLine2\": \"Street\", \"city\": \"Holroyd\", \"comment\": \"Newrecord\",\"email\": \"john_nel@gmail.com\",\"firstName\": \"John\",\"id\": \"0\",\"itemNumber\": \"3\",\"lastName\": \"Nelson\",\"phone\": \"0987654432\",\"state\": \"AL\",\"zipCode\": \"879652\"}";
                IRestResponse response = billingOrder.PostOrder(body);
                TestContext.WriteLine(response.Content);
            }

        }

        [Test]
        public void TC_UpdateOrder()
        {
            string body = "{\"addressLine1\": \"Strathfield\",\"addressLine2\": \"Street\", \"city\": \"Holroyd\", \"comment\": \"Newrecord\",\"email\": \"john_nel@gmail.com\",\"firstName\": \"John1\",\"id\": \"0\",\"itemNumber\": \"3\",\"lastName\": \"Nelson\",\"phone\": \"0987654432\",\"state\": \"AL\",\"zipCode\": \"879652\"}";


            IRestResponse response = billingOrder.UpdateOrder("2", body);
            TestContext.WriteLine(response.Content);
        }

        [Test]
        public void TC_DeleteOrder()
        {

            IRestResponse response = billingOrder.GetOrderById("5");
            TestContext.WriteLine(response.Content);
        }
    }
}