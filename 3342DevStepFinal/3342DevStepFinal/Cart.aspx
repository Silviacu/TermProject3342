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
            <asp:GridView ID="gvCars" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:BoundField DataField="Description" HeaderText="Item Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField HeaderText="Subtotal" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="txtQuantity" runat="server" HeaderText="New Quantity"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateCar" runat="server" Text="Update quantity" OnClick="btnUpdateCar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDeleteCar" runat="server" Text="Remove from cart" OnClick="btnDeleteCar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div id="flight" style="color:black">
        <i class="fa show fa-plane fa-7x"></i>
            Flight Reservations:
            <asp:GridView ID="gvFlights" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Description" HeaderText="Item Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField HeaderText="Subtotal" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="txtQuantity" runat="server" HeaderText="New Quantity"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateFlight" runat="server" Text="Update quantity" OnClick="btnUpdateFlight_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDeleteFlight" runat="server" Text="Remove from cart" OnClick="btnDeleteFlight_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div id="hotel" style="color:black">
        <i class="fa show fa-bed fa-7x"></i>
            Hotel Reservations:
            <asp:GridView ID="gvHotels" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Description" HeaderText="Item Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField HeaderText="Subtotal" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="txtQuantity" runat="server" HeaderText="New Quantity"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateHotel" runat="server" Text="Update quantity" OnClick="btnUpdateHotel_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDeleteHotel" runat="server" Text="Remove from cart" OnClick="btnDeleteHotel_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div id="activity" style="color:black">
        <i class="fa show fa-ticket-alt fa-7x"></i>
            Activities Reservations:
            <asp:GridView ID="gvActivity" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Description" HeaderText="Item Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField HeaderText="Subtotal" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="txtQuantity" runat="server" HeaderText="New Quantity"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateEvent" runat="server" Text="Update quantity" OnClick="btnUpdateEvent_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDeleteEvent" runat="server" Text="Remove from cart" OnClick="btnDeleteEvent_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <hr />

            <strong>Total: $</strong><asp:Label ID="lblTotal" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
