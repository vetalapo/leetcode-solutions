const reduceFn = require("../2626-array-reduce-transformation.js");

test("Array sum", async () => {
    const arr = [1, 2, 3, 4];
    const func = (acc, curr) => acc + curr;
    const init = 0;

    const result = reduceFn(arr, func, init);

    expect(result).toEqual(10);
});

test("Square sum of the array", async () => {
    const arr = [1, 2, 3, 4];
    const func = (acc, curr) => acc + curr * curr;
    const init = 100;

    const result = reduceFn(arr, func, init);

    expect(result).toEqual(130);
});

test("Empty array", async () => {
    const arr = [];
    const func = (acc, curr) => 0;
    const init = 25;

    const result = reduceFn(arr, func, init);

    expect(result).toEqual(25);
});
