const { hashElement } = require('folder-hash');

const options = {
  folders: { exclude: ['.*', 'node_modules', 'test_coverage', 'tests', 'data', 'build-scripts', 'dist'] },
  files: { exclude: ['README.md'] }
};

async function getHash() {
  try {
    const hash = await hashElement('.', options);
    return hash;
  }
  catch (error) {
    console.error('hashing failed:', error);
    throw error;
  }
}

exports.getHash = getHash;