namespace Stack
{
    public class Stack<T>
    {
        #region Members
        private T[] stackArray;
        private int maximumLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        #endregion

        #region Public Methods
        public void Push(T value)
        {
            if (Size == maximumLength)
                throw new ExceededSizeException();

            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[Size - 1];
        }
        #endregion
    }
}
