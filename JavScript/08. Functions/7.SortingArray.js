function solve(params) {


    function SelectionSort(arr0) {

        return params;


    }

    function MaxInArr(arr, from, to) {
        var max = arr[from],
            i, iMax;
        for (var i = from + 1; i <= to; i += 1) {
            if (arr[i] > max) {
                max = arr[i];
                iMax = i;
            }
        }
        arr[iMax] = null;
        return max;
    }

    function sort(input) {
        var n = +input[0],
            numbers = input[1].split(' ').map(Number);

        if (numbers.length > 1) {
            console.log(numbers.sort(function (x, y)
            { return x - y; }
            ).join(' '));
        }
    }
}