'use strict';

function stringMathCalculator(str) {
    
    var regex = /\-?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1}/ig;

    var arrayOfExpElements = [];
    arrayOfExpElements = str.match(regex);
    
    var result = 0;
    result = +arrayOfExpElements[0];

    for (var i = 0; i < arrayOfExpElements.length; i++)
    {
        if(arrayOfExpElements[i] < 0)
            {
                var temp = arrayOfExpElements[i].toString().substring(1);
                arrayOfExpElements.splice(i, 1, '-', temp)
            }
    }

    for (var i = 0; i < arrayOfExpElements.length; i++)
    {
        switch(arrayOfExpElements[i])
        {
            case '+': 
                result += Number(arrayOfExpElements[i + 1]);
                break;
            case '-': 
                result -= Number(arrayOfExpElements[i + 1]);
                break;
            case '*': 
                result *= Number(arrayOfExpElements[i + 1]);
                break;
            case '/': 
                result /= Number(arrayOfExpElements[i + 1]);
                break;
            case '=': 
                break;
            
            default: 
                break;
        }
    }

   return result;
}

var str = "3.5 +4*10-5.3 /5 = ";
console.log(stringMathCalculator(str).toFixed(2));

