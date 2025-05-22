using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGenerator2000.Settings
{
    static class FileLocationSettings
    {
        public static object Inputbox { get; private set; }

        public static void SetFileLocation()
        {
            string input = Interaction.InputBox("Current location - " + Properties.Settings.Default["ListFileLocation"].ToString(), "Set File Location");
            if (input == null || input.Length == 0)
                return;

            //Properties.Settings.Default.
            Properties.Settings.Default["ListFileLocation"] = @input;
            Properties.Settings.Default.Save();

        }
    }
}
