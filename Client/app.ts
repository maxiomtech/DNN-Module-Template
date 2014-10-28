 /// <reference path="references.ts" />
module CompanyName {
    export module ModuleName {
        export var serviceRoot: string = ModuleName.serviceRoot || "";
        export var templatePath: string;
        export var servicesFramework: any;

        
        //Initalizes angular app
        $("html").attr("ng-app", "ModuleName");
        export var app: ng.IModule = angular.module('ModuleName', []);

    }
}