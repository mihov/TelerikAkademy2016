function ext(parameter) {
    var index = 0,
        input = [];

    for (var i = 0; i < parameter.length; i += 1) {
        input[i] = parameter[i];
    }

    Array.prototype.remove = function remove(parms) {
        index = this.indexOf(parms);
        for (var i = 0; i < this.length; i += 1) {
            if (index !== -1) {
                this.splice(index, 1);
            }
            index = this.indexOf(parms, index + 1);
        }
    };

    input.remove(input[0]);

    for (i = 0; i < input.length; i += 1) {
        console.log(input[i]);
    }
}