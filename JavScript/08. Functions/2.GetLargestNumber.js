console.log(
GetMax(['7 19 19']));

function GetMax(params) {
    var arr = params[0].split(' '),
        max = +arr[0];
        console.log(arr);
    arr.forEach(function (element) {
        console.log(element);
        if (max < +element) { max = +element; }
    }, this);
    return max;
}