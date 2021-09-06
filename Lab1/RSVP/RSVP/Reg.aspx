<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="RSVP.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Seminar invitation</h1>
                <p></p>
            </div>

            <div> 
                <label>Your name:</label><asp:TextBox ID="name" runat="server"></asp:TextBox>
            </div> 
            <div> <label>Your email:</label><asp:TextBox ID="email" runat="server"></asp:TextBox> 
            </div> 
            <div> <label>Your phone:</label><asp:TextBox ID="phone" runat="server"></asp:TextBox>
            </div> 
            <div> <label>Will you be giving a talk?</label> <asp:CheckBox ID="CheckBoxYN" runat="server" />
            </div>
            <div>
            <button type="submit">Submit an RSVP response</button>
            </div>
        </div>
    </form>
</body>
</html>
