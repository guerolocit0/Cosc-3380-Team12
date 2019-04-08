<%@ Page Title="Member Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberServices.aspx.cs" Inherits="ZooApplication.MemberServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Page Title -->
    <h1><%: Title %></h1>

    <div class="row">
        
        <!-- Add a New Member -->
        <div class ="col-md-7">
            <h2>Add a New Member</h2>

            <!-- User Input -->
            <div class="form-horizontal">

                <!-- Enter member type -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">Member type</asp:Label>
                    <asp:DropDownList ID="listMemberType" runat="server" />
                </div>

                <!-- Enter first name -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">First name</asp:Label>
                    <asp:TextBox ID="inFirstName" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter last name -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">Last name</asp:Label>
                    <asp:TextBox ID="inLastName" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter phone number -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">Phone number</asp:Label>
                    <asp:TextBox ID="inPhone" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter email address -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">Email address</asp:Label>
                    <asp:TextBox ID="inEmail" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter street address -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">Street address</asp:Label>
                    <asp:TextBox ID="inStreet" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter city -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">City</asp:Label>
                    <asp:TextBox ID="inCity" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>

                <!-- Enter state -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">State</asp:Label>
                    <asp:DropDownList ID="listState" runat="server" />
                </div>

                <!-- Enter ZIP code -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-2">ZIP code</asp:Label>
                    <asp:TextBox ID="inZIP" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
                </div>
            </div>
        </div>
        
        <!-- Search for an Existing Member -->
        <div class ="col-md-5">
            <h2>Search an Existing Member</h2>
        </div>
    </div>
</asp:Content>
