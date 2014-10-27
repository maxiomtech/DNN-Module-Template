<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="CompanyName.ModuleName.Settings" %>

<div class="dnnFormItem" ng-controller="Settings">
    <dnn:label controlname="ddlViews" resourcekey="lblViews" Text="Select View" Suffix=":" runat="server" />
    <asp:DropDownList runat="server" ID="ddlViews" ng-model="filterView" AppendDataBoundItems="True">
        <asp:ListItem Text=""></asp:ListItem>
    </asp:DropDownList>
    
</div>