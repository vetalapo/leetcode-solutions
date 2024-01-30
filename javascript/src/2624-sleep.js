/**
 * 2621
 * Sleep
 **
 * Given a positive integer millis, write an asynchronous function that sleeps for millis milliseconds.
 * It can resolve any value.
 *
 * Example 1:
 *   Input: millis = 100
 *   Output: 100
 *   Explanation: It should return a promise that resolves after 100ms.
 *     let t = Date.now();
 *     sleep(100).then(() => {
 *       console.log(Date.now() - t); // 100
 *     });
 *
 * Example 2:
 *   Input: millis = 200
 *   Output: 200
 *   Explanation: It should return a promise that resolves after 200ms.
 *
 * Constraints: 1 <= millis <= 1000
 *
 * Hint 1:
 *   In Javascript, you can execute code after some delay with the setTimeout(fn, sleepTime) function.
 *
 * Hint 2:
 *   An async function is defined as function which returns a Promise.
 *
 * Hint 3:
 *   To create a Promise, you can code new Promise((resolve, reject) => {}).
 *   When you want the function to return a value, code resolve(value) inside the callback.
 **
 * https://leetcode.com/problems/sleep/
***/

/**
 * @param {number} millis
 * @return {Promise}
 */
async function sleep(millis) {
    await new Promise((resolve) => setTimeout(resolve, millis));
}

/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */

module.exports = sleep;
