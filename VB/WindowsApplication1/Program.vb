Imports System
Imports System.Windows.Forms

Namespace WindowsApplication1

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1(False))
            Call Application.Run(New Form1(True))
        End Sub
    End Module
End Namespace
