const last = require("../2619-array-prototype-last.js");

test("Gets last element", async () => {
    const inputArr = [ null, {}, 3];

    const result = inputArr.last();

    expect(result).toEqual(3);
});

test("Empty Array", async () => {
    const inputArr = [];

    const result = inputArr.last();

    expect(result).toEqual(-1);
});
