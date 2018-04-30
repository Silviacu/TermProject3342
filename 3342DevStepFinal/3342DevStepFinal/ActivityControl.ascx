<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActivityControl.ascx.cs" Inherits="_3342DevStepFinal.ActivityControl" %>

<div class="row">
    <div class="col-md-2"></div>
    <div class="col-md-8">
        <div class="panel panel-danger">
            <div class="panel-heading">
                <h3 class="panel-title">Book an Activity</h3>
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
                <div id="divSearchActivities" runat="server">
                    <div class="row">
                        <div class="col-md-6">
                            <h3 style="color:black">Search by Agencies</h3>
                            <div class="form-group">
                                <asp:Label ID="lblAgency" Text="Agencies:" ForeColor="Black" runat="server"></asp:Label>
                                <asp:DropDownList ID="ddlAgencies" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <asp:Button ID="btnAgencies" Text="Search" CssClass="btn btn-default" runat="server" OnClick="btnAgencies_Click" />
                        </div>
                        <div class="col-md-6">
                            <h3 style="color:black">Search by Criteria</h3>
                            <div class="form-group">
                                <asp:Label ID="lblType" Text="Activity Type:" ForeColor="Black" runat="server"></asp:Label>
                                <asp:DropDownList ID="ddlType" CssClass="form-control" runat="server">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>Concert</asp:ListItem>
                                    <asp:ListItem>Sky Diving</asp:ListItem>
                                    <asp:ListItem>Scuba Diving</asp:ListItem>
                                    <asp:ListItem>Boat Party</asp:ListItem>
                                    <asp:ListItem>Snorkeling</asp:ListItem>
                                    <asp:ListItem>Paragliding</asp:ListItem>
                                    <asp:ListItem>Jet Skiing</asp:ListItem>
                                    <asp:ListItem>Theme Party</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblPrice" Text="Price:" ForeColor="Black" runat="server"></asp:Label>
                                <asp:DropDownList ID="ddlPrice" CssClass="form-control" runat="server">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                    <asp:ListItem>150</asp:ListItem>
                                    <asp:ListItem>200</asp:ListItem>
                                    <asp:ListItem>250</asp:ListItem>
                                    <asp:ListItem>300</asp:ListItem>
                                    <asp:ListItem>350</asp:ListItem>
                                    <asp:ListItem>400</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <asp:Button ID="btnCriteria" Text="Search" CssClass="btn btn-default" runat="server" OnClick="btnCriteria_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <h3>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
        </h3>
        <div id="divActivities" style="text-align:center" runat="server">
            <div class="page-header">
                <h3>Activities For You:</h3>
            </div>
            <div style="width:100%;text-align:center">
                <div class="row">
                    <asp:Repeater ID="rptActivities" runat="server" OnItemCommand="rptActivities_ItemCommand">
                        <ItemTemplate>
                            <div class="col-md-3">
                                <div class="panel panel-default">
                                    <div class="panel-body">
                                        <h5>
                                            <asp:Label ID="lblActivityType" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Activity_Type") %>' runat="server"></asp:Label>
                                        </h5>
                                        <p style="color:black">
                                            Price: $
                                            <asp:Label ID="lblPrice" ForeColor="Black" Text='<%# DataBinder.Eval(Container.DataItem, "Activity_Cost") %>' runat="server"></asp:Label>
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