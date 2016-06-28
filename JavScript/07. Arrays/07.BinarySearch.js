var arr0 = ['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32'];

//console.log(arr0);
console.log(BinarySearch(arr0));

function BinarySearch(params) {
    console.log(params);
    var arr = params[0].split('\n'),
        n = +arr[0],
        x = +arr[n + 1],
        arr = arr.slice(1, n + 1),
        counter = 0,
        tempCount,
        element;

    console.log(n);
    console.log(x);
    console.log(arr);

    var result = binarySearch(arr, x);

    return result;
}

function binarySearch(arr, x) {
let length = arr.length;
    if (length === 0) {
        return -1;
    } else {
        var m = Math.floor(length/2);
        var y = a[m];
        if (x === y) {
            return ;
        } else if (x < y) {
            return binarySearch(a.slice(0, m), x);
        } else {
            return binarySearch(a.slice(m + 1), x);
        }
    }

}