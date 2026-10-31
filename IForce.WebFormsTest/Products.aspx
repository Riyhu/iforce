<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="IForce.WebFormsTest.Products" %>

<asp:Content ID="ProductsHeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="ProductsMainContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="row justify-content-center">
        <div class="col-12 col-xl-10">
            <div class="d-flex flex-wrap justify-content-between align-items-end gap-3 mb-4">
                <div>
                    <p class="text-uppercase text-secondary small fw-semibold mb-1">Product catalogue</p>
                    <h1 class="display-6 fw-semibold mb-2">Product Search</h1>
                    <p class="text-secondary mb-0">Search by Product Id or Product Name.</p>
                </div>
            </div>

            <div class="card border-0 shadow-sm mb-4">
                <div class="card-body p-4">
                    <div class="row g-3 align-items-end">
                        <div class="col-12 col-md-8">
                            <asp:Label ID="KeywordLabel" runat="server" AssociatedControlID="KeywordTextBox" CssClass="form-label fw-semibold">Keyword</asp:Label>
                            <asp:TextBox ID="KeywordTextBox" runat="server" CssClass="form-control" MaxLength="200" placeholder="Enter product id or name"></asp:TextBox>
                        </div>
                        <div class="col-12 col-md-auto">
                            <asp:Button ID="SearchButton" runat="server" Text="Search" CssClass="btn btn-primary px-4" OnClick="SearchButton_Click" />
                        </div>
                        <div class="col-12 col-md-auto">
                            <asp:Button ID="ExportButton" runat="server" Text="Export" CssClass="btn btn-outline-secondary px-4" OnClick="ExportButton_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="card border-0 shadow-sm overflow-hidden">
                <div class="table-responsive">
                    <asp:GridView ID="ProductsGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover align-middle mb-0" GridLines="None" EmptyDataText="No products found." UseAccessibleHeader="true">
                        <Columns>
                            <asp:BoundField DataField="ProductId" HeaderText="Product Id" />
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:N2}" HtmlEncode="false" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
