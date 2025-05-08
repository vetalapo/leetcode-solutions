const fibGenerator = require("../2648-generate-fibonacci-sequence");

test("Generates sequence", () => {
    const generator = fibGenerator();

    expect(generator.next().value).toBe(0);
    expect(generator.next().value).toBe(1);
    expect(generator.next().value).toBe(1);
    expect(generator.next().value).toBe(2);
    expect(generator.next().value).toBe(3);
});

test("No calls", () => {
    const generator = fibGenerator();

    expect(generator.value).toBe(undefined);
});
