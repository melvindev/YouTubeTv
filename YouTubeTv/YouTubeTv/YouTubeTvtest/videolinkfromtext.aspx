
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="videolinkfromtext.aspx.cs" Inherits="YouTubeTvtest.videolinkfromtext" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>YouTubeTv Library</title>
</head>
<body style="margin: 0">
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: black; color: #2390a4;">
            <h1 style="margin: 0;"><u>Playing Single Video using YouTubeTv Opensource Library</u></h1>
            <br />
        </div>
        <div style="text-align: center">
            <br />
            <br />
            <p style="font-size: xx-large">
                YoutubeTv Library allows you to play a video even if the link is inside of a text,
                <br />
                it looks for a first link found on the text then it will be able to play.                    
            </p>
            <p style="font-size: x-large">Write some text and add a youtube video URL and then press Load video Button,
                 then press the video image to play.</p>
            <asp:TextBox ID="VideoLinktxt" runat="server" TextMode="MultiLine"
                 Height="72px" Width="310px" Font-Size="Large"></asp:TextBox>
            <br />
            <asp:Button ID="loadVideobtn" runat="server" Text="Load Video" OnClick="loadVideobtn_Click" />
            <br />
            <br />
            <asp:ImageButton ID="VideoPosterImgBtn" runat="server" OnClick="VideoPosterImgBtn_Click" />
            <br />
            <iframe id="YoutubeScreenTV" runat="server" style="width: 725px; height: 400px"></iframe>
        </div>
    </form>
</body>
</html>
