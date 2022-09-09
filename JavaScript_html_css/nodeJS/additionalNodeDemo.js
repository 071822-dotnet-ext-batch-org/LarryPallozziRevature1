console.log("This is from the additional node demo file!");

let myVari = 'This is a variable!'; // variable

//function
function myFunc(str, myInt){
  return `${str} is a string and ${myInt} is an int.`
}

exports.myVari = myVari; //#5 exporting variable
exports.myFunc = myFunc; //# exporting function
