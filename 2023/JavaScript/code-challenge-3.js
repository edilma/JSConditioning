// Given any array of numbers (all will be > 0),
// write a function that returns the number of odd
// numbers in the array.

function countOddNumbers(list) {
    let newArray =[];
    for (let index = 0; index < list.length; index++) {
        if (list[index]%2 !=0) {
            newArray.push(list[index]);
        }
        // Your answer goes here...
    }
    return newArray;
  }
  
  const myNums = [17, 24, 69, 86, 42, 13, 11]
  
  const numOdd = countOddNumbers(myNums) // should return 4
  
  console.log(numOdd)