public class PositiveNegativeOrder
{
    public void ProcessFile(string filePath)
    {
        Queue<int> positiveQueue = new Queue<int>();
        Queue<int> negativeQueue = new Queue<int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                int number = int.Parse(reader.ReadLine());

                if (number > 0)
                {
                    positiveQueue.Enqueue(number);
                }
                else if (number < 0)
                {
                    negativeQueue.Enqueue(number);
                }
            }
        }

        PrintQueue(positiveQueue);
        PrintQueue(negativeQueue);
    }

    private void PrintQueue(Queue<int> queue)
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }

    public void Run()
    {
        string filePath = "input.txt"; 
        ProcessFile(filePath);
    }
}