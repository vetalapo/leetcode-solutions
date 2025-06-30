const expectFn = require("../2704-to-be-or-not-to-be");

test("Valid equal inputs, toBe", async () => {
    const expectInput = 5;
    const toBeOutput = 5;

    const result = expectFn(expectInput).toBe(toBeOutput);

    expect(result).toBe(true);
});

test("Invalid inputs, throw an Error", async () => {
    const expectInput = 5;
    const toBeOutput = null;

    expect(() => expectFn(expectInput).toBe(toBeOutput)).toThrow("Not Equal");
});

test("Valid not equal inputs, notToBe", async () => {
    const expectInput = 5;
    const notToBeOutput = null;

    const result = expectFn(expectInput).notToBe(notToBeOutput);

    expect(result).toBe(true);
});
