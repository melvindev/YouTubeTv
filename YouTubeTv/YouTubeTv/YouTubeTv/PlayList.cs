using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
namespace YouTubeTv
{
    /// <summary>
    /// Create a play list and shows the play list to a client ready to play
    /// </summary>
   public class PlayList
    {
       private  System.Web.UI.HtmlControls.HtmlIframe  ScreenTv { get; set; }
       /// <summary>
       /// Load a play-list created
       /// </summary>
       /// <param name="playlistContainer">Panel where the play list will be populated</param>
       /// <param name="screentv">Frame where the video will be played</param>
       /// <param name="PlayList">The play list created with the class 'CreatePlayList'</param>
       public void Load(System.Web.UI.WebControls.Panel playlistContainer, System.Web.UI.HtmlControls.HtmlIframe screentv, List<CreatePlayList> PlayList)
       {
           screentv.Style.Add("border", "0");
           screentv.Style.Add("background-color", "black");
           
           this.ScreenTv = screentv;
           CreatePlayList getList = new CreatePlayList();
           DetectURL detecturl=new DetectURL();
           ImageButton img = new ImageButton();
           Label descriptionlabel = new Label();      
           foreach (var link in PlayList)
           {
               if (detecturl.IsValidURL(link.VideoUrl))
               {   
               getList.VideoUrl = link.VideoUrl;
               YouTubeTv.YouTube TV = new YouTubeTv.YouTube(link.VideoUrl);
               img = new ImageButton();
               img.ImageUrl = TV.VideoImageUrl;
               img.CommandArgument = TV.VideoUrl;
               img.Attributes.Add("class", link.ImageCSS);              
               img.Click += Image_Click;
               descriptionlabel = new Label();
               descriptionlabel.Text = link.Description;
               descriptionlabel.Attributes.Add("class", link.DescriptionCSS);
               playlistContainer.Controls.Add(img);          
               playlistContainer.Controls.Add(descriptionlabel);
               }

               else
               {
                   YouTubeTv.Exception excep = new YouTubeTv.Exception("Invalid URI , YouTube URL must starts with a Protocol (http:// or https://) error found on URL --> " + link.VideoUrl, new YouTubeTv.Exception("Invalid URI, an error has been found with an invalid Protocol on URL --> " + link.VideoUrl + " URL must starts with (http:// or https://)"));
                   throw excep;  
               }
           }
       }
        private void Image_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (sender is ImageButton)
            {           
                ImageButton imgButton = (ImageButton)sender;
                this.ScreenTv.Src = imgButton.CommandArgument;                                
            }    
        }
    }   

    /// <summary>
    /// Create a new play list
    /// </summary>
   public class CreatePlayList
   {
    string _videourl;
    /// <summary>
    ///  Set or get the video url of the play list
    /// </summary>
    public   string VideoUrl
       {
           get { return _videourl; }
           set { _videourl = value; }
       }
    private string _description;
       /// <summary>
    /// Description of the video 'normal it appear at the bottom of the image but you can style it with 'DescriptionCSS' property
       /// </summary>
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    private string _descriptionCSS;
       /// <summary>
       /// 'CSS Class' style the description object example: All CSS styles like 'color,font-size etc. you must create a CSS Class'
       /// </summary>
    public string DescriptionCSS
    {
        get { return _descriptionCSS; }
        set { _descriptionCSS = value; }
    }
    private string _imageCSS;
       /// <summary>
    ///'CSS Class' style the Image object example: All CSS styles like 'color,font-size etc. you must create a CSS Class'
       /// </summary>
    public string ImageCSS
    {
        get { return _imageCSS;  }
        set { _imageCSS = value;}
    }
   }

}
