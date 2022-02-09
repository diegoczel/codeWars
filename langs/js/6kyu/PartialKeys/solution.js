function partialKeys (obj) {
  // target is the object original
  // prop is a prop of objet that it is manipulated
  // value is used into a set operation over obj
  const handler = {
    get: function(target, prop, /*value*/) {
      // find all prop's that start it arg prop, then sort, then find into target one prop that match for return it.
      let keys = Object.keys(target).filter(key => key.startsWith(prop)).sort();
      if(keys.length > 0) return target[keys[0]];
    }
  };
  
  // Proxy é um manipulador de objeto, que permite fazer uma ponte para manipular as operações get e set do object.
  // nesse problema, manipulamos o get, para permitir selecionar uma propriedade pelo inicio dela, exemplo:
  // Tem a prop idNumber, com o proxy, permite chamar obj.id, que irá retornar o valor contido na propriedade idNumber.
  return new Proxy(obj, handler);
}

const x = {'idNumber': 1, 'idAge': 26};
const y = partialKeys(x);
const z = partialKeys({});
const a = partialKeys({ aaa: 1, abc: 2, dfg: 3, def: 4, dfgh: 5 });
/*console.log(y.idNumber);
console.log(y.id);
console.log(y.i);*/
console.log(z.id);
console.log(a.ef);
console.log(a.c);
console.log(a.b);
console.log(a.gggg);