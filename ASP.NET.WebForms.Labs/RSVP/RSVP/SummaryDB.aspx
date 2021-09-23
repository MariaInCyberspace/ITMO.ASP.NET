<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SummaryDB.aspx.cs" Inherits="RSVP.SummaryDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Attendees list<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="RSVP.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
        </asp:LinqDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="E-mail" ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" SortExpression="Phone" />
                <asp:CheckBoxField DataField="WillAttend" HeaderText="Will Attend" ReadOnly="True" SortExpression="WillAttend" />
                <asp:BoundField DataField="Rdata" DataFormatString="{0:d}" HeaderText="Registration date" ReadOnly="True" SortExpression="Rdata" />
            </Columns>
        </asp:GridView>
    </h2>
</asp:Content>
