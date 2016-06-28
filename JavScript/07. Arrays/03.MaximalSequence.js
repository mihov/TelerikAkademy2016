name(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '2']);

function name(args) {

    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr.slice(1),

        current = +numbers[0],
        tempCount = 1,
        maxCount = 0;

    for (var i = 1; i < n; i += 1) {

        if (current === +numbers[i]) {
            tempCount++;
        }
        else 
        {
            if (tempCount > maxCount) {
                maxCount = tempCount;
            }
            tempCount = 1;
        }
        current = +numbers[i];
    }
                if (tempCount > maxCount) {
                maxCount = tempCount;}

    console.log(maxCount);
}