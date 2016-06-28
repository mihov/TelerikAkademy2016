var arr0 = ['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3'];

console.log(MostFrequentNumber(arr0));

function MostFrequentNumber(params) {
    var arr = params[0].split('\n'),
        n = arr[0],
        arr = arr.slice(1),
        counter = 0,
        tempCount,
        element;

    for (var i = 0; i < n; i += 1) {
        tempCount = 1;
        for (var j = i + 1; j < n; j += 1) {
            if (arr[i] == arr[j]) {
                tempCount += 1;
            }
        }

        if (tempCount > counter) {
            counter = tempCount;
            element = arr[i];
        }

    }

    return element + " (" + counter + " times)";
}