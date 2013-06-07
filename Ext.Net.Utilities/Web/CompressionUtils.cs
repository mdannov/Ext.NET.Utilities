/*
 * @version   : 2.2.1
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-04-16
 * @copyright : Copyright (c) 2007-2013, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System.IO;
using System.IO.Compression;
using System.Text;
using System.Web;

namespace Ext.Net.Utilities
{
    public class CompressionUtils
    {
        public static void GZipAndSend(object instance)
        {
            CompressionUtils.GZipAndSend((instance != null) ? instance.ToString() : "");
        }

        public static void GZipAndSend(string instance)
        {
            CompressionUtils.GZipAndSend(instance, "application/json");
        }

        public static void GZipAndSend(string instance, string responseType)
        {
            CompressionUtils.GZipAndSend(Encoding.UTF8.GetBytes(instance), responseType);
        }

        public static void GZipAndSend(byte[] instance, string responseType)
        {
            if (CompressionUtils.IsGZipSupported)
            {
                CompressionUtils.Send(CompressionUtils.GZip(instance), responseType, true);
            }
            else
            {
                CompressionUtils.Send(instance, responseType);
            }
        }

        public static void Send(byte[] instance, string responseType)
        {
            CompressionUtils.Send(instance, responseType, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="responseType"></param>
        public static void Send(byte[] instance, string responseType, bool isGZip)
        {
            HttpResponse response = HttpContext.Current.Response;

            if (isGZip)
            {
                response.AppendHeader("Content-Encoding", "gzip");
                response.Charset = "utf-8";
            }

            response.ContentType = responseType;
            response.BinaryWrite(instance);
        }

        public static byte[] GZip(string instance)
        {
            return CompressionUtils.GZip(Encoding.UTF8.GetBytes(instance));
        }

        public static byte[] GZip(byte[] instance)
        {
            MemoryStream stream = new MemoryStream();
            GZipStream zipstream = new GZipStream(stream, CompressionMode.Compress);
            zipstream.Write(instance, 0, instance.Length);
            zipstream.Close();

            return stream.ToArray();
        }

        public static bool IsGZipSupported
        {
            get
            {
                HttpRequest request = HttpContext.Current.Request;

                bool ie6 = request.Browser.IsBrowser("IE") && request.Browser.MajorVersion <= 6;
                string encoding = (request.Headers["Accept-Encoding"] ?? "").ToLowerInvariant();

                return !ie6 && encoding.Contains("gzip", "deflate");
            }
        }
    }
}
