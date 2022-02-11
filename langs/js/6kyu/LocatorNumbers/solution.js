function toLocString(num){
  if(!num) return ''; // null, undefined or empty (0 is empty)
}

function toInt(str){
  if(!str) return 0; // null, undefined or empty ('' is empty)
 
  let isNegative = false; // control if number is negative
  if(str[0] === '-') {
    if(str.length === 1) return 0; // when str start with '-' and len is 1
    isNegative = true; 
  }
  
  // ignore the invalid char's
  const regex = /[a-z]/gi;
  let s = '';
  for(let x of str) {
    if(x === '-' || regex.test(x)) s += x;
  }

}

console.log(toInt('-\t\tlinux\v\v1\r\r\n\n  ')); // char invalid
console.log(toInt('-')); // only '-' into str
console.log(toInt('-abc---')); // del all '-'