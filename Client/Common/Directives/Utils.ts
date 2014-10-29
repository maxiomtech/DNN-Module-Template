module CompanyName.ModuleName {

    interface INgEnter extends  ng.IScope {
        ngEnter(): void;
    }


    function ngEnter(): ng.IDirective {
         return {
            restrict: 'A',
            scope: { ngEnter: '&' },
            link: (scope : INgEnter, element, attributes) => {
                element.bind("keydown keypress", event => {
                    if (event.which === 13) {
                        event.preventDefault();
                        scope.ngEnter();
                    }
                });
            }
        }
     }


    app.directive('ngEnter', ngEnter);

}