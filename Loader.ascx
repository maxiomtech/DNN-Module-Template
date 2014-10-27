<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Loader.ascx.cs" Inherits="CompanyName.ModuleName.Loader" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>



<dnn:DnnJsInclude runat="server" Priority="200" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/angular.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="200" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/rxjs/rx.js"></dnn:DnnJsInclude>

<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/angular-sanitize.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/angular-ui-router.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/rxjs/rx.angular.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/lodash.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/ng-grid.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="202" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/ng-grid-reorderable.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="202" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/ng-grid-flexible-height.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/toastr.js"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" Priority="201" FilePath="~/DesktopModules/CompanyName/ModuleName/Scripts/moment.js"></dnn:DnnJsInclude>

<dnn:DnnJsInclude runat="server" ForceProvider="DnnFormBottomProvider" Priority="300" FilePath="~/DesktopModules/CompanyName/ModuleName/Client/app.js"></dnn:DnnJsInclude>




<div class="CompanyName">
    <asp:PlaceHolder runat="server" ID="phOutput"></asp:PlaceHolder>
</div>


<script type="text/javascript">
    var CompanyName = CompanyName || {};
    CompanyName.ModuleName = CompanyName.ModuleName || {};
    CompanyName.ModuleName.templatePath = '<%= ControlPath %>';
    CompanyName.ModuleName.servicesFramework = $.ServicesFramework(<%=ModuleId%>);
</script>
