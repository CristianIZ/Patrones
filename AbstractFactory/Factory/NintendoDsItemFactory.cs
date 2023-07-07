using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class NintendoDsItemFactory : AbstractFactory
    {
        public Coin CreateCoin()
        {
            return new Coin()
            {
                Name = "Nintendo DS Coin"
            };
        }

        public QuestionBlock CreateQuestionBlock()
        {
            return new QuestionBlock()
            {
                Name = "Nintendo DS Question Block"
            };
        }
    }
}
