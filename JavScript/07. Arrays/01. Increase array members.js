function name(params) {
    var len = +params[0];
    var arr = new Array(len);

    for (var index = 0; index < arr.length; index += 1) {
        arr[index] = index * 5;
        console.log(arr[index]);
    }
}