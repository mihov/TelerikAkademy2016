var arr0 = ['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32'];

console.log(BinarySearch(arr0));

function BinarySearch(params) {
    var arr = params[0].split('\n'),
        n = +arr[0],
        x = +arr[n + 1],
        arrInt = arr.slice(1, n + 1);

    var result = binarySearch(arrInt, x, 0, arrInt.length - 1);

    return result;


    function binarySearch(arr, x, start, end) {

        if (start > end) {
            return -1;
        }
        else {
            var middle = +Math.floor((end + start) / 2);

            if (+x == +arr[middle]) {
                return middle;
            } else if (+x < +arr[middle]) {
                return binarySearch(arr, x, start, middle - 1);
            } else {
                return binarySearch(arr, x, middle + 1, end);
            }
        }
    }
}
//0 1 2 3 4 5 6 7 8 9 