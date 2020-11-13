using System;
using System.Text.Json;

namespace yt_video_maker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] prefix = {"Cancel & Quit", "Who is", "What is", "The history of"};

            var orchestrator = new Orchestrator();

            Console.WriteLine("Type a Wikipedia search term:");
            orchestrator.SearchTerm = Console.ReadLine();

            Console.WriteLine("Choose one option:");

            for (int i = 0; i < prefix.Length; i++)
            {
                Console.WriteLine($"{i} - {prefix[i]}");
            }

            var option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 0:
                    return;
                case 1:
                case 2:
                case 3:
                    orchestrator.Prefix = prefix[option];
                    break;
                default:
                    return;
            }

            Console.WriteLine(JsonSerializer.Serialize(orchestrator));
        }
    }
}
