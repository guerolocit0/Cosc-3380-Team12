<%@ Page Title="Maintenance" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Maintenance.aspx.cs" Inherits="ZooApplication.Maintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Page Title -->
    <h1><%: Title %></h1>

    <div class="row">
        
        <!-- View Upcoming Scheduled Repairs -->
        <div class="col-md-6">
            <h2>View Upcoming Scheduled Repairs</h2>

            <!-- User Input -->
            <div class="form-horizontal">

                <!-- Select Date -->
                <asp:Calendar ID="calendar" runat="server">
                    <SelectedDayStyle BackColor="LightGray" />
                    <OtherMonthDayStyle ForeColor="LightGray" />
                </asp:Calendar>

                <!-- Query Output -->
                <asp:GridView ID="orderInfo" runat="server" EmptyDataText="You have no repairs scheduled for today."></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
