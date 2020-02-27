using IntegerArrayValidation;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        /*
         * Example i/o:
1.input: [1,2,3,4,5,1,1] output: [1]
2. input: [9,3,3,2,1,1,1,2,9,9,9] output: [9,1]
3. input: [1,1,1,1,3,3,3,3,2,1,2,9,9,9] output: [9,3,1]
4. input: [1,2,3,2,1,9,9,8] output: []
5. input: [112,he3,2,1,9,9,8] output: Error 
        */

        public static (int[] input, int[] output)[] SampleCases => new[] {
            (new[] { 1,2,3,4,5,1,1 }, new[]{ 1 }),
            (new[] { 9,3,3,2,1,1,1,2,9,9,9 }, new[] { 9,1 }),
            (new[] { 1,1,1,1,3,3,3,3,2,1,2,9,9,9 }, new[] { 9,3,1 }),
            (new[] { 1,2,3,2,1,9,9,8 }, new int[] { }),
        };

        [Test]
        public void OutputMatchesGivenTestCase_LinqMethod([ValueSource(nameof(SampleCases))] (int[] input, int[] output) testCase)
        {
            var output = Triplicate.DetermineLinq(testCase.input);
            Assert.AreEqual(output, testCase.output);
        }

        [Test]
        public void OutputMatchesGivenTestCase_ForLoopMethod([ValueSource(nameof(SampleCases))] (int[] input, int[] output) testCase)
        {
            var output = Triplicate.DetermineFor(testCase.input);
            Assert.AreEqual(output, testCase.output);
        }
    }
}