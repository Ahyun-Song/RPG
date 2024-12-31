using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 콘솔 창 생성
            AllocConsole();

            Console.WriteLine("Console initialized!");
            Console.WriteLine("Starting the Windows Forms application...");

            // Windows Forms 실행
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Win32 API를 사용해 콘솔 창 활성화
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }

}