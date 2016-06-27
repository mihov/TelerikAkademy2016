function name(params) {
    if (parseFloat(params[0]) > parseFloat(params[1])) {
        if (parseFloat(params[1]) > parseFloat(params[2])) {
            return params[0] +" "+params[1] +" "+params[2];
        } else if (parseFloat(params[2]) > parseFloat(params[0])) {
            return params[2] +" "+params[0] +" "+params[1];
        } else {
            return params[0] +" "+params[2] +" "+params[1];
        }
    } else if (parseFloat(params[1] <= parseFloat(params[2]))) {
         return params[1] +" "+params[2] +" "+params[0];
    } else {
        return params[2] +" "+params[1] +" "+params[0];
    }
}