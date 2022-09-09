const myVar = require('./additionalNodeDemo.js') // importing additionalNodeDemo.js
const fs = require('fs') // imports Node.js fs to use

console.log("node demo") //prints to terminal

console.log(`${myVar.myVari} from another module`); // #5 using the exported variable

console.log(myVar.myFunc('This is a string', 5)) //#5 Using the exported function

fs.writeFileSync("./deepThoughts.txt", "To be or not to be!") //#1 writing to deepThoughts
fs.appendFile('./deepThoughts.txt', ' APPENDED TO FILE', function (data) { return true }); //#2 append to new file
//rf.readThisFile('./deepThoughts.txt');
fs.readFile('./deepThoughts.json', function (err, data) { return true })

/*
1 create function functions that write to new file
2 append to new file
3 read that file
4 print contents to the console using node
5 use vari(s) and function that you exported from another module(file)
 */
