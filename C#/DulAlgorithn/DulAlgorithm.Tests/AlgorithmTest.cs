using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DulAlgorithm.Tests
{
    [TestClass]
    public class AlgorithmTest
    {
        [TestMethod]
        public void SelectionSort_ShouldReturnSortedArray()
        {
            Assert.AreEqual(10, 10);
        }

        [TestMethod]
        public void SelectionSortMethodTest()
        {
            //[1]Arrange 준비
            int[] arr = { 33, 22, 44 };

            //[2]Act 실행
            int[] result = DulAlgorithm.Algorithm.SelectionSort(arr);

            //[3]Assert 확인
            Assert.AreEqual(22, result[0]); // 정상 실행이 되었다면 result[0]은 22가 되어야 맞다.
            Assert.AreEqual(44, result[result.Length - 1]); //true
        }
    }
}
