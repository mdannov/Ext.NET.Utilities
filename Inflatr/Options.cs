/********
 * @version   : 1.3.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-29
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net.Utilities.Inflatr
{
    public class Options
    {
        private int wrap = 80;
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

        public Options Clone()
        {
            return new Options { Indent = this.Indent, Wrap = this.Wrap, Level = this.Level };
        }
    }
}
