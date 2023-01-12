//1. Using your loop of choice. Create a function that prints the pyramid below. (Show your personality by using your favorite emoji)
//2. Create a function that removes the first element of the array below and adds “kiwi” to the end of the array
// 3. Write a function named assignGrade, that takes one argument, a number score.
//Return a grade for the score, either “A,” “B,” “C,” “D,” or “F.” 

//print an emoji in a piramid shape
function printEmoji(emoji, number){
    for(let i=0;i<number+1;i++){
        let text = emoji;
        console.log(text.repeat(i));
    }
}

//change an array according to instructions
function changeArray(arr){
    arr.pop();
    arr.unshift("kiwi");
    return arr;
}

//
function assignGrade(score){
    switch (true){
        case(score>90): return "A";
        break;
        case(score>80): return "B";
        break;
        case(score>70): return "C";
        break;
        case(score>60): return "D";
        break;
        case(score>=0): return "F";
        break;
    }
    }


//testing the functions
let favoriteFruits = ["mango", "lychee", "rambutan", "papaya"];

console.log(printEmoji("🎁",5));

console.log(changeArray(favoriteFruits));

console.log("Your score is ", assignGrade(86));

