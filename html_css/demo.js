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


let m1 = {
  name1: "Larry",
  place: "Earth",
  myString: function() {
    return`${this.name1} lives on the ${this.place}.` }
}
console.log(m1.myString());

let m3 = class m2{
  constructor(name, place) {
    this.name1 = name;
    this.place = place;
  }
}

let m4 = new m3('Tobi', "Moon");
console.log(m3.name, m4.place, m4.name1);

let m5 = new m3('Bob', 'Mars');
console.log(m5.name1, m5.place);

// class
class m6 {
  constructor(name, age) {
    this.name1 = name;
    this.age = age;
  }

  get nameAndAge() {
    return `${this.name1} is ${this.age}!`
  }

  set setAge(x){
    if (x > 100 || x < 1) return new RangeError(`The age ${age} is invalid`);
    else this.age = x;
  }

  static count = 0
  static staticName = 'Joe';
  static getMyStatic(){
    ++this.count;
    return `This method is static method ${this.staticName}.`
  }

};

let m7 = new m6('Olivia', 25);
console.log(m7.nameAndAge);

let m8 = new m6();
console.log(m8.name1, m8.age);

//inheritance
class m6Inheriting extends m6{
  constructor(myName, myAge, address= '123 Main st.') {
    super(myName, myAge);
    this.address = address;
  };
};
// inheritance
let n1 = new m6Inheriting('Larry', 37);
console.log(`${n1.name1} is ${n1.age} and lives at ${n1.address}.`);

console.log();

let paras = document.getElementsByTagName('p')


let bodies = document.body;
let myDiv = document.createElement('div');
bodies.appendChild(myDiv);
let counter = 0

for (let p1 of paras){
  counter++;
  let newP = document.createElement('h3');
  newP.innerText = `${counter} - ${p1.innerText}`
  myDiv.appendChild(newP);
};
