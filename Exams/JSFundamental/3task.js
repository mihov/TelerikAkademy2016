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

    for (row = 0; row < dimention[0]; row += 1) {
        board[row] = Array(dimention[1]);
        for (col = 0; col < dimention[1]; col += 1) {
            board[row][col] = null;
        }
    }

    board[unit['Wboup'][0]][unit['Wboup'][1]] = 'Wboup';
    board[unit['Nbslbub'][0]][unit['Nbslbub'][1]] = 'Nbslbub';
    board[unit['Lsjtujzbo'][0]][unit['Lsjtujzbo'][1]] = 'Lsjtujzbo';

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
            //console.log(unit['Wboup'][0] + " " + unit['Wboup'][1]);
            var who = currentCommand[1],
                dir = currentCommand[2];
            //console.log(who + " " + dir);

            if (who == 'Lsjtujzbo') {
                //ls move


                setToNull('Lsjtujzbo');
                unit['Lsjtujzbo'][0] += deltaM[dir][0];
                unit['Lsjtujzbo'][1] += deltaM[dir][1];

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
                    removeTrapN();

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
                    // not set trap
                    setToNull('Wboup');

                    if (unit['Wboup'][0] + deltaM[dir][0] >= 0)
                        unit['Wboup'][0] += deltaM[dir][0];
                    if (unit['Wboup'][1] + deltaM[dir][1] >= 0)
                        unit['Wboup'][1] += deltaM[dir][1];
                    
                    removeTrapW();
                    //setToUnit('Wboup');
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



    function isSaveLs() {
        var rl = unit['Lsjtujzbo'][0],
            cl = unit['Lsjtujzbo'][1];
        return (dimention[0] === (rl + 1)) && (dimention[1] === (cl + 1));
    }

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

    function isInBoard(rr, cc) {
        return (rr >= 0) && (cc >= 0) && (rr < dimention[0]) && (cc < dimention[1]);
    }

    function removeTrapN() {
        var r1 = unit['Nbslbub'][0],
            c1 = unit['Nbslbub'][1],
            r2 = unit['Wboup'][0],
            c2 = unit['Wboup'][1];
        if (isInBoard(r1, c1))
            if (board[r1][c1] == 'trap' && (r1 == r2 && c1 == c2)) {
                board[r1][c1] = null;
            }
    }

    function removeTrapW() {
        var r2 = unit['Nbslbub'][0],
            c2 = unit['Nbslbub'][1],
            r1 = unit['Wboup'][0],
            c1 = unit['Wboup'][1];
        if (isInBoard(r1, c1))
            if (board[r1][c1] == 'trap' && (r1 == r2 && c1 == c2)) {
                board[r1][c1] = null;
            }
    }

    function isInTrap(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1];
        return board[r1][c1] == 'trap';
    }

    function setToUnit(params) {
        var r1 = unit[params][0],
            c1 = unit[params][1];

        if (r1 < dimention[0] && c1 < dimention[1]) {
            if (board[r1][c1] === null) {
                board[r1][c1] = params;
            }
        }
    }
}
task2([
    '7 7',
    '0 1;0 2;3 3',
    'mv Lsjtujzbo l',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup l',
    'mv Wboup l',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub d',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo l',
    'mv Lsjtujzbo l',
    'mv Nbslbub l',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r'
]);