namespace ArrListLenTests
{
    public class SolutionUnitTests
    {
        [Fact]
        public void GivenArrayRepresentingLinkedList_WhenSolutionIsCalled_ThenReturnsCorrectLength()
        {
            var solution = new ArrListLen.Solution();
            int[] A = { 1, 4, -1, 3, 2 };
            int expected = 4;
            int actual = solution.solution(A);
            Assert.Equal(expected, actual);
        }
    }
}
