using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MessageSystem
{
    public static class ManageError
    {
        public static int string_int(string input, string message)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                ShowMessages.ShowMessage(message);
                return 0;
            }
        }
    }
}
