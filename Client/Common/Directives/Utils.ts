module CompanyName.ModuleName {

    interface INgGreeting extends  ng.IScope {
        ngEnter(): void;
    }

    //Mimics the ngEnter directive functionality.
    //Remember that camelCase is used like ng-greeting in templates.
    function ngGreeting(): ng.IDirective {
         return {
            restrict: 'A',
            scope: { ngEnter: '&' },
             link: (scope: INgGreeting, element, attributes) => {
                element.bind("keydown keypress", event => {
                    if (event.which === 13) {
                        event.preventDefault();
                        scope.ngEnter();
                    }
                });
            }
        }
     }


    app.directive('ngGreeting', ngGreeting);

}