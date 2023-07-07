using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class GameBoyItemFactory : AbstractFactory
    {
        public Coin CreateCoin()
        {
            return new Coin()
            {
                Name = "Game boy Coin"
            };
        }

        public QuestionBlock CreateQuestionBlock()
        {
            return new QuestionBlock()
            {
                Name = "Game boy Question Block"
            };
        }
    }
}
