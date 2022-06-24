using KanbanApp.Model;
using System;
using System.Windows.Forms;

namespace KanbanApp
{
    public static class DataBaseContext
    {
        public static ModelDB Database = new ModelDB();

        public delegate void DatabaseSaved();
        public static event DatabaseSaved DatabaseSuccessfullySaved;

        public static void SaveDatabase()
        {
            try
            {
                Database.SaveChanges();
                DatabaseSuccessfullySaved();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Ошибка системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
