using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// ストラテジーパターンの良い例
    /// </summary>
    class GoodIdea
    {
        public GoodIdea(IStrategy strategy)
        {
            this.Strategy = strategy;
        }
        /// <summary>
        /// 集約して多態性を持たせる
        /// </summary>
        public IStrategy Strategy { get; set; }
    }

    /// <summary>
    /// 多態性を持たせるインターフェイス
    /// </summary>
    interface IStrategy
    {
        void Method1();
        void Method2();
    }

    class Strategy1 : IStrategy
    {
        public void Method1()
        {

        }
        public void Method2()
        {

        }
    }

    class Strategy2 : IStrategy
    {
        public virtual void Method1()
        {

        }
        public void Method2()
        {

        }
    }

    class Strategy3 : IStrategy
    {
        public void Method1()
        {

        }
        public void Method2()
        {

        }
    }

    class Strategy4 : IStrategy
    {
        public void Method1()
        {

        }
        public void Method2()
        {

        }
    }

    class Strategy2_2 : Strategy2
    {
        public override void Method1()
        {

        }
    }

}
