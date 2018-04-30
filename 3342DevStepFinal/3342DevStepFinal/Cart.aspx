<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="_3342DevStepFinal.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><strong><i class="fas fa-cart-arrow-down fa-5x"></i> Shopping Cart</strong></h1>
    <h4>Please review your order below before confirming.</h4>
<hr />
    <div>
        <div id="car" style="color:black">
        <i class="fa show fa-car fa-7x"></i>
            Car Reservations:
            <div id="divCar" runat="server">
            </div>
        </div>

        <div id="flight" style="color:black">
        <i class="fa show fa-plane fa-7x"></i>
            Flight Reservations:
            <div id="divFlight" runat="server"></div>
        </div>

        <div id="hotel" style="color:black">
        <i class="fa show fa-bed fa-7x"></i>
            Hotel Reservations:
            <div id="divHotel" runat="server"></div>
        </div>

        <div id="activity" style="color:black">
        <i class="fa show fa-ticket-alt fa-7x"></i>
            Activities Reservations:
            <div id="divActivity" runat="server"></div>
            <hr />
        </div>
    </div>
    <br /><br />
    <div class="row"></div>
    <div class="row">&nbsp&nbsp&nbsp
        <strong>Total: $</strong><asp:Label ID="lblTotal" runat="server"></asp:Label>
    </div>
    <br /><br /><br />
</asp:Content>
