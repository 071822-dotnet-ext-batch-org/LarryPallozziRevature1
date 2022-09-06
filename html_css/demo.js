console.log("Hi, there!");
//confirm("Do you want to continue");
//prompt("This is a prompt!", Yes);

var var1 = 211234;
console.log(`${var1}`)

{ // limits scope unless using var
  var var2 = 4;
  let var3 = 1;// returned but only due to consle in scope
  console.log(var3);
}
console.log(var2);

const myConst = 56;
console.log(myConst);

five = 5;
console.log(five == 5);
console.log(five === 5);

if(" ")
{
  console.log("True!");
}
else
{
  console.log("False!");
}

let one = String(five);
console.log(one);

// JS object
let person = {
  name: 'Steve',
  age: 89};


let personStr = JSON.stringify(person);
console.log(personStr);

let personStr1 = JSON.parse(personStr);
console.log(personStr1);

console.log(personStr1.name, personStr1.age);

person.state = 'Alaska';
console.log(person);

function func1(param) {
  console.log(`This is a ${param}.`)
};

func1(); // invoke 1st
func1("FUNCTION");

//arrow function
let func2 = param => ++param;
console.log(func2(1));

let func3 = () => "No params!";
console.log(func3);

// call back function
let func4 = (p1, p2) => {
  let res = p1(p2);
  let myVar = `I\'m ${res}`;
  let myVar2 = "here";
  return myVar + myVar2;
}

let myp1 = (p1) => {
  let swords = p1;
  swords += swords;
  return swords;
}

let res1 = func4(myp1, "Very ");
console.log(res1);

//Immediately invoked do not have params
(() => {
  console.log("Immediately invoked function call (IIFE).")
})()

//closure!
function myNested(p1) {
  return () => ++p1; // returns function
}

let myNested1 = myNested(3);
console.log(myNested1()); //4
console.log(myNested1()); // 5
console.log(myNested1()); // 6
