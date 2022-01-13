function fakeBin(x){
  // null, empty, undefined || not a string
  if(!x || typeof x !== 'string') return '';
  let str = '';
  for(let i of x) {
    (Number(i) < 5) ? str += '0': str += '1';
  }
  return str;
}

console.log(`${fakeBin('45385593107843568')} === '01011110001100111' -> ${fakeBin('45385593107843568') === '01011110001100111'}`);
console.log(`${fakeBin('509321967506747')} === '101000111101101' -> ${fakeBin('509321967506747') === '101000111101101'}`);
console.log(`${fakeBin('366058562030849490134388085')} === '011011110000101010000011011' -> ${fakeBin('366058562030849490134388085') === '011011110000101010000011011'}`);