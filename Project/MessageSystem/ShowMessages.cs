using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.MessageSystem
{
    public static class ShowMessages
    {
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string AskForInput(string message)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(message, "User Input", "");
        }
        public static int AskForIntInput(string message)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(message, "User Input", "");
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Invalid input. Defaulting to 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }
    }
}
