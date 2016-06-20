function name(params) {
    var result = params[0] | 0;
    return (result >> 3) & 1;
}