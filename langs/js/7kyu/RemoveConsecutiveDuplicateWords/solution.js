let s = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";

const removeConsecutiveDuplicates = s => {
  const arr = s.split(' ');
  const str = [];
  for(let i = 0; i < arr.length; i++) {
    if(arr[i] !== arr[i + 1]){
      str.push(arr[i]);
    }
  }
  return str.join(' ');
}

console.log(removeConsecutiveDuplicates(s));