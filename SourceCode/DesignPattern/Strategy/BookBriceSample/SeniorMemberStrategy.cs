namespace DesignPattern.Strategy.BookBriceSample
{
    public class SeniorMemberStrategy : MemberStrategy
    {
        public override double CalcBookPrice(double price)
        {
            Console.WriteLine("高级会员享8折优惠。");
            return 0.80 * price;
        }
    }
}