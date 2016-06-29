console.log(LargerThanNeighbours(['6', '-26 -25 -28 31 2 27', '73']));
function LargerThanNeighbours(params) {
    var n = +params[0],
        arr = params[1].split(' '),
        count = 0,
        index;

    for (index = 1; index < arr.length - 1; index += 1) {
        if (+arr[index] > +arr[index - 1] && +arr[index] > +arr[index + 1]) {
            count += 1;
        }
    }
    return count;
}