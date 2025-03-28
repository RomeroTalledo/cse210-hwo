using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Profugos", "Soda Stereo", 240);
        var video2 = new Video("Libido", "Libido", 240);
        var video3 = new Video("Cae el sol", "Airbag", 240);

        // Add comments to "Profugos"
        video1.AddComment("Fernando", "A classic of Latin rock! I never get tired of listening to it.");
        video1.AddComment("Lucia", "Gustavo Cerati's energy in this song is amazing.");
        video1.AddComment("Ricardo", "Reminds me of my youth, those were the days.");
        video1.AddComment("Andrea", "Definitely, Soda Stereo defined an era.");

        // Add comments to "Libido"
        video2.AddComment("Carlos", "The best Peruvian rock band, what a great song.");
        video2.AddComment("Sofia", "I love the lyrics, they have a deep meaning.");
        video2.AddComment("Javier", "So nostalgic! Reminds me of concerts in the 2000s.");
        video2.AddComment("Mariana", "Libido has always been one of my favorite bands.");

        // Add comments to "Cae el sol"
        video3.AddComment("Alejandro", "A song that transports me to another world.");
        video3.AddComment("Valeria", "The vocals and melody are simply perfect.");
        video3.AddComment("Diego", "Airbag never disappoints, great song.");
        video3.AddComment("Elena", "Perfect to listen to during sunset, what a vibe!");

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video's information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}