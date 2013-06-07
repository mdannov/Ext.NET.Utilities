/*
 * @version   : 2.2.1
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-04-16
 * @copyright : Copyright (c) 2007-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System.IO;

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public class FileUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                sr.Close();
                return text;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="value"></param>
        public static void WriteFile(string path, string value)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(value);
            sw.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="value"></param>
        public static void WriteToStart(string path, string value)
        {
            string temp = ReadFile(path);
            WriteFile(path, value.Trim() + temp.Trim());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="value"></param>
        public static void WriteToEnd(string path, string value)
        {
            string temp = ReadFile(path);
            WriteFile(path, temp.Trim() + value.Trim());
        }
    }
}
