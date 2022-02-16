function toLocString(num){
  // !num         when null, undefined or empty (0 is empty) 
  // isNaN(num)   when num is not a number
  // num === 0    when num is equal 0, then is ''
  if(!num || isNaN(num) || num === 0) return '';

  let isNegative = false;
  if(num < 0) {
    isNegative = true;
    num = num * -1;
  }

  // string must be sorted by a-z and A-Z, and non repeting letters

  const range = [];
  let start = num % 2 === 1 ? 97 : 98; // if number is odd, then contains 'a'
  let end = 122;
  for(let i = start; i <= end; i++) range.push(String.fromCharCode(i));
  start = 65;
  end = 90;
  for(let i = start; i <= end; i++) range.push(String.fromCharCode(i));

  // make an array with combination of letter's
  let comb = [];
  for(let i = 0; i < range.length - 1; i++) {
    let s = toInt(range[i]);
    console.log(range[i], 'i', s);
    comb.push(range[i]);
    for(let j = i + 1; j < range.length; j++) {
      if(s === num) {
        console.log('comb interna', comb);
        return comb.join('');

      }
      if(s > num) {
        console.log('comb break', comb);
        comb = [];
        s = 0;
        continue;
      }
      s += toInt(range[j]);
      console.log(range[j], 'j', s);
      comb.push(range[j]);
      
    }
    console.log('\n\n');
    s = 0;
    console.log('comb', comb);
    comb = [];
  }
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

//2251799813685248
console.log(toLocString(9447680));
//console.log(toLocString(7));

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