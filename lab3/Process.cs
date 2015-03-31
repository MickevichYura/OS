using System;

namespace lab3
{
    internal class Process
    {
        private readonly decimal[] _a;
        private readonly int _nestingLevel;
        private readonly int _increment;
        private readonly int _startPosition;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayLength"></param>
        /// <param name="nestingLevel"></param>
        /// <param name="increment"></param>
        /// <param name="startPosition"></param>
        public Process(int arrayLength, int nestingLevel, int increment, int startPosition)
        {
            _a = new decimal[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                _a[i] = Decimal.MaxValue;
            }
            _nestingLevel = nestingLevel;
            _increment = increment;
            _startPosition = startPosition;
        }

        public void Run()
        {
            for (int i = _startPosition; i < _a.Length; i += _increment)
            {
                for (int j = 0; j < _nestingLevel; j++)
                {
                    _a[i] /= (decimal) 2.1;
                }
            }
        }
    }
}
