using System;
using System.IO;
using System.Linq;
using System.Text;

using static DirDiff.Compress;

namespace DirDiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (!Directory.Exists("dirdiff"))
                {
                    Directory.CreateDirectory("dirdiff");
                }

                Console.WriteLine("OPTIONS:\n- Type \"1\" to specify the first directory\n- Type \"2\" to specify the second directory\n- Type \"diff\" to find the difference between the cached directories");
                Console.Write("-> ");

                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        Start("1");
                        break;
                    case "2":
                        Start("2");
                        break;
                    case "diff":
                        Diff();
                        break;
                }

                Console.Clear();
            }
        }

        private static void Start(string dir)
        {
            Console.Clear();

            Console.WriteLine("Specify the directory:");
            Console.Write("-> ");

            string directory = Console.ReadLine().Replace("\"", "");

            Console.WriteLine();

            Console.WriteLine("Collecting files, please wait...");

            string[] files;

            try
            {
                files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(directory).Append('\n');
            foreach (string file in files)
            {
                string relativePath = file.Substring(directory.Length + 1);
                //Console.WriteLine($"Caching: \"{relativePath}\"");
                sb.Append('\"').Append(relativePath).Append('\"').Append(" | SIZE: ").Append(new FileInfo(file).Length).Append('\n');
            }

            sb.Length--;

            File.WriteAllBytes("dirdiff\\" + dir + ".db", CompressString(sb.ToString()));
        }

        private static void Diff()
        {
            Console.Clear();

            Console.WriteLine("Finding differences, please wait...");

            string[] cache1 = DecompressString(File.ReadAllBytes("dirdiff\\1.db")).Split('\n');
            string[] cache2 = DecompressString(File.ReadAllBytes("dirdiff\\2.db")).Split('\n');

            string[] files1 = ReadCache(cache1, 0);

            string[] files2 = ReadCache(cache2, 0);

            DifferencePair fileDiffsPair = new DifferencePair(files1, files2);
            string[] fileDiff1 = fileDiffsPair.GetDifference1();
            string[] fileDiff2 = fileDiffsPair.GetDifference2();

            string fileDiffs = FormatDifferences(fileDiff1, fileDiff2, "Directory Contains Unique");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("All differences (if any) are listed above! You can find the full log in diff.txt.");

            File.WriteAllText("diff.txt", fileDiffs);

            Console.ReadLine();
        }

        private static string[] ReadCache(string[] input, int index)
        {
            int length = input.Length;

            string[] output = new string[length - 1];

            for (int i = 1; i < length; i++)
            {
                output[i - 1] = input[i].Split('/')[index];
            }

            return output;
        }

        private static string FormatDifferences(string[] list1, string[] list2, string message)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list1.Length; i++)
            {
                string line = $"[1] {message}: {list1[i]}";
                Console.WriteLine(line);
                sb.AppendLine(line);
            }

            sb.AppendLine();
            Console.WriteLine();

            for (int i = 0; i < list2.Length; i++)
            {
                string line = $"[2] {message}: {list2[i]}";
                Console.WriteLine(line);
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }

    public class DifferencePair
    {
        private string[] difference1;
        private string[] difference2;

        public DifferencePair(string[] list1, string[] list2)
        {
            difference1 = list1.Except(list2).ToArray();
            difference2 = list2.Except(list1).ToArray();
        }

        public string[] GetDifference1()
        {
            return difference1;
        }

        public string[] GetDifference2()
        {
            return difference2;
        }
    }
}