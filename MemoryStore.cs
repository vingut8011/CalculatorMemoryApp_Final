// Author: Vincent Y. Gutierrez
// Date: 2025-10-26
// Assignment: SDC220 Project - Phase #3 (Arrays/Lists "Memory")

using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorMemoryApp_Final
{
    public class MemoryStore
    {
        private const int MaxSize = 10;
        private int? _singleValue;
        private List<int> _values = new List<int>();

        // Single value memory
        public void StoreSingle(int value) => _singleValue = value;
        public int? RetrieveSingle() => _singleValue;
        public void ClearSingle() => _singleValue = null;
        public void ReplaceSingle(int value) => _singleValue = value;

        // Collection memory
        public bool AddValue(int value)
        {
            if (_values.Count >= MaxSize) return false;
            _values.Add(value);
            return true;
        }

        public bool RemoveValue(int value) => _values.Remove(value);

        public int Count() => _values.Count;
        public IEnumerable<int> GetValues() => _values;
        public void ClearAll() => _values.Clear();
        public int Sum() => _values.Sum();
        public double Average() => _values.Count > 0 ? _values.Average() : 0;

        public int? FirstMinusLast()
        {
            if (_values.Count < 2) return null;
            return _values[0] - _values[_values.Count - 1];
        }
    }
}

