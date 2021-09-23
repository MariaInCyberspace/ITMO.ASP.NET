<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="RSVP.Summary" %>

<%-- Added for the LINQ query to work --%>
<%@ Import Namespace="RSVP" %> 

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h2>Invitations</h2>

            <h3>Speakers:</h3>
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Phone</th>
                    </tr>
                </thead>
                <tbody>
                    <% var yesData = ResponseRepository.GetRepository().GetAllResponses()
                        .Where(r => r.WillAttend.Value);
                        foreach (var rsvp in yesData) 
                        { 
                            string htmlString = String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>", rsvp.Name, rsvp.Email, rsvp.Phone, rsvp.Rdata);
                        Response.Write(htmlString); 
                        } %>
                </tbody>
            </table>

                <h3>Will not be attending:</h3> 
            <table> 
                <thead> 
                    <tr> 
                        <th>Name</th> 
                        <th>Email</th> 
                        <th>Phone</th>
                    </tr>
                </thead>
                <tbody> 
                    <%= GetNoShowHtml() %> 
                </tbody>
            </table>
        </div>
    </asp:Content>
    

