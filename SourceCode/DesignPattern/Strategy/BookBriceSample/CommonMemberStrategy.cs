namespace DesignPattern.Strategy.BookBriceSample
{
    public class CommonMemberStrategy : MemberStrategy
    {
        public override double CalcBookPrice(double price)
        {
            Console.WriteLine("普通会员享95折优惠。");
            return 0.95 * price;
        }
    }
}