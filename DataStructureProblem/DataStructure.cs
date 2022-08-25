

using C5;



namespace DataStructureProblem
{

    public class DataStructure
    {

        int count = 0;
        int bQueue = 1, bStack = 1, bPriorityQueue = 1;
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();
        IntervalHeap<int> priorityQueue = new IntervalHeap<int>();

        static void Main(string[] args)
        {
        }
     public   string guessDataStructure(int noOfUserInputs = 0, string[,] numbersPatterns = null)
        {
            int x = 0;
            int y = 0;
            while (noOfUserInputs > 0)
            {


                x = Convert.ToInt32(numbersPatterns[count, 0]);
                y = Convert.ToInt32(numbersPatterns[count, 1]);
                if (x == 1)
                {
                    queue.Enqueue(y);
                    stack.Push(y);
                    priorityQueue.Add(y);
                }
                else
                {
                    if (Convert.ToBoolean(bQueue) && queue.Dequeue() != y)
                    {
                        bQueue = 0;
                    }
                    if (Convert.ToBoolean(bStack) && stack.Pop() != y)
                    {
                        bStack = 0;
                    }
                    if (Convert.ToBoolean(bPriorityQueue) && priorityQueue.DeleteMax() != y)
                    {
                        bPriorityQueue = 0;
                    }
                }
                noOfUserInputs--;
                count++;

            }
            return result(bStack, bQueue, bPriorityQueue);
        }
        string result(int bStack, int bQueue, int bPriorityQueue)
        {
            if (bQueue == 1)
            {
                return "queue";
            }
            else if (bStack == 1)
            {
                return "stack";
            }
            else if (bPriorityQueue == 1)
            {
                return "priority queue";
            }
            else if (bStack + bQueue + bPriorityQueue >= 2)
            {
                return "not sure";
            }
            else
            {
                return "impossible";
            }
        }

    }




}
