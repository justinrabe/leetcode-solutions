/*
First, each string is substringed into their halves. You then lowercase both strings, and remove vowels.
Then you compare then lengths.
*/
var halvesAreAlike = function(s) {
    let firsthalf = s.substr(0 , s.length / 2).toLowerCase().replace(/[aeiou]/ig,'');
    let secondhalf = s.substr(s.length / 2 , s.length - 1).toLowerCase().replace(/[aeiou]/ig,'');
    return firsthalf.length == secondhalf.length;
};