function name(params) {
    var max  =parseFloat(params[0]);
    for (var index = 1; index < 5; index++) {
        if (parseFloat(params[index])> max) {
            max=parseFloat(params[index]);
        }
        
    }
    return max;
}