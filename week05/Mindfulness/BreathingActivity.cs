public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.",
        0)
    {
    }

    public void Run()
    {
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountSpinner(4);
            Console.WriteLine("Now breathe out...");
            ShowCountSpinner(6);
            elapsed += 10;
        }
    }
}
