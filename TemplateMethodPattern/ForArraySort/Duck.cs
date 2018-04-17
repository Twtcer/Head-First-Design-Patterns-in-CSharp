using System;

namespace TemplateMethodPattern.ForArraySort
{
    public class Duck : IComparable
    {
        private readonly string _name;
        private readonly int _weight;

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"{_name} weights {_weight}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Duck otherDuck)
            {
                if (_weight < otherDuck._weight)
                {
                    return -1;
                }
                if (_weight == otherDuck._weight)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
