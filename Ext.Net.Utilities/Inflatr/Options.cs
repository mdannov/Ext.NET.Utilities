/*
 * @version   : 2.2.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-03-20
 * @copyright : Copyright (c) 2007-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

namespace Ext.Net.Utilities.Inflatr
{
    /// <summary>
    /// 
    /// </summary>
    public class Options
    {
        private int wrap = 80;

        /// <summary>
        /// 
        /// </summary>
        public int Wrap
        {
            get
            {
                return this.wrap;
            }
            set
            {
                this.wrap = value;
            }
        }

        private string indent = "  ";
        
        /// <summary>
        /// 
        /// </summary>
        public string Indent
        {
            get
            {
                return this.indent;
            }
            set
            {
                this.indent = value;
            }
        }

        private int level = 0;
        
        /// <summary>
        /// 
        /// </summary>
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Options Clone()
        {
            return new Options { Indent = this.Indent, Wrap = this.Wrap, Level = this.Level };
        }
    }
}
