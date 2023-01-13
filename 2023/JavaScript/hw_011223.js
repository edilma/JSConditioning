// 1. Create a function that takes an array of numbers and returns a new array with the square of each number.
function expNumber (arr, num=0){
    const newArray =[];
    for (let i = 0; i < arr.length; i++) {
        let expN = arr[i]**num;
        newArray.push(expN);
    }
    return newArray;
}

//2. Create a function that takes in a number of two-pointers and three-pointers made and returns a basketball
// team’s total score. Console.log the results.
function teamScoreCal (double=0, triple = 0 ){
    return double*2 + triple*3;
}

//3. Create a function that converts a string to uppercase letters. Console.log the result
function convertToUpper(word =""){
    return word.toUpperCase();
}

const myArray = [1,2,3,5,7,4,6];

const myString = "Hello how are you today?"

const theSquares = expNumber(myArray,2);
console.log(theSquares);

const teamScore = teamScoreCal(8,3);
console.log(`The team's score is ${teamScore} points`);

console.log(convertToUpper(myString));



 
