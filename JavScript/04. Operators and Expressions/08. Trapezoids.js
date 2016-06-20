function name(params) {
    var a = parseFloat(params[0]);
    var b = parseFloat(params[1]);
    var h = parseFloat(params[2]);

    return ((a + b) * h / 2.0).toFixed(7);
}