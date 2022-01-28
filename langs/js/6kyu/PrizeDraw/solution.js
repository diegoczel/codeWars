function rank(st, we, n) {
  // , e ' ' at end ?
  if(!st) return "No participants";

  const arrSt = st.split(',');
  
  if(n > arrSt.length) return "Not enough participants";

  const winNum = arrSt.map(function(item, i){
    let sum = item.length;
    for(let ind = 0; ind < item.length; ind++) {
      sum += rankLetter(item[ind]);
    }
    return sum * we[i];
  });
  //console.log(arrSt);
  //console.log(winNum);

  const arrMulti = arrSt.map((item, i) => {
    return [item, winNum[i], we[i]];
  });
  //console.log(arrMulti);
  arrMulti.sort(order);
  //console.log(arrMulti);
  //console.log(arrMulti[n - 1][0]);
  return arrMulti[n - 1][0];
  //Array.sort(function of ordenation) -> https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Array/sort
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
function order(a, b) {
  /* ordem crescente
  if(a[1] < b[1]) {
    return -1;
  } 
  if(a[1] > b[2]) {
    return 1;
  }
  // is equal
  if(a[0] < b[0]) return -1;
  if(a[0] > b[0]) return 1;

  return 0;*/
  // ordem decrescnte
  if(b[1] < a[1]) {
    return -1;
  } 
  if(b[1] > a[2]) {
    return 1;
  }
  // is equal
  if(b[0] < a[0]) return -1;
  if(b[0] > a[0]) return 1;

  return 0;
}
/*console.log(rankLetter('C'));
console.log(rankLetter('A'));
console.log(rankLetter('R'));
console.log(rankLetter('O'));
console.log(rankLetter('L'));*/

console.log(rank("COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH",[1, 4, 4, 5, 2, 1],4));
console.log(rank("Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin",[4, 2, 1, 4, 3, 1, 2],4));
console.log(rank("Lagon,Lily",[1, 5],2));
console.log(rank("Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin",[4, 2, 1, 4, 3, 1, 2],8));
console.log(rank("",[4, 2, 1, 4, 3, 1, 2],6));

console.log(rank("David,Isabella,Ethan,Lagon,Willaim,Andrew,Ella,James,Liam,Jacob,Ava,Mason,Lily,William,Elizabeth,Abigail,Sofia,Emma,Emily,Robert,Matthew,Natalie,Alexander,Mia,Naoh,Lyli,Noah,",[1,4,6,4,6,4,5,3,5,4,5,1,3,1,4,5,1,2,6,6,5,4,2,3,2,3,1], 14));
console.log(rank("Madison,Michael,Sofia,Lyli,Lily,Robert,Joshua,Aubrey,Isabella,Naoh,Benjamin,Olivai,Matthew,Jacob,Elizabeth,Emma,Emily,Aiden,Ava, ",[2,3,2,4,5,6,6,2,4,6,1,3,5,3,2,1,4,3,4], 5));