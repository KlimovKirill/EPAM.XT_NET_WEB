'use strict';

function removeRepeatingLetters(str)
{
    var separators = [" ", ".", ",", ":", ";", "?", "!", "\t"];

    var stringArray = str.split('');

    var startPosition = 0; 
    var words = [];

    stringArray.forEach((letter, i) => {
        if (separators.indexOf(letter) != -1) {
            words.push(str.substr(startPosition, i - startPosition));
            startPosition = i + 1;
        }
    });
    words.push(str.substr(startPosition)); 

    var letters = {};

    words.forEach((word) => {
        word.split('').forEach(function (letter, i) {
            if (!letters[letter] && -1 != word.indexOf(letter, i + 1)) { 
                letters[letter] = 1; 
            }
        });
    });

    var result = stringArray.filter( v => { return !letters[v]; }).join('');
    return result;
}

var testString = "У попа была собака";
console.log(removeRepeatingLetters(testString));

