namespace DesignPattern.Strategy.BookBriceSample
{
    public class IntermediateMemberStrategy : MemberStrategy
    {
        public override double CalcBookPrice(double price)
        {
            Console.WriteLine("中级会员享9折优惠。");
            return 0.90 * price;
        }
    }
}