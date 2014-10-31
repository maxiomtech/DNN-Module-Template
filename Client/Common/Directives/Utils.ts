module CompanyName.ModuleName {

    ////Now implemented in Angular-UI. Re-add if not using Angular-UI
    //function ngEnter(): ng.IDirective {
    //    return {
    //        restrict: 'A',
    //        scope: {
    //            ngEnter: '&'
    //        },
    //        link: (scope: any, element, attrs) => {
    //            element.bind("keydown keypress", event => {
    //                if (event.which === 13) {
    //                    event.preventDefault();
    //                    console.log('Not this');
    //                    scope.$apply(scope.ngEnter());
    //                }
    //            });
    //        }
    //    }
    //}

    //Used for quick tabs configuration with angular-ui and not assigning specific ID tags.
    function noIdTabs(): ng.IDirective {
        return {
            restrict: 'A',
            link: (scope, element: any, attrs) => {
                var rand = 'spec' + (new Date()).getTime() + Math.floor((Math.random() * 25) + 65);
                element.find('ul.nav li a').each((index, o) => {
                    angular.element(o).attr("href", "#" + rand + index.toString());
                });

                element.find('div').each((index, o) => {
                    angular.element(o).attr("id", rand + index.toString());
                });

                element.tabs();
            }
        }
    }

    function dateFormatter(): ng.IDirective {
        return {
            restrict: 'A',
            require: 'ngModel',
            link: (scope, element, attrs, ngModel) => {
                ngModel.$formatters.push((value) => {
                    return moment(value).startOf('day').toDate();
                });
            }
        }
    }


    app.directive('dateFormatter', dateFormatter)
        //.directive('ngEnter', ngEnter) //See Note on function.
        .directive('noIdTabs', noIdTabs);

}