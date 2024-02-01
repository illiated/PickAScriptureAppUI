using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAScriptureAppUI
{
    internal class PickAScriptureClass
    {
        static Random random = new Random();
        /// <summary>
        /// Picks random scripture refs and returns them.
        /// </summary>
        /// <param name="numberOfScriptures">The number of scriptures to pick.</param>
        /// <returns>An array of strings that returns a scripture reference.</returns>
        public static string[] PickRandomScripture(int numberOfScriptures)
        {
            string[] pickedScripture = new string[numberOfScriptures];
            for(int i = 0; i < numberOfScriptures; i++)
            {
                pickedScripture[i] = PickRandomBook() + " " + PickRandomChapter() + ":" + PickRandomVerse();
            }
            return pickedScripture;
        }

        private static string PickRandomBook()
        {
            int randomBook = random.Next(1, 5);
            if (randomBook == 1) return "Matthew";
            if (randomBook == 2) return "Mark";
            if (randomBook == 3) return "Luke";
            return "John";
        }

        private static int PickRandomChapter()
        {
            int randomChapter = random.Next(1, 6);
            if (randomChapter == 1 || randomChapter == 2 || randomChapter == 3 || 
                randomChapter == 4) return randomChapter;
            return randomChapter;
           
        }

        private static int PickRandomVerse()
        {
            int randomVerse = random.Next(1, 6);
            if (randomVerse == 1 || randomVerse == 2 || randomVerse == 3 || 
                randomVerse == 4) return randomVerse;
            return randomVerse;
        }
    }
}
