function name(params) {
    if (parseFloat(params[0]) > parseFloat(params[1])) {
        if (parseFloat(params[1]) > parseFloat(params[2])) {
            return params[0];
        } else if (parseFloat(params[2]) > parseFloat(params[0])) {
            return params[2];
        } else {
            return params[0];
        }
    } else if (parseFloat(params[1] <= parseFloat(params[2]))) {
        return params[2];
    } else {
        return params[1];
    }
}