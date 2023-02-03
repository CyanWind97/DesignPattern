using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Composite.ShoppingSample
{
    public static class ShoppingSample
    {
        public static void TestCase()
        {
            var smallRedBag = new Bag("红色小袋子");
            smallRedBag.Add(new Goods("婺源特产", 2, 7.9f));
            smallRedBag.Add(new Goods("婺源地产", 1, 9.9f));
            
            var smallWhiteBag = new Bag("白色小袋子");
            smallWhiteBag.Add(new Goods("韶关香菇", 2, 68));
            smallWhiteBag.Add(new Goods("韶关红茶", 3, 180));
            
            var mediumBag = new Bag("中袋子");
            mediumBag.Add(new Goods("景德镇瓷器", 1, 380));
            mediumBag.Add(smallRedBag);
            
            var bigBag = new Bag("大袋子");
            bigBag.Add(new Goods("李宁牌运动鞋", 1, 198));
            bigBag.Add(smallWhiteBag);
            bigBag.Add(mediumBag);

            Console.WriteLine("您选购的商品有：");
            bigBag.Show();

            Console.WriteLine($"要支付的总价: {bigBag.CalcPrice()}元");
        }   
    }
}