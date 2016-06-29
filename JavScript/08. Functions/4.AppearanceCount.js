console.log(AppearanceCount(['8', '28 6 21 6 -7856 73 73 -56', '73']));
function AppearanceCount(params) {
    var n = +params[0],
        x = +params[2],
        arr = params[1].split(' '),
        count = 0;

    arr.forEach(function (element) {
        if (x == element) { count += 1; }
    }, this);
    return count;
}