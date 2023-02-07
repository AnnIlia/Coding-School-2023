//Session22

// 1. JavaScript function to reverse a string
function reverseString(str) {
    return str.split("").reverse().join("");
}

// UI code to accept input and display result
const input = document.querySelector("input");
const btn = document.querySelector("button");
const result = document.querySelector(".result");
let reversed = reverseString("lala");

// Log the result to the console
console.log(reversed);
btn.addEventListener("click", function () {
    result.textContent = reverseString(input.value);
});


// // Log the result to the console
console.log(reversed);