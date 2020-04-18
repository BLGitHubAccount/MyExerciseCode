using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2._8使用Barrier类
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = new Thread(()=>PlayMusic("the guitarist","play an amazing solo",5));
            //var t2 = new Thread(()=>PlayMusic("the singer","sing his song",2));
            //t1.Start();
            //t2.Start();

            BarrierSample();
            Console.ReadKey();
        }

        static Barrier _barrier = new Barrier(2, b => Console.WriteLine($"End of phase {b.CurrentPhaseNumber+1}"));
        static void PlayMusic(string name, string message, int seconds)
        {
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("-------------");
                Thread.Sleep(TimeSpan.FromSeconds(seconds));
                Console.WriteLine($"{name} starts to {message}");
                Thread.Sleep(TimeSpan.FromSeconds(seconds));
                Console.WriteLine($"{name} finishes to {message}");
                _barrier.SignalAndWait();
                Console.WriteLine("Completed!!");
            }

        }
        static void BarrierSample()
        {
            int count = 0;

            // Create a barrier with three participants
            // Provide a post-phase action that will print out certain information
            // And the third time through, it will throw an exception
            Barrier barrier = new Barrier(3, (b) =>
            {
                Console.WriteLine("Post-Phase action: count={0}, phase={1}", count, b.CurrentPhaseNumber);
                if (b.CurrentPhaseNumber == 2) throw new Exception("D'oh!");
            });

            // Nope -- changed my mind.  Let's make it five participants.
            barrier.AddParticipants(2);

            // Nope -- let's settle on four participants.
            barrier.RemoveParticipant();

            // This is the logic run by all participants
            Action action = () =>
            {
                Interlocked.Increment(ref count);
                barrier.SignalAndWait(); // during the post-phase action, count should be 4 and phase should be 0
                Interlocked.Increment(ref count);
                barrier.SignalAndWait(); // during the post-phase action, count should be 8 and phase should be 1

                // The third time, SignalAndWait() will throw an exception and all participants will see it
                Interlocked.Increment(ref count);
                try
                {
                    barrier.SignalAndWait();
                }
                catch (BarrierPostPhaseException bppe)
                {
                    Console.WriteLine("Caught BarrierPostPhaseException: {0}", bppe.Message);
                }

                // The fourth time should be hunky-dory
                Interlocked.Increment(ref count);
                barrier.SignalAndWait(); // during the post-phase action, count should be 16 and phase should be 3
            };

            // Now launch 4 parallel actions to serve as 4 participants
            Parallel.Invoke(action, action, action, action);

            // This (5 participants) would cause an exception:
            // Parallel.Invoke(action, action, action, action, action);
            //      "System.InvalidOperationException: The number of threads using the barrier
            //      exceeded the total number of registered participants."

            // It's good form to Dispose() a barrier when you're done with it.
            barrier.Dispose();
        }

    }
}
