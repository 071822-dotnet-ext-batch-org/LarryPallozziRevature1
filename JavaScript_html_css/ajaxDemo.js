"use strict;"

const xhr = new XMLHttpRequest(); // xml http request object
console.log(`The readystate is ${xhr.readystate}`); //show


xhr.onreadystatechange = () => {
  console.log(`The readystate is ${xhr.readyState} - \nThe status code is ${xhr.status}`)
  //good request
  if (xhr.readyState == 4 && xhr.status == 200) {
    console.log(`The responsetype is ${xhr.responseType.valueOf}.`);
    console.log(`The responsetext is ${xhr.responseText}`);
    displyResponseTextInBrowser();
  }
  //bad request
  else {
    console.log(`Jokes are not ready yet!`);
  }
};

// opens connection and sends request
xhr.open('GET', 'http://api.icndb.com/jokes/random', true);
xhr.send();


// Display 1 Joke
function displyResponseTextInBrowser() {
  let bodie = document.body; //get body object
  let myDiv = document.createElement('div'); // make <div>
  let myP = document.createElement('p'); // make <p>
  //add the div and p to the html
  myDiv.appendChild(myP);
  bodie.appendChild(myDiv)

  let resText = JSON.parse(xhr.responseText); // JSON to JS object
  console.log(resText)// show

  myP.textContent = resText.value.joke; //add joke to <p>

}


const xhr2 = new XMLHttpRequest(); //xml request object
console.log(`The readystate is ${xhr2.readystate}`); //Show joke

xhr2.onreadystatechange = () => {
  //good request
  if (xhr2.readyState == 4 && xhr2.status == 200) {
    displyJokesInBrowser();
  }
  //bad request
  else {
    console.log(`Jokes are not ready yet!`);
  }
};
/*
var number = 5;

//open connection and send request
xhr2.open('GET', `http://api.icndb.com/jokes/random/${number}`, true);
xhr2.send();


// Display multiple jokes
function displyJokesInBrowser(num) {

  console.log(xhr2.responseText);//show

  //let myDiv = document.querySelector('div');//get <div>
  let resText = JSON.parse(xhr.responseText); //change JSON to JS
  //console.log(resText2)//show
  let myP = document.querySelector('p');
  myDiv.appendChild(myP);//add <p> element to <div>

  let bodie = document.body; //get body object
  let myDiv = document.createElement('div'); // make <div>
  //add the div and p to the html
  myDiv.appendChild(myP);
  bodie.appendChild(myDiv)

  console.log(resText)// show

  myP.textContent = resText.value.joke; //add joke to <p>

}
*/

fetch('http://api.icndb.com/jokes/random/5')
  .then(
    (res) => {
      console.log(res.ok, res.headers, res.value, res.responseType, res.responseText)
      return res.json()
    },
    (rej) => {})
  .then(body => {
    for (let x of body.value){
      console.log(x.joke);
    }
    })
    .catch(err => { throw new console.Error("Error");})
