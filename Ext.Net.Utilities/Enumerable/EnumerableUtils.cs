/*
 * @version   : 2.2.1
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-04-16
 * @copyright : Copyright (c) 2007-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System;
using System.Collections.Generic;

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class EnumerableUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static IEnumerable<T> Each<T>(this IEnumerable<T> instance, Action<T> action)
        {
            foreach (T item in instance)
            {
                action(item);
            }

            return instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static int Each<T>(this int instance, Action<int> action)
        {
            for (int i = 0; i < instance; i++)
            {
                action(i);
            } 

            return instance;
        }
    }
}