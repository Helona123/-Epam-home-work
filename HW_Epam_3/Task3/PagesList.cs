using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PagesList
    {
        const int NumberOfItems = 5;
        public int N { get; set; }
        public int WordLenght { get; set; }

        

        public List<string> CreateList(List<string> listWords) // Creating a word list
        {
            Random rand = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            listWords.Clear();

            for (int i = 0; i < N; i++)
            {
                string word = "";
                for (int j = 0; j < WordLenght; j++)
                {
                    int letter_num = rand.Next(0, letters.Length);
                    word += letters[letter_num];
                }
                listWords.Add(word);
            }
            return listWords;
        }
        



        public List<string> TransformerList(List<string> listWords) // Sort and deleted some words from list
        {
            for (int i = listWords.Count - 1; i > -1; i--)
            {
                if (listWords[i].StartsWith("Z"))
                    listWords.Remove(listWords[i]);
                else
                {
                    for (int j = i - 1; j > -1; j--)
                        if (listWords[i] == listWords[j])
                            listWords.RemoveAt(j);

                }
            }

            return listWords;
        }

        public void DisplayPage(int pageNumber, List<string> listWords) // display 
        {
            try
            {
                int c;

                c = NumberOfItems * pageNumber;
                for (int i = c - NumberOfItems; i < c; i++)
                {
                    Console.Write(listWords[i] + " ");
                }
            }

            catch (ArgumentOutOfRangeException) { }

        }
    }

}
