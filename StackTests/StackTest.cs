using Stack;
using NUnit.Framework;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Creation()
        {
            // Act
            Stack<int> stack = new Stack<int>(3);

            // Assert
            Assert.AreEqual(0, stack.Size);
        }

        public void AssertMaximumStackSize()
        {
            // Setup
            Stack<int> stack = new Stack<int>(7);

            // Assert
            Assert.AreEqual(7, stack.MaximumLength);
        }

        [Test]
        public void HappyFlow_Pop()
        {
            // Setup
            Stack<int> stack = new Stack<int>(3);

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int value = stack.Pop();

            // Assert
            Assert.AreEqual(3, value);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void HappyFlow_Peek()
        {
            // Setup
            Stack<int> stack = new Stack<int>(3);

            // Act
            stack.Push(1);
            stack.Push(2);
            int value = stack.Peek();

            // Assert
            Assert.AreEqual(2, value);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void ShouldThrow_PopingWhenNoArguments()
        {
            // Setup
            Stack<int> stack = new Stack<int>(3);

            // Act + Assert
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }

        [Test]
        public void ShouldThrow_PutInMoreThanThePossibleAmount()
        {
            // Setup
            Stack<int> stack = new Stack<int>(3);

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act + Assert
            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Test]
        public void ShouldThrow_PeekWhenNoArguments()
        {
            // Setup
            Stack<int> stack = new Stack<int>(3);

            // Act + Assert
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Peek());
        }
    }
}
