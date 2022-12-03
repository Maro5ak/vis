namespace ExternalLibraries {
    public class PaymentGateway {
        public static bool PaymentGW(int amount) {
            if (amount > 0) return true;
            else return false;
        }
    }
}