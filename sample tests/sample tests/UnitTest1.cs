namespace sample_tests
{
    public class Tests
    {
        int AmountOfTests;

        [SetUp]
        public void Setup()
        {
            AmountOfTests += 1;
        }

        [Test]
        public void TestPassPasses()
        {
            Assert.Pass();
        }

        [Test]
        public void TestOneIsOne()
        {

            Assert.That(1 == 1);
        }

        [Test]
        public void TestTrueIsTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestFalseIsFalse()
        {
            Assert.IsFalse(false);
        }

        [Test]
        public void TestxLargerThanX()
        {
            int X = 1;
            int x = X + 1;

            Assert.Greater(x, X);
        }

        [Test]
        public void TestYSmallerThany()
        {
            int Y = 1;
            int y = Y + 1;
            Assert.Less(Y, y);
        }

        [Test]
        public void TestAmountOfTestsAreGreaterThanTestsAmountsPlusOne()
        {
            Assert.That(AmountOfTests + 1 > AmountOfTests);
        }

        [Test]
        public void TestAmountOfTestsAreGreaterThanFiveOrTestsAreGreaterOrEqualThanOne()
        {
            // needs to test that it is greater or equal than 1 because of the order of the tests
            Assert.That(AmountOfTests > 5 || AmountOfTests >= 1);
        }

        [Test]
        public void TestOneOfTheTestsThatTheTestPasses()
        {
            List<Action> testList = new List<Action>
            {
                TestPassPasses,
                TestOneIsOne,
                TestTrueIsTrue,
                TestFalseIsFalse,
                TestxLargerThanX,
                TestYSmallerThany,
                TestAmountOfTestsAreGreaterThanTestsAmountsPlusOne,
                TestAmountOfTestsAreGreaterThanFiveOrTestsAreGreaterOrEqualThanOne,
            };

            Random random = new();
            int index = random.Next(testList.Count);

            testList[index]();
        }

        public void TestAllTestsThatTheTestsPass()
        {
            List<Action> testList = new List<Action>
            {
                TestPassPasses,
                TestOneIsOne,
                TestTrueIsTrue,
                TestFalseIsFalse,
                TestxLargerThanX,
                TestYSmallerThany,
                TestAmountOfTestsAreGreaterThanTestsAmountsPlusOne,
                TestAmountOfTestsAreGreaterThanFiveOrTestsAreGreaterOrEqualThanOne,
                TestOneOfTheTestsThatTheTestPasses,
            };

            foreach (Action TestFunction in testList)
            {
                TestFunction();
                Assert.Pass(); // TestFunction returns void so I need to Pass test manually
            }
        }


    }
}