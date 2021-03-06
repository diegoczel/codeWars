function rank(st, we, n) {
  if(!st) return "No participants";

  st = st.trim();
  st = st.replace(/[,]*$/g, '');

  const arrSt = st.split(',');
  
  if(n > arrSt.length) return "Not enough participants";

  // calculate the win number of each item
  const winNum = arrSt.map(function(item, i){
    let sum = item.length;
    for(let ind = 0; ind < item.length; ind++) {
      sum += rankLetter(item[ind]);
    }
    return sum * we[i];
  });
  //console.log(arrSt);
  //console.log(winNum);

  // c
  const arrMulti = arrSt.map((item, i) => {
    return [item, winNum[i], we[i]];
  });
  //console.log(arrMulti);
  arrMulti.sort(order);
  //console.log(arrMulti);
  //console.log(arrMulti[n - 1][0]);
  return arrMulti[n - 1][0];
  
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
  // ordem decrescnte
  if(b[1] < a[1]) return -1;
  if(b[1] > a[1]) return 1;
  // is equal, then check the name
  if(b[0] > a[0]) return -1;
  if(b[0] < a[0]) return 1;
  return 0;
}
/*console.log(rankLetter('C'));
console.log(rankLetter('A'));
console.log(rankLetter('R'));
console.log(rankLetter('O'));
console.log(rankLetter('L'));*/

/*console.log(rank("COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH",[1, 4, 4, 5, 2, 1],4));
console.log(rank("Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin",[4, 2, 1, 4, 3, 1, 2],4));
console.log(rank("Lagon,Lily",[1, 5],2));
console.log(rank("Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin",[4, 2, 1, 4, 3, 1, 2],8));
console.log(rank("",[4, 2, 1, 4, 3, 1, 2],6));

console.log(rank("David,Isabella,Ethan,Lagon,Willaim,Andrew,Ella,James,Liam,Jacob,Ava,Mason,Lily,William,Elizabeth,Abigail,Sofia,Emma,Emily,Robert,Matthew,Natalie,Alexander,Mia,Naoh,Lyli,Noah,",[1,4,6,4,6,4,5,3,5,4,5,1,3,1,4,5,1,2,6,6,5,4,2,3,2,3,1], 14));
console.log(rank("Madison,Michael,Sofia,Lyli,Lily,Robert,Joshua,Aubrey,Isabella,Naoh,Benjamin,Olivai,Matthew,Jacob,Elizabeth,Emma,Emily,Aiden,Ava, ",[2,3,2,4,5,6,6,2,4,6,1,3,5,3,2,1,4,3,4], 5));
*/
//console.log(rank("Olivia,Grace,William,David,Joshua,Olivai,Elizabeth,Robert,Mia,Addison,Natalie,Abigail,Logan,Naoh,Jayden,Aubrey,Ava,Chloe,Lily,Jacob,Alexander,Liam,Lagon,Lyli, ", [2,4,2,6,3,2,5,6,2,1,1,2,1,3,3,2,6,2,1,2,2,3,1,6], 12));
