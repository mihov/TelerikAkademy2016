function rectangle(params) {
    var a = parseFloat(params[0]);
    var b = parseFloat(params[1]);
    var area = a * b;
    var perimeter = 2 * a + 2 * b;
    return area.toFixed(2) + " " + perimeter.toFixed(2);
}