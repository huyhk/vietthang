using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace VNS.Utils
{
    public class AutoCompleteUtils
    {
        /// <summary>
        /// the maximum number of the AutoCompleteCustomSource counter
        /// </summary>
        private static int MaxRow = 100;
        /// <summary>
        /// get the File Path stored the AutoCompleteCustomSource of the control
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private static string GetAutoFilePath(TextBox control)
        {
            string filePath;
            filePath = Path.GetTempPath();
            filePath += "\\" + control.FindForm().Name + "." + control.Name + ".txt";
            return filePath;
        }
        /// <summary>
        /// set the AutoCompleteCustomSource for the control from the saved file
        /// </summary>
        /// <param name="control"></param>
        public static void LoadAutoComplete(TextBox control)
        {
            string filePath = GetAutoFilePath(control);
            if (File.Exists(filePath))
            {
                control.AutoCompleteCustomSource.AddRange(File.ReadAllLines(filePath, Encoding.Unicode));
            }
        }
        /// <summary>
        /// interactive add text into the AutoCompleteCustomSource of the control
        /// </summary>
        /// <param name="control"></param>
        public static void AddAutoCompleteSource(TextBox control)
        {
            if (control.Text.Trim() != string.Empty)
            {
                control.AutoCompleteCustomSource.Add(control.Text.Trim());
                if (control.AutoCompleteCustomSource.Count > MaxRow)
                {
                    control.AutoCompleteCustomSource.RemoveAt(0);
                }
            }
        }
        /// <summary>
        /// save the AutoCompleteCustomSource into file
        /// </summary>
        /// <param name="control"></param>
        public static void SaveAutoComplete(TextBox control)
        {
            int length = control.AutoCompleteCustomSource.Count;
            if (length > 0)
            {
                string filePath = GetAutoFilePath(control);
                string[] SaveString = new string[length];
                control.AutoCompleteCustomSource.CopyTo(SaveString, 0);
                File.WriteAllLines(filePath, SaveString, Encoding.Unicode);
            }
        }
    }
}
