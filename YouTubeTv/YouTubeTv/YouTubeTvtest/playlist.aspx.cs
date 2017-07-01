using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace YouTubeTvtest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
           

            string videoImageClass = "videoimage";
            string videoDescriptionClass = "videodescription";
            List<YouTubeTv.CreatePlayList> createlist = new List<YouTubeTv.CreatePlayList>();
            YouTubeTv.CreatePlayList video1 = new YouTubeTv.CreatePlayList();
            YouTubeTv.CreatePlayList video2 = new YouTubeTv.CreatePlayList();
            YouTubeTv.CreatePlayList video3 = new YouTubeTv.CreatePlayList();
            YouTubeTv.CreatePlayList video4 = new YouTubeTv.CreatePlayList();
            YouTubeTv.CreatePlayList video5 = new YouTubeTv.CreatePlayList();

               
            video1.VideoUrl = "https://youtu.be/XPoiPZYbtnA";
            video1.Description = "<b>Kernkraft</b> 400 Sports Remix " + "<a href='" + video1.VideoUrl + "' target='_blank'> see on web</a><br/><br/>";
            video1.DescriptionCSS = videoDescriptionClass;
            video1.ImageCSS = videoImageClass;

            video2.VideoUrl = "http://youtu.be/0SdqOC8NA7s";
            video2.Description = "<b> Gigi D'Agostino </b>Another Way" + "<a href='" + video2.VideoUrl + "' target='_blank'> see on web</a><br/><br/>";
            video2.DescriptionCSS=videoDescriptionClass;
            video2.ImageCSS = videoImageClass;

            video3.VideoUrl = "http://youtu.be/5W_wd9Qf0IE";
            video3.Description = "<b>Code Monkey AMV</b> This AMV features the song Code Monkey by Jonathan Coulton, using footage from the anime Black Heaven." + "<a href='" + video3.VideoUrl + "' target='_blank'> see on web</a><br/><br/>";
            video3.DescriptionCSS = videoDescriptionClass;
            video3.ImageCSS = videoImageClass;

            video4.VideoUrl = "http://youtu.be/v9hdMSr6Duc";
            video4.Description = "<b>Ace of Base</b> Beautiful Life" + "<a href='" + video4.VideoUrl + "' target='_blank'> see on web</a><br/><br/>";
            video4.DescriptionCSS = videoDescriptionClass;
            video4.ImageCSS = videoImageClass;

            video5.VideoUrl = "https://youtu.be/Rg4HQ1RhhYk";
            video5.Description = "Alerta Roja- Daddy Yankee Ft varios artistas (Video Oficial)" + "<a href='" + video5.VideoUrl + "' target='_blank'> see on web</a><br/><br/>";
            video5.DescriptionCSS = videoDescriptionClass;
            video5.ImageCSS = videoImageClass;



   
     
            createlist.Add(video1);
            createlist.Add(video2);
            createlist.Add(video3);
            createlist.Add(video4);
            createlist.Add(video5);
    

            YouTubeTv.PlayList createplaylist = new YouTubeTv.PlayList();
            createplaylist.Load(this.playlistContainerdv, this.YoutubeScreenTV, createlist);          
            this.videoCountlbl.Text =Convert.ToString(createlist.Count) + " Videos on list";
            }
            catch (YouTubeTv.Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}