<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="_3342DevStepFinal.Activity" %>

<%@ Register Src="~/ActivityControl.ascx" TagPrefix="uc1" TagName="ActivityControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Activity.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:ActivityControl runat="server" id="ActivityControl" />

</asp:Content>
