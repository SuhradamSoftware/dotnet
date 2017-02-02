<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertImage.aspx.cs" Inherits="Festivity.InsertImage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Image</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
            <br /><br /><br />
            Category Name: <asp:DropDownList ID="CategoryName" runat="server"></asp:DropDownList>
            <br /> 
            Image Path:<asp:FileUpload runat="server" ID="FileUpload1" /><br /> 
            <asp:Button runat="server" ID="cmd_Upload" Text="Upload Image" OnClick="InsertImage_Click" />
        </div>
    </form>
</body>
</html>
