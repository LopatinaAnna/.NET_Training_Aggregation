namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period)
            : base(amount, period)
        { }

        public override decimal Income()
        {
            if (Period < 7)
                return default;

            decimal income = default;
            decimal amount = Amount;

            for (int i = 1; i <= Period - 6; i++)
            {
                income += System.Decimal.Round((amount * 15 / 100), 2);
                amount = Amount + income;
            }

            return income;
        }
    }
}