/* 
 * https://dev.to/samborick/100-project-ideas-oda
 * 
 * Task:
 * 
 * 99 Bottles
 * Create a program that prints out every line to the song "99 bottles of beer on the wall."
 * Do not use a list for all of the numbers, and do not manually type them all in. Use a built-in function instead.
 * Besides the phrase "take one down," you may not type in any numbers/names of numbers directly into your song lyrics.
 * Remember, when you reach 1 bottle left, the word "bottles" becomes singular.
 * 
 * Lyrics:
 * 
 * https://lyricsplayground.com/alpha/songs/numbers/99bottlesofbeeronthewall.html
 */

using System;
using System.Globalization;
using System.Threading;

namespace _99Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            int numOfBottles = 100;
            string word1 = "bottles";
            string word2 = "one";

            // executing method
            SongLyrics(numOfBottles, word1, word2);
        }

        static void SongLyrics(int numOfBottles, string word1, string word2)
        {
            // Countdown loop
            for (int i = numOfBottles; i > 0; i--)
            {
                // j is used for the int on the 5th line of each of the lyric verses.
                int j = i - 1;
                // if j is greater than 0 then use plural
                if (j > 0)
                {
                    word1 = "bottles";
                    word2 = "one";
                }
                // else use single
                else
                {
                    word1 = "bottle";
                    word2 = "it";
                }
                // first 4 lines of the lyrics
                Console.WriteLine(i + " " + word1 + " of beer on the wall,");
                Console.WriteLine(i + " " + word1 + " of beer!");
                Console.WriteLine("Take " + word2 + " down,");
                Console.WriteLine("Pass it around,");

                // lastline of the lyrics
                // this has the most dramatic change near the end
                if (j >= 1)
                {
                    if(j == 1)
                    {
                        word1 = "bottle";
                    }

                    Console.WriteLine(j + " " + word1 + " of beer on the wall!");
                }
                else
                {
                    Console.WriteLine("No more bottles of beer on the wall!");
                }
                Console.WriteLine("");
                Thread.Sleep(100);
            }
        }
    }
}
