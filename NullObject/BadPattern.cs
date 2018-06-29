using System;

namespace NullObject
{
    public class BadPatternFactory
    {
        public ISample Create(PatternType type)
        {
            switch (type)
            {
                case PatternType.Type1:
                    return new BadPattern1();
                case PatternType.Type2:
                    return new BadPattern2();
                case PatternType.Type3:
                    return new BadPattern3();
            }
            return null;//nullを返してしまう
        }
    }
    class BadPattern1 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 1");
        }
    }

    class BadPattern2 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 2");
        }
    }

    class BadPattern3 : ISample
    {
        public void Method()
        {
            Console.WriteLine("Method 3");
        }
    }
}
