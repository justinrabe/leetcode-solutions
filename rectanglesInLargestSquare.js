/**
First, loop through to find the largest possible rectangle.
Second, loop through again to find the total that can fit.
 */
var countGoodRectangles = function(rectangles) {
    var maxLen = Math.min(rectangles[0][0], rectangles[0][1]);
    var total = 0;

    for (var i = 0; i < rectangles.length; i++) {
        if (Math.min(rectangles[i][0], rectangles[i][1]) > maxLen)
          maxLen = Math.min(rectangles[i][0], rectangles[i][1]);
    }
    console.log(maxLen)
    for (var i = 0; i < rectangles.length; i++) {
        if (Math.min(rectangles[i][0], rectangles[i][1]) >= maxLen) {
          total++;
        }
    }
    return total;
};