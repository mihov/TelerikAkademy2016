function name(params) {
    var signdMunusCount = 0;

    for (var index = 0; index < 3; index += 1) {
        if (params[index] == '0') {
            return 0;
        } else
            if ((params[index] | 1) < 0) signdMunusCount += 1;
    }
    if (signdMunusCount % 2 === 0) {
        return '+';
    } else {
        return '-';
    }
}