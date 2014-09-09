var date = new Date();
var hours = date.getHours();
var mins = date.getMinutes();

var hour = hours < 10 ? "0" + "" + hours : hours;

var min=mins < 10 ? "0" + "" + mins :mins;


console.log(hour+":"+min);