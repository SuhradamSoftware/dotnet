<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Festivitystore.aspx.cs" Inherits="Festivity.Festivitystore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Festivity Store</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_bg">
        <div class="wrap">
	        <div class="main">
		        <div class="container">
                    <ul id="filters" class="clearfix linkcolor">
                        <li><asp:LinkButton ID="LinkButtonAll" runat="server" Text='All' OnClick="AllImage_Click" ToolTip="Search" CssClass="linkcolor"></asp:LinkButton></li>
                        
                        <asp:Repeater ID="CategoryList" runat="server" OnItemCommand="List_ItemCommand">
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <li class="filter"><asp:LinkButton ID="LinkButtonEdittour" CssClass="linkcolor" runat="server" Text='<%# Eval("Category")%>' CommandArgument='<%# Eval("ID") %>' CommandName="Search" ToolTip="Search"></asp:LinkButton></li>                                
                            </ItemTemplate>
                            <FooterTemplate></FooterTemplate>
                        </asp:Repeater>
                    </ul>
                    <asp:DataList ID="DataList1" runat="server" CssClass="portfolio-wrapper" RepeatColumns="4" RepeatDirection="Horizontal"  Width="100%">
                        <ItemTemplate>	
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "ImageHandler.ashx?ID="+ Eval("ID") %>' Height="140px" Width="110px"/><br />
                            <div class="portfolio app" data-cat="app">
                                <div class="label">
							        <div class="label-text">
                                        <asp:HyperLink ID="HyperLink1" CssClass="text-title" runat="server" NavigateUrl='<%# string.Format("~/GetImage.aspx?ID={0}",HttpUtility.UrlEncode(Eval("ID").ToString())) %>' Text="Download"></asp:HyperLink>
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

