<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="_3342DevStepFinal.Hotel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Hotel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1><i class="fa show fa-bed fa-3x"></i>Triggered Hotels</h1>
    <div>
        <div class="col-md-12">
            <!-- State / City Filter -->
            <table style="color:black;">
                <tr>
                    <td>
                        <h4>Search for hotels in:</h4>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>City: </td>
                    <td><asp:TextBox ID="txtCity" runat="server" /></td>

                    <td></td>
                    <td>State: </td>
                    <td>
                        <asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem>AK</asp:ListItem>
                            <asp:ListItem>AL</asp:ListItem>
                            <asp:ListItem>AR</asp:ListItem>
                            <asp:ListItem>AZ</asp:ListItem>
                            <asp:ListItem>CA</asp:ListItem>
                            <asp:ListItem>CO</asp:ListItem>
                            <asp:ListItem>CT</asp:ListItem>
                            <asp:ListItem>DE</asp:ListItem>
                            <asp:ListItem>FL</asp:ListItem>
                            <asp:ListItem>GA</asp:ListItem>
                            <asp:ListItem>HI</asp:ListItem>
                            <asp:ListItem>IA</asp:ListItem>
                            <asp:ListItem>ID</asp:ListItem>
                            <asp:ListItem>IL</asp:ListItem>
                            <asp:ListItem>IN</asp:ListItem>
                            <asp:ListItem>KS</asp:ListItem>
                            <asp:ListItem>KY</asp:ListItem>
                            <asp:ListItem>LA</asp:ListItem>
                            <asp:ListItem>MA</asp:ListItem>
                            <asp:ListItem>MD</asp:ListItem>
                            <asp:ListItem>ME</asp:ListItem>
                            <asp:ListItem>MI</asp:ListItem>
                            <asp:ListItem>MN</asp:ListItem>
                            <asp:ListItem>MO</asp:ListItem>
                            <asp:ListItem>MS</asp:ListItem>
                            <asp:ListItem>MT</asp:ListItem>
                            <asp:ListItem>NC</asp:ListItem>
                            <asp:ListItem>ND</asp:ListItem>
                            <asp:ListItem>NE</asp:ListItem>
                            <asp:ListItem>NH</asp:ListItem>
                            <asp:ListItem>NJ</asp:ListItem>
                            <asp:ListItem>NM</asp:ListItem>
                            <asp:ListItem>NV</asp:ListItem>
                            <asp:ListItem>NY</asp:ListItem>
                            <asp:ListItem>OH</asp:ListItem>
                            <asp:ListItem>OK</asp:ListItem>
                            <asp:ListItem>OR</asp:ListItem>
                            <asp:ListItem>PA</asp:ListItem>
                            <asp:ListItem>RI</asp:ListItem>
                            <asp:ListItem>SC</asp:ListItem>
                            <asp:ListItem>SD</asp:ListItem>
                            <asp:ListItem>TN</asp:ListItem>
                            <asp:ListItem>TX</asp:ListItem>
                            <asp:ListItem>UT</asp:ListItem>
                            <asp:ListItem>VA</asp:ListItem>
                            <asp:ListItem>VT</asp:ListItem>
                            <asp:ListItem>WA</asp:ListItem>
                            <asp:ListItem>WI</asp:ListItem>
                            <asp:ListItem>WV</asp:ListItem>
                            <asp:ListItem>WY</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAdvanced" runat="server" Text="Advanced Search Options:" ></asp:Label></td>
                    <td><asp:CheckBox ID="cbCoffee" runat="server" Text="Has Free Coffee" /></td>
                    <td><asp:CheckBox ID="cbSmoking" runat="server" Text="Smoking" /></td>
                    <td><asp:CheckBox ID="cbWifi" runat="server" Text="WiFi" /></td>
                    <td><asp:CheckBox ID="cbKitchen" runat="server" Text="Kitchen" /></td>
                    <td><asp:CheckBox ID="cbBreakfast" runat="server" Text="Breakfast" /></td>
                </tr>
                <tr>
                    <td>Size Bed:</td>
                    <td>
                        <asp:DropDownList ID="ddlBed" runat="server">
                            <asp:ListItem>Twin</asp:ListItem>
                            <asp:ListItem>Queen</asp:ListItem>
                            <asp:ListItem>King</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSearch" runat="server" Text="Search for Hotels" OnClick="btnSearch_Click"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                </tr>
            </table>
        </div>
    </div>
<hr />
    <!-- /City & State Filter -->
    <div style="color:black;">
        <%--<asp:GridView ID="gvHotelResults" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="gvHotelResults_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="HotelID" HeaderText="HotelID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                    <ItemTemplate>
                        <asp:Button ID="btnSearchforRooms" runat="server" Text="Search for Rooms" OnClick="btnSearchforRooms_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>--%>                      
    </div>

    <div>
        <asp:GridView ID="gvRoomResults" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="HotelID" HeaderText="HotelID" />
                <asp:BoundField DataField="RoomID" HeaderText="RoomID" />
                <asp:BoundField DataField="CheckInDate" HeaderText="Check In Date" DataFormatString="{0:MMMM d, yyyy}" />
                <asp:BoundField DataField="CheckOutDate" HeaderText="Check Out Date" DataFormatString="{0:MMMM d, yyyy}" />
                <asp:BoundField DataField="NumberofBeds" HeaderText="Number of Beds" />
                <asp:BoundField DataField="HasFreeCoffeeField" HeaderText="Free Coffee" />
                <asp:BoundField DataField="IsSmokingAllowedField" HeaderText="Smoking Allowed" />
                <asp:BoundField DataField="HasFreeWifiField" HeaderText="Free Wifi" />
                <asp:BoundField DataField="BedSizeField" HeaderText="BedSize" />
                <asp:BoundField DataField="HasKitchenField" HeaderText="Kitchen" />
                <asp:BoundField DataField="FreeBreakfastField" HeaderText="Free Breakfast" />
                <asp:BoundField DataField="Reserved" HeaderText="Reserved" />
                <asp:BoundField DataField="CostPerNight" HeaderText="Price" DataFormatString="{0:C}" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnAddToCart" runat="server" OnClick="btnAddToCart_Click" Text="Add to Cart" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </div>
</asp:Content>
