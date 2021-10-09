namespace DesignPattern.Strategy.BookBriceSample
{
    public class BookPriceContext
    {
        private MemberStrategy _strategy;

        public BookPriceContext(MemberStrategy strategy)
            => _strategy = strategy;
        
        
        public void SetStrategy(MemberStrategy strategy)
            => _strategy = strategy;

        public double CalcBookPrice(double price)
            => _strategy.CalcBookPrice(price);
        
    }
}