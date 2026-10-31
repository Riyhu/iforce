<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IForce.WebFormsTest.Default" MasterPageFile="~/Site.Master" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <title>Reverse Text | IForce Web Forms Test</title>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="row justify-content-center">
        <div class="col-12 col-lg-8">
            <div class="card border-0 shadow-sm">
                <div class="card-body p-4 p-md-5">
                    <span class="badge text-bg-primary mb-3">Exercise 1</span>
                    <h1 class="h2">Reverse Text</h1>
                    <p class="text-body-secondary mb-4">Masukkan kalimat, lalu klik GO untuk melihat teks secara terbalik.</p>

                    <div class="mb-4">
                        <asp:Label ID="InputLabel" runat="server" AssociatedControlID="InputTextBox" Text="Text input" CssClass="form-label fw-semibold" />
                        <asp:TextBox ID="InputTextBox" runat="server" CssClass="form-control" />
                    </div>

                    <asp:Button ID="GoButton" runat="server" Text="GO" CssClass="btn btn-primary px-4" OnClick="GoButton_Click" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
