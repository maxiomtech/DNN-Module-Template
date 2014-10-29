<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Main.ascx.cs" Inherits="CompanyName.ModuleName.Views.Main" %>

<div ng-controller="MainCtl as vm">
    {{vm.hello}}
    
    <input type="text" ng-enter="vm.helloWorld()" />

</div>