console.log("Hello world", "Hi Jeff", 4 + 5);

// Varibles 

//NO : var x= 5;
let y = 6;
const z = 7;

y = "hello world";

console.log("y & z", y, z);

if (z > 6) {

}


if (!true) {
    console.log("It was true")
} else {
    console.log("not true");
}

let x = 5 + 10;

if (x === 15) {
    // yes
}

if (x == "15") {
    // ALso true
}

for (let i in o) {
    // foreach
}
while (true) {

}


do {

} while (true);


let myObj = {
    first: "hello", 
    second: 123,
    someBool: false
}

myObj.first = "hellooooo";

myObj.totalNewProperty = 5846;


class Rectangle {
    constructor(height, width) {
        this.height = height;
        this.width = width;
    }
}

let sq = new Rectangle(4, 4);



let arr = [];

arr[4] = 5
arr[2] = "helllooo";


function add(x, y) {
    return x + y;
}

const subtract = function (x, y) {
    return x - y;
}
const mult = (x, y) => x * y;

add(4, 5);
subtract(9, 3);

add = 5;

add(7, 8);