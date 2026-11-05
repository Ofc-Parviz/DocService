using System;
using Sm.Ui.Core;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace DocService {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GuiCore.Styles.LightMode_App_Logo = Properties.Resources.DocServiceLogo;
            GuiCore.Styles.App_Icon = Properties.Resources.DocServiceLogo1;

            var Current_Main_Window =
                GuiCore.RunCoreWithDefultConfig<FMain>("ابزار مدیریت مستندات",
                "DocService", _AppVersion: "1.0.0", _Allowed_File_Extention: ".docsvc");



            if (Current_Main_Window != null)
                if (!Current_Main_Window.Disposing)
                    if (!Current_Main_Window.IsDisposed)
                        Application.Run(Current_Main_Window);
        }
    }
}
