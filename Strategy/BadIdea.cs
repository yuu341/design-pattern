using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 悪いアイディア
    /// </summary>
    class BadIdea
    {
        public virtual void Method1()
        {

        }
        public virtual void Method2()
        {

        }
    }

    class BadIdea1 : BadIdea
    {
        public override void Method1()
        {

        }
        public override void Method2()
        {

        }
    }

    class BadIdea2 : BadIdea
    {
        public override void Method1()
        {

        }
        public override void Method2()
        {

        }
    }

    class BadIdea3 : BadIdea
    {
        public override void Method1()
        {

        }
        public override void Method2()
        {

        }
    }

    class BadIdea4 : BadIdea
    {
        public override void Method1()
        {

        }
        public override void Method2()
        {

        }
    }

    class BadIdea2_1 : BadIdea2
    {
        public override void Method1()
        {

        }
    }
}
