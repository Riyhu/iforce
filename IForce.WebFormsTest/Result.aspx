<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="IForce.WebFormsTest.Result" MasterPageFile="~/Site.Master" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <title>Reverse Result | IForce Web Forms Test</title>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="row justify-content-center">
        <div class="col-12 col-lg-8">
            <div class="card border-0 shadow-sm">
                <div class="card-body p-4 p-md-5">
                    <span class="badge text-bg-primary mb-3">Exercise 1 result</span>
                    <h1 class="h2">Reverse Result</h1>
                    <p class="text-body-secondary">Teks hasil pembalikan:</p>
                    <div class="alert alert-info fs-5 mb-4 result-text">
                        <asp:Literal ID="ReversedTextLiteral" runat="server" Mode="Encode" />
                    </div>
                    <asp:HyperLink ID="BackLink" runat="server" NavigateUrl="~/Default.aspx" CssClass="btn btn-outline-secondary" Text="Kembali ke form" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
