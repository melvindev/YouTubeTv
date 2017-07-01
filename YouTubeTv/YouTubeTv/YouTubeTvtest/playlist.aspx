
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="playlist.aspx.cs" Inherits="YouTubeTvtest._default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>YouTubeTv PlayList</title>
    <style>
        .videoimage {
            margin-left: 1px;
            display: inline-block;
        }

            .videoimage:hover {
                border: 1px solid red;
            }

        .videodescription {
            font-size: 15px;
            color: black;
            font-style: italic;
            width: 150px;
            display: block;
        }
    </style>
</head>
<body style="background-color: #f2f7fb; margin: 0">
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: black; color: #2390a4;">
            <h1 style="margin: 0"><u>Playlist Video using YouTubeTv Opensource Library</u> </h1>
            <br />
        </div>
        <div style="width: 1000px; margin-left: auto; margin-right: auto;
          background-color: white">
            <br />
            <asp:Label ID="videoCountlbl" runat="server" Style="float: left" Font-Bold="true" 
                Font-Underline="true" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="playlistContainerdv" runat="server" Style="border-right: 1px solid #b1b1b1;
             float: left; width: 250px" ></asp:Panel>
            <iframe id="YoutubeScreenTV" runat="server" style="float: right; width: 725px; height: 
            400px" ></iframe>
            <br />
        </div>
    </form>
</body>
</html>
