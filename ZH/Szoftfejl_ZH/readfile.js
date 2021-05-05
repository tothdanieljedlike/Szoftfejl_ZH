let helyarray;
let elsokoord;
let masodikkoord;

function readFile()
{

    const readline = require('readline');
    const fs = require('fs');
    const readInterface = readline.createInterface({
        input: fs.createReadStream('./sg500.csv'),
        output: process.stdout,
        console: false
    });
    readInterface.on('line', function(line) {
        let mapArray = line.split(';');
        elsokoord.push(mapArray[1]);
        masodikkoord.push(mapArray[2]);
        helyarray.push(mapArray[3]);
    });
}

export{helyarray,elsokoord,masodikkoord,readFile}
