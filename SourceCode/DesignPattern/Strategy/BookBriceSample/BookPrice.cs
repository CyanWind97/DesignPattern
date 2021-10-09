namespace DesignPattern.Strategy.BookBriceSample
{
    public static class BookPrice
    {
        public static void TestCase()
        {
            var context = new BookPriceContext(new CommonMemberStrategy());
            double price = 300;

            double realPrice = context.CalcBookPrice(price);
            Console.WriteLine($"图书价格为：{realPrice}.");

            context.SetStrategy(new SeniorMemberStrategy());
            realPrice = context.CalcBookPrice(price);
            Console.WriteLine($"图书价格为：{realPrice}.");
        }
    }
}