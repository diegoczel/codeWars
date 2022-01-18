function filter_list_classic(arr) {
  const result = [];
  for(let i = 0; i < arr.length; i++) {
    if(typeof arr[i] === 'number') result.push(arr[i]);
  }
  return result;
}

const filter_list = (arr) => {
  return arr.filter(element => typeof element === 'number');
};
// using arrow function and filter
console.log(filter_list([1,2,'a','b']));
console.log(filter_list([1,'a','b',0,15]));
console.log(filter_list([1,2,'aasf','1','123',123]));
// classic version
console.log(filter_list_classic([1,2,'a','b']));
console.log(filter_list_classic([1,'a','b',0,15]));
console.log(filter_list_classic([1,2,'aasf','1','123',123]));