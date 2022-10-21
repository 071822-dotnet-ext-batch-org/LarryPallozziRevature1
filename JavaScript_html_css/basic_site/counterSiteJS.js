let countNum = 0
let countId = document.getElementById("countAmount")


function increaseCount() {
  countNum += 1
  countId.innerText = countNum
}

function decreaseCount() {
  if(countNum >= 0)
  {
    countId.innerText = countNum;
  }
  else alert("There is no count, so you can not go any lower then 0!");
}
