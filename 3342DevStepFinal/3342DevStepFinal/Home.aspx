<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_3342DevStepFinal.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/home.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-ctn">
        <!-- Begin Building -->
        <div class="content">
            <div class="row">
                <div class="col-md-12">

                    <h1>Triggered</h1>
                    <h3>Don't get upset planning a vacation, get Triggered!</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <h2>Start building your package!</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <a href="CarRental.aspx" class="box-ctn">
                        <i class="fa show fa-car fa-3x"></i>
                        <div class="box-hidden-text"><b>Rent a Car</b></div>
                    </a>
                </div>

                <div class="col-md-3">
                    <a href="Flight.aspx" class="box-ctn">
                        <i class="fa show fa-plane fa-3x"></i>
                        <div class="box-hidden-text"><b>Book a Flight</b></div>
                    </a>
                </div>

                <div class="col-md-3">
                    <a href="Hotel.aspx" class="box-ctn">
                        <i class="fa show fa-bed fa-3x"></i>
                        <div class="box-hidden-text"><b>Reserve a Hotel</b></div>
                    </a>
                </div>

                <div class="col-md-3">
                    <a href="Activity.aspx" class="box-ctn">
                        <i class="fa show fa-ticket-alt fa-3x"></i>
                        <div class="box-hidden-text"><b>Plan an Activity</b></div>
                    </a>
                </div>
            </div>
        </div>
        <!-- /Building -->
    </div>

</asp:Content>
