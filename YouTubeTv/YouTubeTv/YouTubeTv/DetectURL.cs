using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTv
{
   public  class DetectURL
    {     
        string OutputURL;
        /// <summary>
        /// Detect the First Link in the specified text.
        /// </summary>
        public string DetectURLLInk( string FindLinksInText)
        {
            if (FindLinksInText.IndexOf("http://") != -1)
            {
                string ObtainURL = FindLinksInText.Substring(FindLinksInText.IndexOf("http://"));
                if (ObtainURL.Contains(" "))
                {
                    OutputURL = ObtainURL.Remove(ObtainURL.IndexOf(" "));
                }
                else
                {
                   OutputURL = ObtainURL;
                }
            }
            else if (FindLinksInText.IndexOf("https://") != -1)
            {

                string ObtainURL = FindLinksInText.Substring(FindLinksInText.IndexOf("https://"));

                if (ObtainURL.Contains(" "))
                {
                    OutputURL = ObtainURL.Remove(ObtainURL.IndexOf(" "));
                }
                else
                {
                    OutputURL = ObtainURL;
                }
            }
            else
            {
                OutputURL = "";
            }
            return OutputURL;
        }
        /// <summary>
        /// Checks if the URL is Valid 'http://' 
        /// </summary>
        /// <param name="CheckURL"></param>
        /// <returns></returns>
        public bool IsValidURL(string CheckURL)
        {
            if (CheckURL.IndexOf("http://") != -1 || CheckURL.IndexOf("https://") != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
