using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CustomBrowser
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Cef.Initialize(new CefSettings());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
