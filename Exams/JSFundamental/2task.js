function task2(params) {
    var dimention = params[0].split(" ").map(Number),
        unitCoord = params[1].split(";"),
        unit = {
            'Wboup': unitCoord[0].split(" ").map(Number),
            "Nbslbub": unitCoord[1].split(" ").map(Number),
            "Lsjtujzbo": unitCoord[2].split(" ").map(Number)
        },
        commandText = params.slice(2),
        i, row, col, r, c,
        board = Array(dimention[0]),
        deltaM = {
            'u': [-1, 0],
            'd': [1, 0],
            'l': [0, -1],
            'r': [0, 1]
        };

    //console.log(deltaM['u']);

    //console.log(unit.Lsjtujzbo[0]);
    for (row = 0; row < dimention[0]; row += 1) {
        board[row] = Array(dimention[1]);
        for (col = 0; col < dimention[1]; col += 1) {
            board[row][col] = null;
        }
    }

    board[unit['Wboup'][0]][unit['Wboup'][1]] = 'Wboup';
    board[unit['Nbslbub'][0]][unit['Nbslbub'][1]] = 'Nbslbub';
    board[unit['Lsjtujzbo'][0]][unit['Lsjtujzbo'][1]] = 'Lsjtujzbo';

    /*
    for (row = 0; row < dimention[0]; row += 1) {
        for (col = 0; col < dimention[1]; col += 1) {

            console.log(board[row][col]);
        }
    }
*/
    for (i = 0; i < commandText.length; i += 1) {
        var currentCommand = commandText[i].split(" ");
        //console.log(currentCommand);
        if (currentCommand.length === 2) {
            // lay trap
            r = unit['Lsjtujzbo'][0];
            c = unit['Lsjtujzbo'][1];
            board[r][c] = 'trap';

        } else if (currentCommand.length === 3) {
            // movie

            var who = currentCommand[1],
                dir = currentCommand[2];

            if (who == 'Lsjtujzbo') {
                //ls move
                setToNull('Lsjtujzbo');
                unit['Lsjtujzbo'][0] += deltaM[dir][0];
                unit['Lsjtujzbo'][1] += deltaM[dir][1];
                setToUnit('Lsjtujzbo');
                
                if (isSaveLs()) {
                    console.log("Lsjtujzbo is saved! " +
                        unit['Wboup'][0] + " " +
                        unit['Wboup'][1] + " " +
                        unit['Nbslbub'][0] + " " +
                        unit['Nbslbub'][1]);
                    return;
                }

            } else if (who == 'Nbslbub') {
                if (!isInTrap('Nbslbub')) {
                    // not set trap
                    setToNull('Nbslbub');
                    unit['Nbslbub'][0] += deltaM[dir][0];
                    unit['Nbslbub'][1] += deltaM[dir][1];
                    setToUnit('Nbslbub');
                }


                if (isTrCatchLs('Nbslbub')) {
                    console.log("The trolls caught Lsjtujzbo at " +
                        unit['Lsjtujzbo'][0] + " " +
                        unit['Lsjtujzbo'][1]);
                    return;
                } else {

                }

            } else if (who == 'Wboup') {
                if (!isInTrap('Wboup')) {

                    setToNull('Wboup');
                    unit['Wboup'][0] += deltaM[dir][0];
                    unit['Wboup'][1] += deltaM[dir][1];
                    setToUnit('Wboup');
                }

                if (isTrCatchLs('Wboup')) {
                    console.log("The trolls caught Lsjtujzbo at " +
                        unit['Lsjtujzbo'][0] + " " +
                        unit['Lsjtujzbo'][1]);
                    return;
                } else {

                }
            }
        }
    }


    function empty(x, y) {
        return board[x][y] === null;
    }

    function isSaveLs() {
        var rl = unit['Lsjtujzbo'][0],
            cl = unit['Lsjtujzbo'][1];
        return (dimention[0] === (rl + 1)) && (dimention[1] === (cl + 1));
    }

    // "Lsjtujzbo is saved! 6 2 3 4"

    function isTrCatchLs(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1],
            rl = unit['Lsjtujzbo'][0],
            cl = unit['Lsjtujzbo'][1];
        return (Math.abs(r1 - rl) <= 1) && (Math.abs(c1 - cl) <= 1);
    }

    function setToNull(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1];
        if (board[r1][c1] != 'trap') {

            board[r1][c1] = null;
        }
    }

    function isInTrap(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1];
            //console.log(board[r1][c1]);
        return true;//board[r1][c1] == 'trap';
    }

    function setToUnit(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1];
        if (board[r1][c1] === null) {
            board[r1][c1] = params;
        }
    }
}

task2([
    '5 5',
    '1 1;0 1;2 3',
    'mv Lsjtujzbo d',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Wboup r',
    'mv Wboup r',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d'
]);