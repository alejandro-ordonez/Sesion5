using Sesion5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion5.Helpers
{
    public static class MonkeySeeder
    {

        public static List<Monkey> GetMonkeys =>
            new List<Monkey>
            {
                new Monkey
                {
                    MonkeyName = "Mike",
                    Description = "Monkey native from the deep jungle of Atlantis",
                    MonkeyIcon = GetMonkeyIcon(),
                    MonkeyGallery = GetMonkeyImages()
                },

                new Monkey
                {
                    MonkeyName = "Mike",
                    Description = "Monkey native from the deep jungle of Atlantis",
                    MonkeyIcon = GetMonkeyIcon(),
                    MonkeyGallery = GetMonkeyImages(),
                },

                new Monkey
                {
                    MonkeyName = "Mike",
                    Description = "Monkey native from the deep jungle of Atlantis",
                    MonkeyIcon = GetMonkeyIcon(),
                    MonkeyGallery = GetMonkeyImages(),
                }

            };


        private static List<string> MonkeyImages =>
            new List<string>
            {
                "Resources/Images/monkey1.jpg",
                "Resources/Images/monkey2.jpg",
                "Resources/Images/monkey3.jpg",
                "Resources/Images/monkey4.jpg",
                "Resources/Images/monkey5.jpg",
                "Resources/Images/monkey6.jpg"
            };


        public static List<string> GetMonkeyImages()
        {
            var monkeyImages = MonkeyImages;

            int index = Random.Shared.Next(0, monkeyImages.Count);
            int max = monkeyImages.Count - index;
            int n = Random.Shared.Next(1, max);
            Debug.WriteLine($"Index: {index}, N: {n}");
            return monkeyImages.GetRange(index, n);
        }

        private static string GetMonkeyIcon()
        {
            var monkeyImages = MonkeyImages;

            return monkeyImages.ElementAt(Random.Shared.Next(0, monkeyImages.Count));
        }
            

    }
}
