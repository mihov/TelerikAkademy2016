var arr0 = ['6\n3\n4\n1\n5\n2\n6'];

console.log(SelectionSort(arr0));

function SelectionSort(params) {
    var arr = params[0].split('\n'),
        n = arr[0],
        arr = arr.slice(1),
        min = arr[0];

    for (var j = 0; j < n; j += 1) {
        min = arr[j];
        for (var i = j; i < n; i += 1) {

            if (+arr[i] < min) {
                min = +arr[i];
                arr[i] = +arr[j];
                arr[j] = min;
            }
        }
    }

    return arr.join('\n');
}