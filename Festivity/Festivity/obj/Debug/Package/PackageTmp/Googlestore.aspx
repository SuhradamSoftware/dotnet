<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Googlestore.aspx.cs" Inherits="Festivity.Googlestore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Google Store</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_bg">
        <div class="wrap">
	        <div class="main">
		        <div class="container">
                    <ul id="filters" class="clearfix linkcolor">
                        <asp:Repeater ID="CategoryList" runat="server" OnItemCommand="List_ItemCommand">
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <li class="filter"><asp:LinkButton ID="LinkButtonEdittour" CssClass="linkcolor" runat="server" Text='<%# Eval("Category")%>' CommandArgument='<%# Eval("Category") %>' CommandName="Search" ToolTip="Search"></asp:LinkButton></li> /                                
                            </ItemTemplate>
                            <FooterTemplate></FooterTemplate>
                        </asp:Repeater>
                    </ul>
                    <asp:DataList ID="dlSearch" CssClass="portfolio-wrapper" runat="server" RepeatColumns="4" CellPadding="4">
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("Url") %>'>
                                <asp:Image ID="img1" src='<%#Eval("Url") %>' Height="180px" Width="270px" runat="server" />
                            </asp:HyperLink>
                            <br />
                            <div class="portfolio app" data-cat="app">
                                <div class="label">
							        <div class="label-text">
                                        <asp:LinkButton ID="lnkDownload" CssClass="text-title" Text = "Download" CommandArgument = '<%# Eval("Url") %>' runat="server" OnClick = "GenerateThumbnail"></asp:LinkButton>
                                    </div>
							        <div class="label-bg"></div>
						        </div>
                            </div>
                            <br />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"  />
                    </asp:DataList> 
                </div>
	        </div>
	    </div>
    </div>
</asp:Content>

