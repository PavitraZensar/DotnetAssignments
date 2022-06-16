<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Question2.Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
<div>
</div>
Select Any Car : <asp:DropDownList ID="DropDownList1" runat="server" Height="15px" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br/>
<asp:Image ID="Benz" runat="server" Height="300px" style="margin-left: 30px; margin-top: 37px" Width="480px" ImageUrl="~/Images/Benz.jfif" />
<p>
The Price of this Car : <asp:Button ID="Price" runat="server" OnClick="Button1_Click1" style="margin-left: 43px" Text="Price" Width="119px" />
</p>
<p>
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-top: 0px" Width="140px"></asp:TextBox>
</p>
</form>
</body>
</html>
