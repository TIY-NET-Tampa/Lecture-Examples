var x = 5;
console.log(x);
console.log(typeof x)
x = "not a number";
console.log(x);
console.log(typeof x)
x = true;
console.log(x);
console.log(typeof x)

x = 3.4;
console.log(x);
console.log(typeof x)


function hi() {
    return {
        value: 4
    };
}

function add(x, y) {
    return x + y;
}


console.log(add(4, 5));
console.log(add("hello ", "world"));
console.log(add(4, "5"));

var oceans = {
    id: 1,
    name: "Pacific",
    "Average Temp": 23,

};

console.log(oceans.name);
console.log(oceans['Average Temp']);
console.log(oceans[2]);


var myCoolArray = [1, 2, 3, 4, 5, 6, 7];
console.log("array");
myCoolArray.forEach(function (item, index) {
    console.log(item, index);
});


var odds = myCoolArray.filter(function (x) {
    return x % 2 == 0;
});

var squares = myCoolArray.map(function (item) {
    return item;
});

console.log(squares);