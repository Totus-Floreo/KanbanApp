using KanbanApp.Model;
using System;
using System.Windows.Forms;

namespace KanbanApp
{
    internal static class DataBaseContext
    {
        public static ModelDB Database = new ModelDB();

        public static void SaveDatabase()
        {
            try
            {
                Database.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Ошибка системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
