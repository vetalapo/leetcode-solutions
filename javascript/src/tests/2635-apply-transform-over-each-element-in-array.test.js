const map = require("../2635-apply-transform-over-each-element-in-array");

test("No indexer function", async () => {
    const inputArr = [1, 2, 3];
    const fn = function plusone(n) { return n + 1; };

    const result = map(inputArr, fn);

    expect(result).toStrictEqual([2, 3, 4]);
});

test("Indexer function", async () => {
    const inputArr = [1, 2, 3];
    const fn = function plusI(n, i) { return n + i; };

    const result = map(inputArr, fn);

    expect(result).toStrictEqual([1, 3, 5]);
});

test("Constant function", async () => {
    const inputArr = [10, 20, 30];
    const fn = function constant(n, i) { return 42; }

    const result = map(inputArr, fn);

    expect(result).toStrictEqual([42, 42, 42]);
});
