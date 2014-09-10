function calcCylinderVol(r,h){

var volume=Math.round(Math.PI*r*r*h*1000)/1000;

return volume;
}
console.log(calcCylinderVol(2,4));
console.log(calcCylinderVol(5,8));
console.log(calcCylinderVol(12,3));