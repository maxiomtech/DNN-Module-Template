module CompanyName.ModuleName {
    
    export interface IApi {
        getData: () => ng.IHttpPromise<any>;
        getDataRx: () => Rx.IObservable<any>;
    }


    class Api implements  IApi {
        constructor(private $http: ng.IHttpService, private $log: ng.ILogService, private rx) { }

        private httpConfig = {
            headers: {
                TabId: servicesFramework.getTabId(),
                ModuleId: servicesFramework.getModuleId(),
                RequestVerificationToken: servicesFramework.getAntiForgeryValue(),
            }
        }

        //Example of getting data from WebApi. 
        public getData() {
            return this.$http.get(servicesFramework.getServiceRoot('CompanyName/ModuleName') + 'ModuleName/GetTestEntity', this.httpConfig);
        }

        //Example of returning an Observable Stream of Promise
        public getDataRx() {
            return this.rx.Observable.fromPromise(
                this.getData()
            );
        }


    }

    app.service('Api', ['$http', '$log', 'rx', Api]);

}


