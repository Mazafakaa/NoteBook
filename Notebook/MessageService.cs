using System;
using System.Windows;

namespace Notebook
{
    public static class MessageService
    {
        public static void ShowMessage(Exception ex)
        {
            MessageBox.Show("Произошла ошибка при выполнении программы: " + ex.Message);
        }
    }
}
