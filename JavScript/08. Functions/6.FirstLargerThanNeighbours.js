console.log(FirstLargerThanNeighbours(['6', '-26 -25 -28 31 2 27', '73']));
function FirstLargerThanNeighbours(params) {
    var n = +params[0],
        arr = params[1].split(' '),
        count = 0,
        index;

    for (index = 1; index < arr.length - 1; index += 1) {
        if (+arr[index] > +arr[index - 1] && +arr[index] > +arr[index + 1]) {
            return index;
        }
    }
    return -1;
}