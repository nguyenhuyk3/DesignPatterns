using DesignPattern.Behavioral.Strategy.SStrategy.SIStrategy;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Strategy.SStrategy.SConcreteStrategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;

            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
