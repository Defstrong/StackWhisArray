using System.Collections;


namespace StackWhisArray.StackWhisArray
{
    sealed class CustomStack<T> : IEnumerable<T>
    {
        private T[] stackArray;
        private int MaxCount { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty { get => Count == 0; }

        public CustomStack(int maxCount = 100)
        {
            MaxCount = maxCount;
            stackArray = new T[MaxCount];
        }

        public void Push(T item)
        {
            if(IsEmpty)
            {
                stackArray[MaxCount-1] = item;
                Count++;
                return;
            }
            stackArray[MaxCount - Count-1] = item;
            Count++;
        }
        public T Pop()
        {
            if (IsEmpty)
                return default;
            var returnItem = stackArray[MaxCount - Count - 1];
            stackArray[MaxCount - Count - 1] = default(T);
            Count--;
            return returnItem;
        }
        public T Peek
        {
            get
            {
                if (IsEmpty)
                    return default;
                return stackArray[MaxCount - Count - 1];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = MaxCount-Count; i < MaxCount; i++)
            {
                yield return stackArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
