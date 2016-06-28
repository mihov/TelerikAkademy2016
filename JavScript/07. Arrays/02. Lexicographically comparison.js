function name(params) {
    var arr = params[0].split('\n');
    var arr1 = String(arr[0]);
    var arr2 = String(arr[1]);

   
        if (arr1> arr2) {
            return '>';
        }
        
        if (arr1 < arr2) {
            return '<';
        }
   
    return '=';
}