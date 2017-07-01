<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="YouTubeTvtest._default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .button1 {
            background-color: blue;
            width: 200px;
            font-size:30px;color:white;padding:20px
        
        }

        .button2 {
            background-color: green;
            width: 200px; font-size:30px;
                  font-size:30px;color:white;padding:20px
     
        }
    </style>
</head>
<body style="margin: 0">
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: black; color: #2390a4;">
            <h1 style="margin: 0;"><u>Playing Single Video using YouTubeTv Opensource Library</u></h1>
            <br />
        </div>
        <div style="text-align: center;margin-top:200px">
        
            
            <a href="playlist.aspx" class="button1">Play List Sample</a>
             <a href="videolinkfromtext.aspx" class="button2">Link and text Sample</a>
        </div>
      

     
    </form>
</body>
</html>
