using BusinessLayer;

namespace PresentationLayer {
    public class Program {
        //private static readonly string connectionString = DatabaseConnector.GetBuilder().ConnectionString;

        static void Main(string[] args) {
            Rental rental = new Rental(new Instrument(), new Customer(), new Payment(Payment.PaymentMethodEnum.PAYPAL, Payment.RentalOrder.RENTAL), DateTime.Now);

            Console.WriteLine(rental.EndTime);

        }
    }
}