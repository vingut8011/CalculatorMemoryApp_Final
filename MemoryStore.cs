namespace CalculatorMemoryApp_Final
{
    public class MemoryStore
    {
        private int? singleValue = null;
        private List<int> values = new List<int>();

        // === Single Value Functions ===
        public void StoreSingle(int value) => singleValue = value;
        public int? RetrieveSingle() => singleValue;
        public void ClearSingle() => singleValue = null;
        public void ReplaceSingle(int value) => singleValue = value;

        // === Collection Functions ===
        public bool AddValue(int value)
        {
            if (values.Count >= 10) return false;
            values.Add(value);
            return true;
        }

        public void RemoveValue(int value) => values.Remove(value);
        public int Count() => values.Count;
        public int Sum() => values.Sum();
        public double Average() => values.Average();
        public int? FirstMinusLast()
        {
            if (values.Count < 2) return null;
            return values.First() - values.Last();
        }
        public void ClearAll() => values.Clear();
        public List<int> GetValues() => values;
    }
}


