using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace YouTubeTvtest
{
    public partial class videolinkfromtext : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.YoutubeScreenTV.Visible = false;
            this.VideoPosterImgBtn.Visible = false;
        }
        YouTubeTv.DetectURL detectURL = new YouTubeTv.DetectURL();
        protected void loadVideobtn_Click(object sender, EventArgs e)
        {                
            if (detectURL.IsValidURL(detectURL.DetectURLLInk(this.VideoLinktxt.Text)) == true)
            {
                YouTubeTv.YouTube TV = new YouTubeTv.YouTube(this.VideoLinktxt.Text);
                this.VideoPosterImgBtn.ImageUrl = TV.VideoImageUrl;
                this.VideoPosterImgBtn.Visible = true;
            }
            else
            {
                //message to the user
                Response.Write("Error");
            }
        }
        protected void VideoPosterImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (detectURL.IsValidURL(detectURL.DetectURLLInk(this.VideoLinktxt.Text)) == true)
            {
                YouTubeTv.YouTube TV = new YouTubeTv.YouTube(this.VideoLinktxt.Text, "650px", "400px");
                this.YoutubeScreenTV.Style.Add("width", TV.Width);
                this.YoutubeScreenTV.Style.Add("height", TV.Height);
                this.YoutubeScreenTV.Style.Add("border", "0");
                this.YoutubeScreenTV.Src = TV.VideoUrl;
                this.YoutubeScreenTV.Visible = true;
                this.VideoPosterImgBtn.Visible = false;               
            }
            else
            {
                //message to the user
                Response.Write("Error");
            }
        }

    }
}