function rank(st, we, n) {
  if(!st) return "No participants";

  const arrSt = st.split(',');
  if(arrSt.length !== n) return "Not enough participants";

  const winNum = arrSt.map(function(item, i){
    let sum = 0;
    for(let i = 0; i < item.length; i++) {
      sum += rankLetter(item[i]);
    }
    return sum * we[i];
  });
  console.log(st);
  console.log(we);
  console.log(winNum);
  console.log(n);
}

function rankLetter(letter) {
  const lowerBegin = 'a'.charCodeAt(); // 97
  const lowerEnd = 'z'.charCodeAt(); // 122
  const upperBegin = 'A'.charCodeAt(); // 65
  const upperEnd = 'Z'.charCodeAt(); // 90
  const codeL = letter.charCodeAt();
  if(codeL <= lowerEnd && codeL >= lowerBegin) {
    return (codeL - lowerBegin) + 1;
  } else if(codeL <= upperEnd && codeL >= upperBegin) {
    return (codeL - upperBegin) + 1;
  }
  return 0;
}
console.log(rankLetter('P'));
console.log(rankLetter('a'));
console.log(rankLetter('u'));
console.log(rankLetter('L'));

rank("PauL",[2],1);