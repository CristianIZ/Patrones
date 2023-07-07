using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface AbstractFactory
    {
        public Coin CreateCoin();
        public QuestionBlock CreateQuestionBlock();
    }
}
