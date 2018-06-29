using System;

namespace NullObject
{
    public class GoodPatternFactory
    {
        public ISample Create(PatternType type)
        {
            switch (type)
            {
                case PatternType.Type1:
                    return new GoodPattern1();
                case PatternType.Type2:
                    return new GoodPattern2();
                case PatternType.Type3:
                    return new GoodPattern3();
            }
            return new NullObjectPattern();
        }
    }
    class GoodPattern1 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 1");
        }
    }

    class GoodPattern2 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 2");
        }
    }

    class GoodPattern3 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 3");
        }
    }

    class NullObjectPattern : ISample
    {
        public void Method()
        {
            Console.WriteLine("Called Null Object Instance");
        }
    }
}
