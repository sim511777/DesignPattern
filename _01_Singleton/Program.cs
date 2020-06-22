using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton {
    class Program {
        static void Main(string[] args) {
            new FirstPage().SetAndPrintSettings();
            new SecondPage().PrintSettings();
        }
    }

    public class FirstPage {
        private Settings settings = Settings.GetInstance();
        public void SetAndPrintSettings() {
            settings.DarkMode = true;
            settings.FontSize = 15;
            Console.WriteLine($"{settings.DarkMode} {settings.FontSize}");
        }
    }

    public class SecondPage {
        private Settings settings = Settings.GetInstance();
        public void PrintSettings() {
            Console.WriteLine($"{settings.DarkMode} {settings.FontSize}");
        }
    }

    public class Settings {
        public bool DarkMode { get; set; } = false;
        public int FontSize { get; set; } = 13;
        
        private Settings() { }  // private 생성자
        private static Settings settings = null;
        public static Settings GetInstance() {
            if (settings == null)   // 객체가 없을때 생성하고 리턴 있으면 그냥 리턴
                settings = new Settings();
            return settings;
        }
    }
}
