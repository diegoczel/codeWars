function wordMesh(arr){
  if(!arr) return "failed to mesh"; // arr is null, empty or undefined
  
  let str = '';

  for(let i = 0; i < arr.length - 1; i++) {
    let s = mesh(arr[i], arr[i+1]);
    
    if(s === '') return "failed to mesh";

    str += s;
  }
  return str;
}

function mesh(x, y) {
  if(!x || !y) return '';

  let lenX = x.length;
  let lenY = y.length;

  let len = (lenX < lenY) ? lenX : lenY;

  let s = '';

  for(let i = 1; i <= len; i++ ) {

    if(x.slice(lenX - i, lenX) === y.slice(0, i)) {
      s = x.slice(lenX - i, lenX);
    }

    
  }
  return s;
}

console.log(mesh('allow', 'lowering'));
console.log(mesh('lowering', 'ringmaster'));
console.log(mesh('ringmaster', 'terror'));

console.log(wordMesh(["allow", "lowering", "ringmaster", "terror"]));