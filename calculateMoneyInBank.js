/*
This can be solved in O(1), however this solution runs in O(n) as most people wouldn't be able to find that equation easily.
You basically convert i into a day using modulus. You add up that with the week variable for the total.
*/
var totalMoney = function(n) {
    var total = 0;
    var week = 0;
    var day = 0;
    for (var i = 1; i <= n; i ++) {
        day = i % 7 == 0 ? 7 : i % 7;
        if (day == 1 && i != 1) week++;
        total = total + day + week;
    }
    return total;
};