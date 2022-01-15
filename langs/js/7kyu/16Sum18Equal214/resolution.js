function add(num1, num2) {
  num1 = num1.toString();
  num2 = num2.toString();
  
  let str = '';
  // add 0 at left of the num1 or num2, based on dif of length
  /* add 'str' at begin based on 2° arg
  num1 = num1.padStart(num2.length, '0');
  num2 = num2.padStart(num1.length, '0');
  */
  if(num1.length < num2.length) {
    num1 = '0'.repeat(num2.length - num1.length) + num1;
  } else if(num2.length < num1.length) {
    num2 = '0'.repeat(num1.length - num2.length) + num2;
  }

  for(let i = 0 ; i < num1.length ; i++) {
    str += Number(num1[i]) + Number(num2[i]);
  }

  return Number(str);
}

console.log(add(16, 18));
console.log(add(26, 39));
console.log(add(122, 81));