using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Cozumpark.BrowserCapabilities
{
    public static class CozumparkBrowserCapabilities
    {

        public static BrowserCapabilities GetCapabilities(this HttpBrowserCapabilitiesBase browser)
        {
      

            BrowserCapabilities caps = new BrowserCapabilities
            {
                Browser = browser.Type,

                Version = browser.Version,
                MajorVersion = browser.MajorVersion.ToString(),
                MinorVersion = browser.MinorVersionString,
                Platform = browser.Platform,
                IsBeta = browser.Beta.ToString(),
                CrawlerInfo = browser.Crawler.ToString(),
                Aol = browser.AOL.ToString(),
                Win16 = browser.Win16.ToString(),
                Win32 = browser.Win32.ToString(),
                Frames = browser.Frames.ToString(),
                Tables = browser.Tables.ToString(),
                Cookie = browser.Cookies.ToString(),
                VbScript = browser.VBScript.ToString(),
                EcmaScriptVersion = browser.EcmaScriptVersion.Major.ToString(),
                JavaApplets = browser.JavaApplets.ToString(),
                ActiveXControls = browser.ActiveXControls.ToString(),
            //    JavaScriptVersion = browser.JavaScript.ToString() // this deprecated
            };




            return caps;

        }

    }

    public class BrowserCapabilities
    {
        public string BrowserType { get; set; }
        public string Browser { get; set; }

        public string Version { get; set; }
        public string MajorVersion { get; set; }
        public string MinorVersion { get; set; }
        public string Platform { get; set; }

        public string IsBeta { get; set; }
        public string CrawlerInfo { get; set; }
        public string Aol { get; set; }
        public string Win16 { get; set; }
        public string Win32 { get; set; }
        public string Frames { get; set; }
        public string Tables { get; set; }
        public string Cookie { get; set; }
        public string VbScript { get; set; }
        public string EcmaScriptVersion { get; set; }
        public string JavaApplets { get; set; }
        public string ActiveXControls { get; set; }
        public string JavaScriptVersion { get; set; }


    }
}
