using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class ControlRedraw {

    private const int WM_SETREDRAW = 0x000B;

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(
        IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    public static void Suspend(Control control) {
        if (control.IsHandleCreated)
            SendMessage(control.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
    }

    public static void Resume(Control control) {
        if (!control.IsHandleCreated)
            return;

        SendMessage(
            control.Handle,
            WM_SETREDRAW,
            new IntPtr(1),
            IntPtr.Zero);

        // بازترسیم خود گرید
        control.Invalidate(true);

        // بازترسیم ناحیه والد که گرید قبلاً اشغال کرده بود
        control.Parent?.Invalidate(true);

        control.Parent?.Update();
        control.Update();
    }
}