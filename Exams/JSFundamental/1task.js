function task1(params) {
    var heights = params[0].split(' ').map(Number),
        pocketSum = 0, i,
        pocket = [];

    //console.log(heights);

    for (i = 0; i < heights.length ; i += 1) {

        if (isAPocket(i, heights)) {
            pocket.push(i);
        }
    }

    for (i = 0; i < pocket.length; i += 1) {
        pocketSum += heights[pocket[i]];

    }



    console.log(pocketSum);

    function isAPocket(i, array) {
        var rule1 = true,
            rule2 = true,
            rule3 = true;

        rule1 = array[i] < array[i - 1] && array[i] < array[i + 1];

        if (i > 1) {
            rule2 = array[i - 2] < array[i - 1];
        }

        if (i < array.length - 2) {
            rule3 = array[i + 1] > array[i + 2];
        }

        return rule1 && rule2 && rule3;
    }
}

task1(["53 20 1 30 2 40 3 3 10 1"]);

/*
    var heights = params[0].split(' ').map(Number),
        maxRockNum = -1, i,
        peaks = [0];

    for (i = 1; i < heights.length - 1; i += 1) {
        if (biggerThanNeighbours(i, heights)) {
            peaks.push(i);
        }
    }
    peaks.push(heights.length - 1);

    for( i = 1; i < peaks.length; i += 1) {
        maxRockNum = Math.max(maxRockNum, peaks[i] - peaks[i - 1]);
    }
    console.log(maxRockNum);

    function biggerThanNeighbours(i, array) {

        return array[i] > array[i + 1] &&
            array[i] > array[i - 1];
    }*/