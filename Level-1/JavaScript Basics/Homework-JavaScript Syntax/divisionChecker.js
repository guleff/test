function divisionBy3(n){

if(n%3==0){
console.log('the number is divided by 3 without remainder');
}
else{
console.log('the number is not divided by 3 without remainder');
	}
	console.log(sumOfDigits());
}

function sumOfDigits(n){
var result=0;
do{
result+=n%10;
n/=10;
}while(n>10)
return result;
}



console.log(sumOfDigits());