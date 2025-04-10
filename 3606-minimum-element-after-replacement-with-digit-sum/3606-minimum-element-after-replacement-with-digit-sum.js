/**
 * @param {number[]} nums
 * @return {number}
 */
var minElement = function(nums) {
    let digitSums = [];

    for (let i = 0; i < nums.length; i++) {
        let str = nums[i].toString(); 
        let sum = 0;

        for (let j = 0; j < str.length; j++) {
            sum += parseInt(str[j]); 
        }

        digitSums.push(sum); 
    }

    let min = Math.min(...digitSums);
    return min;
}

console.log(minElement([10, 12, 13, 14])); 
