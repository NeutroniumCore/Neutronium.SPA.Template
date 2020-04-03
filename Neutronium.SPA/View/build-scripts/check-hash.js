const { getHash } = require('./hash-builder');
const fs = require('fs');

const filePath = "./dist/hash.json";

let data
try {
  data = fs.readFileSync(filePath, { encoding: 'utf-8' });
}
catch (error) {
  console.log("problem reading file");
  process.exit(1);
}

const rootHash = JSON.parse(data).hash;

getHash().then(value => {
  const returnValue = value.hash === rootHash ? 0 : 1;
  process.exit(returnValue);
}).catch(err =>{
  process.exit(1);
});