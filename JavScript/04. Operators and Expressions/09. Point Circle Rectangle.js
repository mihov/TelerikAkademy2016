function name(params) {
    var x = +params[0];
    var y = +params[1];
    var result = "";
    var distance = Math.sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));

    if (distance <= 1.5) {
        result = "inside";
    } else {
        result = "outside";
    }

    result += " circle ";

    if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)) {
        result += "inside";
    } else {
        result += "outside";
    }

    result += " rectangle";
    return result;
}
