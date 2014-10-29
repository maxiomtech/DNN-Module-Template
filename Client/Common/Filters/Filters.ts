declare var moment: any;
module CompanyName.ModuleName {
     function momentFilter(dateString: string, format: string) {
         if (moment(dateString).isValid()) {
             if (moment(dateString).format(format) != "01/01/0001") {
                 return moment(dateString).format(format);
             }
         }
         return "";
     }

     app.filter('moment', momentFilter);

 }