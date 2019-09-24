using System;

public class ExceptionHandler
{
    public static void HandleException(Exception e)
    {
        MessageBox.Show(e.ToString());
    }
}
