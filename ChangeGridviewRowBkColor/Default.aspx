﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChangeGridviewRowBkColor.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .redbackground {
             background-color: #f2283a;
             color: White;
        }
    </style>
    <script type="text/javascript">
        setTimeout("location.reload(true)", 60000);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound">
            
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
