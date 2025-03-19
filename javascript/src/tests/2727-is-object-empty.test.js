const isEmpty = require("../2727-is-object-empty");

test("Object with properties", async () => {
    const inputObj = { "x": 5, "y": 42 };
    const result = isEmpty(inputObj);

    expect(result).toEqual(false);
});

test("Empty object", async () => {
    const inputObj = { };
    const result = isEmpty(inputObj);

    expect(result).toEqual(true);
});

test("Filled array as an object", async () => {
    const inputObj = [null, false, 0];
    const result = isEmpty(inputObj);

    expect(result).toEqual(false);
});
