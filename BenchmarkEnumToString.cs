using BenchmarkDotNet.Attributes;

namespace EnumToString
{
    [MemoryDiagnoser]
    public class BenchmarkEnumToString
    {
        [Benchmark]
        public string NativeToString()
        {
            return PaymentMethods.VISA.ToString();
        }

        [Benchmark]
        public string FastToString()
        {
            return FastToString(PaymentMethods.VISA);
        }

        private static string FastToString(PaymentMethods paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethods.VISA => nameof(PaymentMethods.VISA),
                PaymentMethods.BANCONTACT => nameof(PaymentMethods.BANCONTACT),
                PaymentMethods.IDEAL => nameof(PaymentMethods.IDEAL),
                PaymentMethods.CASH => nameof(PaymentMethods.CASH),
                _ => throw new ArgumentOutOfRangeException(nameof(paymentMethod), paymentMethod, null),
            };
        }
    }
}
