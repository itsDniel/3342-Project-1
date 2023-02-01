<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="processSandwich.aspx.cs" Inherits="project1.processSandwich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            z-index: 1;
            left: 489px;
            top: 275px;
            position: absolute;
        }
        #txtInput {
            z-index: 1;
            left: 531px;
            top: 299px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSummary" runat="server" style="z-index: 1; left: 351px; top: 40px; position: absolute; height: 438px; width: 811px;" BorderStyle="Solid"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 358px; top: 508px; position: absolute; width: 806px; height: 136px"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
