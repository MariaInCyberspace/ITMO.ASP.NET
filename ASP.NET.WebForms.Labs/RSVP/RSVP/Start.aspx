<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="RSVP.Start" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div>
    <div class="rek">
                <h1>Invitation to the seminar<asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </h1>
                <p>You're invited to our seminar!</p>
                <p>Please, confirm your attendance by filling out the registration form</p>
            </div>
            <div class="info">
                The seminar will be held on the 1st of January, 2021 at 7.30 pm
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer runat="server" Interval="1000"></asp:Timer>
                            <% DateTime dataseminar = new DateTime(2018,1,1,7,30,0); 
                                DateTime dnow = DateTime.Now; 
                                int rd = (dataseminar - dnow).Days; int rm = (dataseminar - dnow).Minutes; 
                                int rsec = (dataseminar - dnow).Seconds; 
                            %>
                        <h3>Time till the seminar starts: <%=rd.ToString()%> days, <%=rm.ToString()%> minutes and <%=rsec.ToString()%> seconds</h3>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
    </div>
</asp:Content>