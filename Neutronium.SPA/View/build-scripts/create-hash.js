const { getHash } = require('./hash-builder');
const fs = require('fs');

async function saveHash() {
  let hash;
  try {
    hash = await getHash();
  }
  catch {
    console.log("Problem hash file not updated");
    return;
  }
  fs.writeFile("./dist/hash.json", JSON.stringify(hash), function (err) {
    if (err) {
      console.log("Problem hash file not updated");
      return;
    }
    console.log("hash file updated");
  });
}

saveHash();