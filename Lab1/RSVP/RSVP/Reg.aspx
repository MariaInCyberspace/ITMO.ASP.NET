<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="RSVP.Reg" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>

        

