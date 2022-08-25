

namespace BusStopProblem
{

    public class BusStop
    {


        public List<string> outputBusesStop = new List<string>();
        static void Main(string[] args)
        {
        }


        public List<string> busStopProcessing(List<int> inputBusesStop)
        {
            inputBusesStop.Sort();
            int count = 0;
            for (int i = 0; i < inputBusesStop.Count; i++)
            {

                if (i > 0 && inputBusesStop[i] - 1 == inputBusesStop[i - 1])
                {
                    count++;
                }

                if (count < 2)
                {
                    outputBusesStop.Add(inputBusesStop[i].ToString());

                }

                if (count > 1 && inputBusesStop[i] + 1 != inputBusesStop[i + 1])
                {
                    outputBusesStop.RemoveAt(outputBusesStop.Count - 1);
                    outputBusesStop[outputBusesStop.Count - 1] = outputBusesStop[outputBusesStop.Count - 1] + "-" +
                        (Convert.ToInt16(outputBusesStop[outputBusesStop.Count - 1]) + count).ToString();
                    count = 0;
                }
            }
            return outputBusesStop;
        }



    }



}


