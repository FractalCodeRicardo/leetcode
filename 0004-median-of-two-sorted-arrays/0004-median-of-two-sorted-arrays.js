/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {
    let newArray = [];

    newArray.push(...nums1)
    newArray.push(...nums2)

    newArray = newArray.sort((a, b) => a - b);

    let isEven = newArray.length % 2 == 0;
    let middleIndex = Math.floor(newArray.length / 2);

    if (isEven) {
        return (newArray[middleIndex] + newArray[middleIndex-1]) / 2;
    }

    return newArray[middleIndex]
};