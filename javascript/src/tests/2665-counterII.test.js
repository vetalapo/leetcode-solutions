const createCounter = require("../2665-counterII");

test("Returns a function", () => {
    const counter = createCounter(0);

    expect(typeof(counter)).toBe("object");
    expect(typeof(counter.increment)).toBe("function");
    expect(typeof(counter.decrement)).toBe("function");
    expect(typeof(counter.reset)).toBe("function");
});

test("Positive input", () => {
    const init = 5;
    const counter = createCounter(init);
    
    expect(counter.increment()).toBe(6);
    expect(counter.reset()).toBe(init);
    expect(counter.decrement()).toBe(4);
});

test("Zero input", () => {
    const init = 0;
    const counter = createCounter(init);
    
    expect(counter.increment()).toBe(1);
    expect(counter.increment()).toBe(2);
    expect(counter.decrement()).toBe(1);
    expect(counter.reset()).toBe(init);
    expect(counter.reset()).toBe(init);
});
