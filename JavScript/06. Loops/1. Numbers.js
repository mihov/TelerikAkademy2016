function name(params) {
    var max = parseInt(params[0]);
    var result = "";
    for (var index = 1; index <= max; index++) {
        result +=  index+" ";

    }

    return result;
}