const prevMultOfThree = n => {
  if(n % 3 === 0) return n;

  let strN = n.toString();
  for(let i = strN.length; i > 0; i--) {
    let x = Number(strN.substring(0, i));
    if(x % 3 === 0) return x;
  }
  return null;
}
console.log(prevMultOfThree(952406));
console.log(prevMultOfThree(1));
console.log(prevMultOfThree(25));
console.log(prevMultOfThree(36));
console.log(prevMultOfThree(1244));