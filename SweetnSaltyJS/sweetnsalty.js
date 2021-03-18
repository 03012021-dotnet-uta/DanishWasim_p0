"use strict";
// initializing variables
let sweet = "sweet";
let salty = "salty";
let sweetnsalty = "sweetnsalty";

let sweetNumber = 3;
let saltyNumber = 5;
// 5 and 3 in one
let sweetnsaltyNumber = 15;

// determine the words allowed per line
let printsPerLine = 10;

// set the start and the end counters
let startNumber = 0;
let endNumber = 1000;


function runSweetnSalty(start, end, printsPerLine) {
  let sweetCounter = 0;
  let saltyCounter = 0;
  let sweetnsaltyCounter = 0;
  let printString = "Run The Program";
  // loop from the start till the end
  for (let counter = start; counter < end; counter++) {
    //check if the 10th number is here to add a new line
    if (counter % printsPerLine == 0) {
      printString += "\n";
    }
    // first check if divisible by both for sweatnsalty, add string and increment counter
    if (counter % sweetnsaltyNumber == 0) {
      printString += sweetnsalty + "\t";
      sweetnsaltyCounter++;
    }
    // then check if sweet, add string and increment counter
    else if (counter % sweetNumber == 0) {
      sweetCounter++;
      printString += sweet + "\t";
    }
    // then check if salty, add string and increment counter
    else if (counter % saltyNumber == 0) {
      saltyCounter++;
      printString += salty + "\t";
    }
    // else just add the number, add number
    else {
      printString += counter + "\t";
    }
  }

  console.log(printString);

  printResult(sweet, sweetCounter);
  printResult(salty, saltyCounter);
  printResult(sweetnsalty, sweetnsaltyCounter);
}

function printResult(printString, counter) {
  console.log("the number of " + printString + " printed are: " + counter);
}

runSweetnSalty(startNumber, endNumber, printsPerLine);