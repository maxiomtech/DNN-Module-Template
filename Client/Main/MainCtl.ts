 module CompanyName.ModuleName {
     
     interface IMainCtl {
         init(): void;
     }

     

     class MainCtl implements IMainCtl {
         
         hello: string;    

         constructor(private $scope, private $log: ng.ILogService, private Api: IApi) {
             var vm = this;
             this.init();


             
         }

         public init() {
             this.Api.getDataRx().subscribe((result) => {
                 this.hello = result.data.Name;
             });
         }

         public helloWorld() {
             this.$log.info('I accept your greeting');
         }

         
     }

     app.controller('MainCtl', ['$scope','$log','Api', MainCtl]);

 }