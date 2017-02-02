<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="InsertCategory.aspx.cs" Inherits="Festivity.InsertCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    function Validate() {
        var isValid = false;
        isValid = Page_ClientValidate('Group1');
        return isValid;
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:label ID="lblMessage" runat="server"  /><br />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Category Name"  ControlToValidate="Category" Display="Dynamic"  ValidationGroup="Group1" CssClass="col-lg-12 alert alert-danger"></asp:RequiredFieldValidator> <br /> 
<asp:Label ID="Label1" runat="server" Text="New Category Name" ></asp:Label><br />
<asp:TextBox ID="Category" runat="server" ></asp:TextBox><br />
 <asp:Button ID="btnSave" runat="server"  Text="Save" OnClientClick="return Validate()" OnClick="btnSave_Click" CausesValidation="true" />
 <br />
 <asp:Repeater ID="CategoryList" runat="server" OnItemCommand="List_ItemCommand">
                                <HeaderTemplate>
                                <div class="table-responsive">
                                    <table id="tab"  width="100%">
                                        <thead>
                                            <tr>
                                                <th>Category</th>
                                                <th>Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("Category")%></td>
                                                <td> 
                                                    <asp:LinkButton ID="LinkButtonDelete" OnClientClick="javascript:if(!confirm('Delete this information? this will delete permanently'))return false;" runat="server" Text ="Delete" CommandArgument='<%# Eval("ID") %>' CommandName="Delete" ToolTip="Delete Record"></asp:LinkButton> 
                                                </td>
                                                </tr>
                                
                                </ItemTemplate>
                
                                <FooterTemplate>                            
                                        </tbody> </table></div><br />
                                </FooterTemplate>
                            </asp:Repeater>
</asp:Content>
