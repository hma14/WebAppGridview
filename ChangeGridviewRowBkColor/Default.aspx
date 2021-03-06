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

        .errorMessage {
            color: orangered;
        }
    </style>
    <script type="text/javascript">
        setTimeout("location.reload(true)", 60000);
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="BusinessEntityID" HeaderText="BusinessEntity ID" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                    <asp:BoundField DataField="numPhones" HeaderText="numPhones" />                  
                </Columns>
            </asp:GridView>

            <br />
            <asp:Label ID="ErrorMessage" runat="server" Text="" Visible="false" CssClass="errorMessage"></asp:Label>

        </div>
    </form>
</body>
</html>
