<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="ZooDataPRO.Administrator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ZooDataPRO</h1>
        <p class="lead">Welcome to ZooDataPRO Administrator Portal</p>
    </div>
    <h2>CREATE NEW RECORD:</h2>
    <div class="row">
        <asp:DropDownList ID="CreateDropDown" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CreateDropDown_SelectedIndexChanged">
            <asp:ListItem>ANIMAL</asp:ListItem>
            <asp:ListItem>ATTRACTION</asp:ListItem>
            <asp:ListItem>CONTACT</asp:ListItem>
            <asp:ListItem>DIET</asp:ListItem>
            <asp:ListItem>EMPLOYEE</asp:ListItem>
            <asp:ListItem>EMPLOYEE_PAY</asp:ListItem>
            <asp:ListItem>ENUM_ATTRACTION_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_DEPARTMENT</asp:ListItem>
            <asp:ListItem>ENUM_ECOSYSTEM</asp:ListItem>
            <asp:ListItem>ENUM_MEDICATION</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_PAY_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_SECTION</asp:ListItem>
            <asp:ListItem>ENUM_SPECIES</asp:ListItem>
            <asp:ListItem>ENUM_STATE</asp:ListItem>
            <asp:ListItem>ENUM_UNIT_MEASURE</asp:ListItem>
            <asp:ListItem>EXHIBIT</asp:ListItem>
            <asp:ListItem>HEALTH_CONDITION</asp:ListItem>
            <asp:ListItem>HEALTH_PROFILE</asp:ListItem>
            <asp:ListItem>JOB_POSITION</asp:ListItem>
            <asp:ListItem>MEMBERSHIP</asp:ListItem>
            <asp:ListItem>PAY_PERIOD</asp:ListItem>
            <asp:ListItem>PRESCRIPTION</asp:ListItem>
            <asp:ListItem>SCHEDULED_REPAIR</asp:ListItem>
            <asp:ListItem>SHIFT</asp:ListItem>
            <asp:ListItem>TREATMENT_PLAN</asp:ListItem>
            <asp:ListItem>USER_LOGINS</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="createBtn" runat="server" Text="Create New Record" OnClick="CreateBtn_Click" />
    </div>
    <div class="row">
        <asp:Label ID="createLbl1" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="createLbl2" runat="server" Text="att2" Width="120"></asp:Label>
        <asp:Label ID="createLbl3" runat="server" Text="att3" Width="120"></asp:Label>
        <asp:Label ID="createLbl4" runat="server" Text="att4" Width="120"></asp:Label>
        <asp:Label ID="createLbl5" runat="server" Text="att5" Width="120"></asp:Label>
        <asp:Label ID="createLbl6" runat="server" Text="att6" Width="120"></asp:Label>
        <asp:Label ID="createLbl7" runat="server" Text="att7" Width="120"></asp:Label>
        <asp:Label ID="createLbl8" runat="server" Text="att8" Width="120"></asp:Label>
        <asp:Label ID="createLbl9" runat="server" Text="att9" Width="120"></asp:Label>
    </div>
    <div class="row">
            <asp:TextBox ID="createTB1" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB2" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB3" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB4" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB5" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB6" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB7" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB8" runat="server" Width="120"></asp:TextBox>
            <asp:TextBox ID="createTB9" runat="server" Width="120"></asp:TextBox>
    </div>
    <p>&nbsp;</p>
    <h2>UPDATE EXISTING RECORD:</h2>
    <div class="row">
        <asp:DropDownList ID="UpdateDropDown" AutoPostBack="true" runat="server" OnSelectedIndexChanged="UpdateDropDown_SelectedIndexChanged">
            <asp:ListItem>ANIMAL</asp:ListItem>
            <asp:ListItem>ATTRACTION</asp:ListItem>
            <asp:ListItem>CONTACT</asp:ListItem>
            <asp:ListItem>DIET</asp:ListItem>
            <asp:ListItem>EMPLOYEE</asp:ListItem>
            <asp:ListItem>EMPLOYEE_PAY</asp:ListItem>
            <asp:ListItem>ENUM_ATTRACTION_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_DEPARTMENT</asp:ListItem>
            <asp:ListItem>ENUM_ECOSYSTEM</asp:ListItem>
            <asp:ListItem>ENUM_MEDICATION</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_PAY_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_SECTION</asp:ListItem>
            <asp:ListItem>ENUM_SPECIES</asp:ListItem>
            <asp:ListItem>ENUM_STATE</asp:ListItem>
            <asp:ListItem>ENUM_UNIT_MEASURE</asp:ListItem>
            <asp:ListItem>EXHIBIT</asp:ListItem>
            <asp:ListItem>HEALTH_CONDITION</asp:ListItem>
            <asp:ListItem>HEALTH_PROFILE</asp:ListItem>
            <asp:ListItem>JOB_POSITION</asp:ListItem>
            <asp:ListItem>MEMBERSHIP</asp:ListItem>
            <asp:ListItem>PAY_PERIOD</asp:ListItem>
            <asp:ListItem>PRESCRIPTION</asp:ListItem>
            <asp:ListItem>SCHEDULED_REPAIR</asp:ListItem>
            <asp:ListItem>SHIFT</asp:ListItem>
            <asp:ListItem>TREATMENT_PLAN</asp:ListItem>
            <asp:ListItem>USER_LOGINS</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="updateTB10" runat="server">Primary Key</asp:TextBox>
        <asp:Button ID="showBtn" runat="server" Text="Show Existing Record" OnClick="ShowBtn_Click" />
        <asp:Button ID="updateBtn" runat="server" Text="Update Record" OnClick="UpdateBtn_Click" />
        <asp:TextBox ID="colBox" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Label ID="updateLbl1" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl2" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl3" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl4" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl5" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl6" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl7" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl8" runat="server" Text="att1" Width="120"></asp:Label>
        <asp:Label ID="updateLbl9" runat="server" Text="att1" Width="120"></asp:Label>
    </div>
    <div class="row">
        <asp:TextBox ID="updateTB1" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB2" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB3" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB4" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB5" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB6" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB7" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB8" runat="server" Width="120"></asp:TextBox>
        <asp:TextBox ID="updateTB9" runat="server" Width="120"></asp:TextBox>
    </div>
    <p>&nbsp;</p>
    <h2>FIND RECORD:</h2>
    <div class="row">
        <asp:DropDownList ID="FindDropDown" AutoPostBack="true" runat="server" OnSelectedIndexChanged="FindDropDown_SelectedIndexChanged">
            <asp:ListItem>ANIMAL</asp:ListItem>
            <asp:ListItem>ATTRACTION</asp:ListItem>
            <asp:ListItem>CONTACT</asp:ListItem>
            <asp:ListItem>DIET</asp:ListItem>
            <asp:ListItem>EMPLOYEE</asp:ListItem>
            <asp:ListItem>EMPLOYEE_PAY</asp:ListItem>
            <asp:ListItem>ENUM_ATTRACTION_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_DEPARTMENT</asp:ListItem>
            <asp:ListItem>ENUM_ECOSYSTEM</asp:ListItem>
            <asp:ListItem>ENUM_MEDICATION</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_STATUS</asp:ListItem>
            <asp:ListItem>ENUM_MEMBERSHIP_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_PAY_TYPE</asp:ListItem>
            <asp:ListItem>ENUM_SECTION</asp:ListItem>
            <asp:ListItem>ENUM_SPECIES</asp:ListItem>
            <asp:ListItem>ENUM_STATE</asp:ListItem>
            <asp:ListItem>ENUM_UNIT_MEASURE</asp:ListItem>
            <asp:ListItem>EXHIBIT</asp:ListItem>
            <asp:ListItem>HEALTH_CONDITION</asp:ListItem>
            <asp:ListItem>HEALTH_PROFILE</asp:ListItem>
            <asp:ListItem>JOB_POSITION</asp:ListItem>
            <asp:ListItem>MEMBERSHIP</asp:ListItem>
            <asp:ListItem>PAY_PERIOD</asp:ListItem>
            <asp:ListItem>PRESCRIPTION</asp:ListItem>
            <asp:ListItem>SCHEDULED_REPAIR</asp:ListItem>
            <asp:ListItem>SHIFT</asp:ListItem>
            <asp:ListItem>TREATMENT_PLAN</asp:ListItem>
            <asp:ListItem>USER_LOGINS</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="findTB" runat="server">Keyword</asp:TextBox>
        <asp:Button ID="findBtn" runat="server" Text="Search" OnClick="FindBtn_Click" />
    </div>
    <div class="row">
        <asp:TextBox ID="foundTB" runat="server" TextMode="MultiLine" Rows="6" Columns="100"></asp:TextBox>
        <br />
        <br />
    </div>
</asp:Content>

