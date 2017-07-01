using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace YouTubeTv
{ 
   /// <summary>
   /// Allows you to manipulate a YouTube Video link
   /// </summary>
    public class YouTube
    {   
        private string _videourl;
        /// <summary>
        /// Returns a video Url
        /// </summary>
        public string VideoUrl
        {
            get { return _videourl; }
        }
        private string _videoimageurl;
        /// <summary>
        /// Returns a video image Url
        /// </summary>
        public  string VideoImageUrl
        {
            get { return _videoimageurl; }       
        }
        private string _videoid;
        /// <summary>
        /// Returns the ID of the video URL
        /// </summary>
        public string VideoId
        {
            get { return _videoid; }  
        }

        private string _providedurl;
        /// <summary>
        /// Returns the original privided Url
        /// </summary>
        public string ProvidedUrl
        {
            get { return _providedurl; }
           
        }
        
        private string _height;
        /// <summary>
        /// Returns the Height of the video frame default '560'
        /// </summary>
        public string Height
        {
            get { return _height; }        
        }
        private string _width;
        /// <summary>
        /// Returns the Width of the video frame default '315'
        /// </summary>
        public string Width
        {
            get { return _width; }
        }
        /// <summary>
        /// YouTube
        /// </summary>
        /// <param name="Url">Youtube URL</param>
        /// <param name="width">Video frame width default is '560px'</param>
        /// <param name="height">Video frame height default is '315px'</param>
        public YouTube(string Url, string width="560px", string height="315px"){
        YouTubeTv.DetectURL detectURL = new YouTubeTv.DetectURL();
       this._videourl = GetYouTube(detectURL.DetectURLLInk(Url), false);
       this._videoimageurl = GetYouTube(detectURL.DetectURLLInk(Url),  true);
        this._height = height;
        this._width = width;    
    }
        /// <summary>
        /// YouTube
        /// </summary>
        /// <param name="Url">Youtube URL</param>
    public YouTube(string Url)
    {
        YouTubeTv.DetectURL detectURL = new YouTubeTv.DetectURL();
       this._videourl = GetYouTube(detectURL.DetectURLLInk(Url), false);
        this._videoimageurl = GetYouTube(detectURL.DetectURLLInk(Url), true);
        this._width = "560px";
        this._height = "315px";      
    }
        /// <summary>
        /// Returns a YouTube Video or a YouTube video image.
        /// </summary>
        /// <param name="Url">YouTube video URL</param>
        /// <param name="UseImage">True:Returns the image of the YouTube video URL, False:Returns the video Frame  </param>
        /// <returns></returns>
        private string GetYouTube(string Url, bool UseImage)
        {
            DetectURL detectURL = new DetectURL();
            Uri checkYouTubeURL = new Uri(Url);
            if (checkYouTubeURL.Host == "youtu.be" || checkYouTubeURL.Host == "www.youtu.be" || checkYouTubeURL.Host == "youtube.com" || checkYouTubeURL.Host == "www.youtube.com")
            {
                if (Url.IndexOf("&list") != -1)
                {
                    Url = Url.Remove(Url.IndexOf("&list"));
                }
                else if (Url.IndexOf("?list") != -1)
                {
                    Url = Url.Remove(Url.IndexOf("?list"));
                }
                string[] IndexedOn = Url.Split('/', '=');

                _videoid = IndexedOn[IndexedOn.GetUpperBound(0)];
                _providedurl = Url;
                if (UseImage == true)
                {
                    return "https://img.youtube.com/vi/" + IndexedOn[IndexedOn.GetUpperBound(0)] + "/default.jpg";
                }
                else
                {
                    return "https://www.youtube.com/v/" + IndexedOn[IndexedOn.GetUpperBound(0)] + "&autoplay=1&rel=0";
                }
            }

            else
            {
            YouTubeTv.Exception excep = new YouTubeTv.Exception("There is an invalid YouTube URL.", new YouTubeTv.Exception("There is an invalid YouTube URL. " + checkYouTubeURL.ToString()));
            throw excep;                                 
            }

           
        }

    }
}
