namespace UnitTests
{
    public class BusStop
    {
        private readonly BusStopProblem.BusStop _busStop;
        public BusStop()
        {
            this._busStop = new BusStopProblem.BusStop();
        }
        [Fact]
        public void BusStop_Test_1()
        {
            string expected = "141-143 174 175 180";

            List<int> input = new List<int> { 180, 141, 174, 143, 142, 175 };

            var result = this._busStop.busStopProcessing(input);

            string actualString = string.Join(" ", result);
            Assert.Equal(expected, actualString);

        }


    }
}