 module CompanyName.ModuleName {
     
     interface IMainCtl {
         init(): void;
     }

     

     class MainCtl implements IMainCtl {
         
         hello: string;    

         constructor(private $scope, private $log: ng.ILogService) {
             var vm = this;
             this.init();

             
             
         }

         public init() {
             this.hello = "Hello World";
         }

         public helloWorld() {
             this.$log.info('I accept your greeting');
         }

         
     }

     app.controller('MainCtl', ['$scope','$log', MainCtl]);

 }