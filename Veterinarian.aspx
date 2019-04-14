<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Veterinarian.aspx.cs" Inherits="ZooApplication.Veterinarian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!----- PAGE TITLE ----->
    <div class="jumbotron">
        <h1>Veterinarian Portal</h1>
    </div>
    <div class="row">

        <!----- LEFT PANEL ------------------------------------------------------------------------------------------------------------>
        <div class ="col-md-5">
            <div class="form-horizontal">

            <!----- PANEL TITLE ------>
            <h2>Create New Record</h2>

                <!----- RECORD TYPE DROPDOWN ----->
                <div class="form-group">
                    <asp:Label ID="CreateRecordLabel" runat="server" CssClass="control-label col-md-3">Record Type:</asp:Label>
                    <div class="col-md-4">                    
                        <asp:DropDownList ID="CreateDropDown" AutoPostback="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="CreateDropDown_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Diet</asp:ListItem>
                            <asp:ListItem>Health Condition</asp:ListItem>
                            <asp:ListItem>Health Profile</asp:ListItem>
                            <asp:ListItem>Medication</asp:ListItem>
                            <asp:ListItem>Prescription</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!----- RECORD CREATION TEXTBOXES ----->
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <!----- RECORD INSERT & UPDATE BUTTONS ----->
                <div class="form-group">
                    <asp:Button ID="CreateBtn" runat="server" Text="Create Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="CreateBtn_Click"/>
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="UpdateBtn_Click"/>
                </div>
            </div>
        </div>
        <!----------------------------------------------------------------------------------------------------------------------------->

        <!----- RIGHT PANEL ----------------------------------------------------------------------------------------------------------->
        <div class ="col-md-5">
            <div class="form-horizontal">

                <!----- PANEL TITLE ------>
                <h2>View Existing Record</h2>

                <!----- RECORD SELECTION TYPE DROPDOWN ------>
                <div class="form-group">
                    <asp:Label ID="Label9" runat="server" CssClass="control-label col-md-3">Record Type:</asp:Label>
                    <div class="col-md-4">
                        <asp:DropDownList ID="SearchDropDown" CssClass="form-control" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Diet</asp:ListItem>
                            <asp:ListItem>Health Condition</asp:ListItem>
                            <asp:ListItem>Health Profile</asp:ListItem>
                            <asp:ListItem>Medication</asp:ListItem>
                            <asp:ListItem>Prescription</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!----- RECORD ID LABEL & TEXTBOX ------>
                <div class="form-group">
                    <asp:Label ID="SearchLabel" runat="server" CssClass="control-label col-md-3">Record ID:</asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="SearchInput" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>                    
                </div>

                <!----- RECORD SEARCH BUTTON ------>
                <div class="form-group">
                    <asp:Button ID="SearchBtn" runat="server" Text="Search" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="SearchBtn_Click"/>
                </div>

                <!----- SELECTION RESULTS ------>
                <div class="form-group">
                    <asp:GridView ID="SearchOutput" runat="server" EmptyDataText="Oops! Please enter a valid member ID."></asp:GridView>
                </div>
            </div>
        </div>
        <!----------------------------------------------------------------------------------------------------------------------------->
    </div>
</asp:Content>

