 module CompanyName.ModuleName {
     
     interface IMainCtl {
         init(): void;
     }

     

     class MainCtl implements IMainCtl {
         
         hello: string;    

         constructor(private $scope) {
             var vm = this;
             this.init();

             
             
         }

         public init() {
             this.hello = "Hello World";
         }

         
     }

     app.controller('MainCtl', ['$scope', MainCtl]);

 }