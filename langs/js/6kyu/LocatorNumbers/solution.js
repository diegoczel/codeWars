function toLocString(num){
  if(!num) return ''; // null, undefined or empty (0 is empty)

  // string must be sorted by a-z and A-Z, and non repeting letters

  
  /*
  const arr = [];
  for(let i of new Set(string)) arr.push(i);
  */
  // vai ter que ser uma comb entre digamos 'actA', como é ordenado e unico
  // String.fromCharCode(range)

  const range = [];
  console.log(num % 2 === 1);
  // start with problem
  let start = num % 2 === 1 ? 98 : 97; // if number is odd, then contains 'a'
  let end = 122;
  for(let i = start; i <= end; i++) range.push(String.fromCharCode(i));
  console.log(start);
  start = 65;
  end = 90;
  for(let i = start; i <= end; i++) range.push(String.fromCharCode(i));
  console.log(start);
  console.log(range);
}

function toInt(str){
  if(!str) return 0; // null, undefined or empty ('' is empty)
 
  let isNegative = false; // control if number is negative
  if(str[0] === '-') {
    if(str.length === 1) return 0; // when str start with '-' and len is 1
    isNegative = true; 
  }
  
  // delete the invalid char's
  const ignored = ['\t', '\v', '\r', '\n', ' ', '-'];
  for(let i of ignored) {
    while(str.indexOf(i) !== -1) str = str.replace(i, '');
  }

  // ignore number's, capturing letter's [a-z][A-Z]
  const s = str.match(/[a-z]/gi);
  
  let num = s.map(position).reduce((total, current) => total + 2 ** current, 0); 
  return (isNegative) ? num * -1 : num;

}

function position(letter) {
  const lowerStart  = 'a'.charCodeAt(); //97
  const lowerEnd    = 'z'.charCodeAt(); //122
  const upperStart  = 'A'.charCodeAt(); //65
  const upperEnd    = 'Z'.charCodeAt(); //90

  let l = letter.charCodeAt();
  if(l >= 97 && l <= 122) return l - lowerStart;
  if(l <= 90 && l >= 65) return l - upperStart + 26;
  // if letter is invalid
}

toLocString(9447680);

/*const l = [ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l'];
console.log(l.map(position).reduce((total, current) => total + 2 ** current, 0 ));*/

/*
console.log(toInt('-\t\tli\\nux\v\v1\r\r\n\n  ')); // char invalid
console.log(toInt('linux'));
console.log(toInt('-\t\tAbCd\v\v1\r\r\n\n  '))
console.log(toInt('-')); // only '-' into str
console.log(toInt('-abc---')); // del all '-'
console.log(position('*'));
console.log(position('Z'));*/