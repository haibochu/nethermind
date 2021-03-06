using System;
using System.IO;
using System.Linq;

namespace Nethermind.GitBook
{
    public static class DocsDirFinder
    {
        public static string FindJsonRpc()
        {
            string currentDir = Environment.CurrentDirectory;
            do
            {
                if (currentDir == null)
                {
                    return null;
                }

                if (Directory.GetDirectories(currentDir).Contains(Path.Combine(currentDir, "gitbook")))
                {
                    char pathSeparator = Path.AltDirectorySeparatorChar;

                    return Path.Combine(currentDir, $"gitbook{pathSeparator}docs{pathSeparator}ethereum-client{pathSeparator}json-rpc");
                }

                currentDir = new DirectoryInfo(currentDir).Parent?.FullName;
            } while (true);
        }
        
        public static string FindCli()
        {
            string currentDir = Environment.CurrentDirectory;
            do
            {
                if (currentDir == null)
                {
                    return null;
                }

                if (Directory.GetDirectories(currentDir).Contains(Path.Combine(currentDir, "gitbook")))
                {
                    char pathSeparator = Path.AltDirectorySeparatorChar;

                    return Path.Combine(currentDir, $"gitbook{pathSeparator}docs{pathSeparator}nethermind-utilities{pathSeparator}cli");
                }

                currentDir = new DirectoryInfo(currentDir).Parent?.FullName;
            } while (true);
        }
        
        public static string FindMetrics()
        {
            string currentDir = Environment.CurrentDirectory;
            do
            {
                if (currentDir == null)
                {
                    return null;
                }

                if (Directory.GetDirectories(currentDir).Contains(Path.Combine(currentDir, "gitbook")))
                {
                    char pathSeparator = Path.AltDirectorySeparatorChar;

                    return Path.Combine(currentDir, $"gitbook{pathSeparator}docs{pathSeparator}ethereum-client{pathSeparator}metrics");
                }
                currentDir = new DirectoryInfo(currentDir).Parent?.FullName;
            } while (true);
        }
        
        public static string FindConfig()
        {
            string currentDir = Environment.CurrentDirectory;
            do
            {
                if (currentDir == null)
                {
                    return null;
                }

                if (Directory.GetDirectories(currentDir).Contains(Path.Combine(currentDir, "gitbook")))
                {
                    char pathSeparator = Path.AltDirectorySeparatorChar;

                    return Path.Combine(currentDir, $"gitbook{pathSeparator}docs{pathSeparator}ethereum-client{pathSeparator}configuration");
                }
                currentDir = new DirectoryInfo(currentDir).Parent?.FullName;
            } while (true);
        }
    }
}
