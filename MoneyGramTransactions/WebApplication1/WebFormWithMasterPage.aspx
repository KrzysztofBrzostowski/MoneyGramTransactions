<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebFormWithMasterPage.aspx.cs" Inherits="WebApplication1.WebFormWithMasterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <script src="JavaScriptExample01.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="btn-group" role="group" aria-label="...">
  <button ID="btnSubmit" type="button" class="btn btn-default">Left</button>
  <button type="button" class="btn btn-default">Middle</button>
  <button type="button" class="btn btn-default">Right</button>
</div>
</asp:Content>
