using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static Dictionary<string, string> documents = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Text Editor");
                Console.WriteLine("1. Add document");
                Console.WriteLine("2. Remove document");
                Console.WriteLine("3. Edit document");
                Console.WriteLine("4. Count words/characters");
                Console.WriteLine("5. Remove word/character");
                Console.WriteLine("6. Change word");
                Console.WriteLine("7. Clear document");
                Console.WriteLine("8. Add '-' between words");
                Console.WriteLine("9. Exit");
                Console.Write("Please Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Remove();
                        break;
                    case "3":
                        Edit();
                        break;
                    case "4":
                        CountWordsChars();
                        break;
                    case "5":
                        RemoveWordChar();
                        break;
                    case "6":
                        ChangeWord();
                        break;
                    case "7":
                        ClearDocument();
                        break;
                    case "8":
                        AddCharacterBetweenWords();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Please Try again");
                        break;
                }
            }
        }

        static void Add()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                Console.WriteLine("Document already exists");
                return;
            }

            Console.Write("Please Enter document content Text: ");
            string content = Console.ReadLine();
            documents[name] = content;
            Console.WriteLine("Document added");
        }

        static void Remove()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.Remove(name))
            {
                Console.WriteLine("Document removed");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void Edit()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                Console.Write("Please Enter new content: ");
                string content = Console.ReadLine();
                documents[name] = content;
                Console.WriteLine("Document updated");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void CountWordsChars()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                string content = documents[name];
                int wordCount = content.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = content.Length;
                Console.WriteLine($"Words: {wordCount}, Characters: {charCount}");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void RemoveWordChar()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                Console.Write("Enter word/character to remove: ");
                string toRemove = Console.ReadLine();
                documents[name] = documents[name].Replace(toRemove, "");
                Console.WriteLine("Word/character removed.");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void ChangeWord()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                Console.Write("Please Enter word to replace: ");
                string oldWord = Console.ReadLine();
                Console.Write("Please Enter new word: ");
                string newWord = Console.ReadLine();
                documents[name] = documents[name].Replace(oldWord, newWord);
                Console.WriteLine("Word replaced.");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void ClearDocument()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                documents[name] = "";
                Console.WriteLine("Document cleared.");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }

        static void AddCharacterBetweenWords()
        {
            Console.Write("Please Enter document name: ");
            string name = Console.ReadLine();
            if (documents.ContainsKey(name))
            {
                documents[name] = string.Join("-", documents[name].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine("Character added between words.");
            }
            else
            {
                Console.WriteLine("Document is not exist");
            }
        }
    }
}