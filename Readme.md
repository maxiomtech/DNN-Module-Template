# DNN Module Template w/ WebApi & AngularJS

This template is a base starting point for building highly performance client side applications
with AngularJS and Asp.Net WebApi

## Installation

1. Install DNN (DNN 7.3+ required)
2. Create company folder in /DesktopModules/
3. Create module folder in /DesktopModules/<code>{CompanyName}</code>
4. Clone this repository into the module folder.
5. Run <code>Setup Template.ps1</code> powershell script
6. Provider powershell script with your <code>CompanyName</code> & <code>ModuleName</code>

*Happy coding!*

## Features

- **Loader.ascx** will inject any of the Views located in the */Views* folder.
- AngularJS files are automatically injected into the page by naming convention. Files in /Client/Common subdirectories will be added to every view. 
Additional files will be added based on the View name selected. ex. (/Views/Main.ascx will load /Client/Main/*).
- AngularJS fiels are added using DNN's Client Dependency Framework utilizing the <code>ForceProvider="DnnFormBottomProvider"</code> attribute in order for all files to be added to the bottom of the body.
- AngularJS files use the long-form instantiation method in order to be minify safe.
- **MSBuild** scripts are used to package the module into Install & Source zips located in the */Install* directory. 
- Uses AutoFac for Dependency Injection in the WebApi Controllers.
- Uses DAL2 PetaPoco with the Repository pattern for the Data Access Layer

***Note: you must set the project from debug to release mode for installation zips to be created.***

## DNN Versioning

The main verison number for the module is located in the *.dnn manifest file. Updating this version number will update the Assembly version and increment the /Install zips.

```
<package name="CompanyName.ModuleName" type="Module" version="1.0.0.0">
```
