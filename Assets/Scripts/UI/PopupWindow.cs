
using System;
using System.Runtime.InteropServices;

public static class NativePopup
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern int MessageBox(
        IntPtr hWnd,
        string text,
        string caption,
        uint type
    );

    private const uint MB_OK = 0x00000000;
    private const uint MB_ICONINFORMATION = 0x00000040;

    /// <summary>
    /// Opens a native Windows dialog with a confirmation button.
    /// Pressing Enter confirms the dialog.
    /// </summary>
    public static void Show(string message)
    {
        MessageBox(
            IntPtr.Zero,
            message,
            "",
            MB_OK | MB_ICONINFORMATION
        );
    }
}
