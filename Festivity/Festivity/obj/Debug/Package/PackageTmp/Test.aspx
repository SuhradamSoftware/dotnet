<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Festivity.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Get Screen Resolution using JavaScript</title>
<script type="text/javascript" language="javascript">
    function GetResolution() {
        document.getElementById("txtWidth").value = screen.width;
        document.getElementById("txtHight").value = screen.height;
    }
</script>
</head>
<body onload="GetResolution();">
<form runat="server">
<table>
<tr><td align="center" colspan="2">
<b><span style="color: #990000;">Your Screen Resolution </span></b></td></tr>
<tr>
<td>Width :</td>
<td valign="middle"><asp:TextBox ID="txtWidth" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td>Height :</td>
<td valign="middle"><asp:TextBox ID="txtHight" runat="server"></asp:TextBox></td>
</tr>
</table>
</form>
</body>
</html>
