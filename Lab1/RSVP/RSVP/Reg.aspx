<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="RSVP.Reg" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <div>
                <h1>Seminar invitation</h1>
                <p></p>
                
            </div>

            <div> 
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowModelStateErrors="true" />
                <label>Your name:</label>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" 
                    ErrorMessage="Fill out the name field" ForeColor="Red">Don&#39;t leave the field empty

                </asp:RequiredFieldValidator>
            </div> 
            <div> <label>Your email:</label><asp:TextBox ID="email" runat="server"></asp:TextBox> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Fill out the email field" ForeColor="Red" ControlToValidate="email">Don&#39;t leave the field empty

                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ErrorMessage="E-mail is not in a valid format" Display="Dynamic" ForeColor="Red" ControlToValidate="email">E-mail is incorrect

                </asp:RegularExpressionValidator>
            </div> 
            <div> <label>Your phone:</label><asp:TextBox ID="phone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ErrorMessage="Fill out the phone field" ForeColor="Red" ControlToValidate="email">Don&#39;t leave the field empty</asp:RequiredFieldValidator>
            </div> 
            <div> <label>Will you be giving a talk?</label> <asp:CheckBox ID="CheckBoxYN" runat="server" />
            </div>
            <div>
            <button type="submit">Submit an RSVP response</button>
            </div>
        </div>
</asp:Content>

        

