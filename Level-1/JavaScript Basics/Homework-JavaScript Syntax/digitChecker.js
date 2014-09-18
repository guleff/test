function checkDigit(n){

var result=parseInt(n/100);
if(result%10===3){

return true;
}
	else{
	return false;
	}
}
var numbers=[1235,25368,123456];
for(i in numbers){
console.log(checkDigit(numbers[i]));
}



