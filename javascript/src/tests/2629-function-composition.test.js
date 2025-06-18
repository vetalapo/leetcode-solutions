const compose = require("../2629-function-composition");

test("Positive input", async () => {
    const inputFunctions = [x => x + 1, x => x * x, x => 2 * x];
    const x = 4;

    const result = compose(inputFunctions)(x);

    expect(result).toBe(65);
});

test("1 as an input", async () => {
    const inputFunctions = [x => 10 * x, x => 10 * x, x => 10 * x];
    const x = 1;

    const result = compose(inputFunctions)(x);

    expect(result).toBe(1000);
});

test("No functions supplied", async () => {
    const inputFunctions = [];
    const x = 42;

    const result = compose(inputFunctions)(x);

    expect(result).toBe(42);
});
