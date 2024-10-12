using System;
using System.Threading;
namespace Microsoft_reward_automation
{

    public class Browser
    {
        
        public void OpenBrowser()
        {
           

            List<string> searchItems = new List<string>{ "tony+stark", "scarlet+witch", "Dr+doom", "Captian+america", "flash+DC", "user+stories", "marvel+comics", "one+piece", "flamethrower", "C+#", "BattleField+2042", "Ghost+of+thushima", "Assassins+creed+IV", "Delta+force", "call+of+duty", "tomb+raider", "gameloft", "ubisoft", "rockstar+north", "unity+game+engine", "unreal+engine", "firefox", "amazing+spider+man", "deadpool+and+wolverine", "list+methods+C#", "w3schools", "geeksforgeeks", "visual+studios", "human+torch", "GTA+san+andreas", "gta+vice+city", "gta+V", "Gta+3", "max+payne", "Black+ops+6", "light+no+fire", "elden+rings"};

            foreach (var item in searchItems) {
                string url = $"https://www.bing.com/search?q={item}&cvid=";

                System.Diagnostics.Process.Start("explorer.exe", $"\"{url}\"");

                Thread.Sleep(5000);

            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            browser.OpenBrowser();
        }
    }
}
