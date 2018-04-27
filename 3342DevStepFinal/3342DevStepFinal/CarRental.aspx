<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CarRental.aspx.cs" Inherits="_3342DevStepFinal.CarRental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/CarRental.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    <h3 class="panel-title">Rent a Car</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-2"></div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <asp:Label ID="lblCity" Text="Type in a city:" ForeColor="Black" runat="server"></asp:Label>
                                <asp:TextBox ID="txtCity" ForeColor="Black" CssClass="form-control" runat="server" Width="200px"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <asp:Label ID="lblState" Text="Choose a state:" ForeColor="Black" runat="server"></asp:Label>
                                <asp:DropDownList ID="ddlState" ForeColor="Black" CssClass="form-control" runat="server" Width="125px">
                                    <asp:ListItem>Select State</asp:ListItem>
                                    <asp:ListItem>AL</asp:ListItem>
                                    <asp:ListItem>AK</asp:ListItem>
                                    <asp:ListItem>AZ</asp:ListItem>
                                    <asp:ListItem>AR</asp:ListItem>
                                    <asp:ListItem>CA</asp:ListItem>
                                    <asp:ListItem>CO</asp:ListItem>
                                    <asp:ListItem>CT</asp:ListItem>
                                    <asp:ListItem>DE</asp:ListItem>
                                    <asp:ListItem>FL</asp:ListItem>
                                    <asp:ListItem>GA</asp:ListItem>
                                    <asp:ListItem>HI</asp:ListItem>
                                    <asp:ListItem>ID</asp:ListItem>
                                    <asp:ListItem>IL</asp:ListItem>
                                    <asp:ListItem>IN</asp:ListItem>
                                    <asp:ListItem>IA</asp:ListItem>
                                    <asp:ListItem>KS</asp:ListItem>
                                    <asp:ListItem>KY</asp:ListItem>
                                    <asp:ListItem>LA</asp:ListItem>
                                    <asp:ListItem>ME</asp:ListItem>
                                    <asp:ListItem>MD</asp:ListItem>
                                    <asp:ListItem>MA</asp:ListItem>
                                    <asp:ListItem>MI</asp:ListItem>
                                    <asp:ListItem>MN</asp:ListItem>
                                    <asp:ListItem>MS</asp:ListItem>
                                    <asp:ListItem>MO</asp:ListItem>
                                    <asp:ListItem>MT</asp:ListItem>
                                    <asp:ListItem>NE</asp:ListItem>
                                    <asp:ListItem>NV</asp:ListItem>
                                    <asp:ListItem>NH</asp:ListItem>
                                    <asp:ListItem>NJ</asp:ListItem>
                                    <asp:ListItem>NM</asp:ListItem>
                                    <asp:ListItem>NY</asp:ListItem>
                                    <asp:ListItem>NC</asp:ListItem>
                                    <asp:ListItem>ND</asp:ListItem>
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
                                    <asp:ListItem>VT</asp:ListItem>
                                    <asp:ListItem>VA</asp:ListItem>
                                    <asp:ListItem>WA</asp:ListItem>
                                    <asp:ListItem>WV</asp:ListItem>
                                    <asp:ListItem>WI</asp:ListItem>
                                    <asp:ListItem>WY</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <asp:Button ID="btnNext" Text="Next" CssClass="btn btn-default" runat="server" OnClick="btnNext_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="divSearchCars" runat="server">
                        <div class="row">
                            <div class="col-md-6">
                                <h3 style="color:black">Search by Agencies</h3>
                                <div class="form-group">
                                    <asp:Label ID="lblAgency" Text="Agencies:" ForeColor="Black" runat="server"></asp:Label>
                                    <asp:DropDownList ID="ddlAgencies" CssClass="form-control" runat="server" Width="150px"></asp:DropDownList>
                                </div>
                                <asp:Button ID="btnAgencies" Text="Search" CssClass="btn btn-default" runat="server" OnClick="btnAgencies_Click" />
                            </div>
                            <div class="col-md-6">
                                <h3 style="color:black">Search by Requirements</h3>
                                <div class="form-group">
                                    <asp:Label ID="lblPrice" Text="Price:"  ForeColor="Black" runat="server"></asp:Label>
                                    <asp:DropDownList ID="ddlPrice" CssClass="form-control" runat="server">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>150</asp:ListItem>
                                        <asp:ListItem>200</asp:ListItem>
                                        <asp:ListItem>250</asp:ListItem>
                                        <asp:ListItem>300</asp:ListItem>
                                        <asp:ListItem>350</asp:ListItem>
                                        <asp:ListItem>400</asp:ListItem>
                                        <asp:ListItem>450</asp:ListItem>
                                        <asp:ListItem>500</asp:ListItem>
                                        <asp:ListItem>550</asp:ListItem>
                                        <asp:ListItem>600</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblnumDoor" Text="Number of Doors:" ForeColor="Black" runat="server"></asp:Label>
                                    <asp:DropDownList ID="ddlnumDoor" CssClass="form-control" runat="server">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblEco" Text="Eco-Friendly:" ForeColor="Black" runat="server"></asp:Label>
                                    <asp:DropDownList ID="ddlEco" CssClass="form-control" runat="server">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>Yes</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblnumPassenger" Text="Number of Passengers:" ForeColor="Black" runat="server"></asp:Label>
                                    <asp:DropDownList ID="ddlnumPassenger" CssClass="form-control" runat="server">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                        <asp:ListItem>12</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:Button ID="btnRequirements" Text="Search" CssClass="btn btn-default" runat="server" OnClick="btnRequirements_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="divCars" style="text-align:center" runat="server">
                <div class="page-header">
                    <h3>Cars For You:</h3>
                </div>
                <div style="width:100%;text-align:center">
                    <div class="row">
                        <asp:Repeater ID="rptCars" runat="server" OnItemCommand="rptCars_ItemCommand">
                            <ItemTemplate>
                                <div class="col-md-3">
                                    <div class="panel panel-default">
                                        <div class="panel-body">
                                            <h5>
                                                <asp:Label ID="lblMake" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Make") %>' runat="server"></asp:Label>
                                                <asp:Label ID="lblModel" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Model") %>' runat="server"></asp:Label>
                                            </h5>
                                            <p style="color:black">
                                                Price: $
                                                <asp:Label ID="lblPriceCar" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Price") %>' runat="server"></asp:Label> <br />
                                                Number of Doors:
                                                <asp:Label ID="lblNumDoors" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Number_Doors") %>' runat="server"></asp:Label><br />
                                                Eco-Friendly:
                                                <asp:Label ID="lblEcoFriendly" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Eco_Friendly") %>' runat="server"></asp:Label><br />
                                                Number of Passengers:
                                                <asp:Label ID="lblNumberPass" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Number_Passenger") %>' runat="server"></asp:Label><br />
                                            </p>
                                            <asp:Button ID="btnAddCart" Text="Add To Cart" CssClass="btn btn-default" runat="server" />
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                <asp:Button ID="btnSearchAgain" Text="Search Again" CssClass="btn btn-default" runat="server" OnClick="btnSearchAgain_Click" />
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>
