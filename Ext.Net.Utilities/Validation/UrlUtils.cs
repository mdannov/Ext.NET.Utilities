/*
 * @version: 2.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2011-09-01
 * @copyright: Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsUrl(string url)
        {
            return (!string.IsNullOrEmpty(url) && url.IndexOf("://") >= 0);
        }
    }
}
