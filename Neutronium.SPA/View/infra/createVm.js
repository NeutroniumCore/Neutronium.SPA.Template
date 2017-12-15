import CircularJson from 'circular-json'
import {parser} from './jsonParser'

function updateVm(vm) {
    var window = vm.__window__
    if (window) {
        delete vm.__window__
        return { ViewModel: vm, Window: window }
    }
    return vm;
}

function createVM(rawVm) {
    var originalParser = JSON.parse;
    JSON.parse = parser;
    var res = updateVm(CircularJson.parse(rawVm));
    JSON.parse = originalParser;
    return res;
}


export {createVM}