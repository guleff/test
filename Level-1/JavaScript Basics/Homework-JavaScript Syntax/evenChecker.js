function evenNumber(n){

if(n%2==0){

return true;
}
	else{
		return false;
	}
}

var numbers=[3,127,588];

for(i in numbers){
console.log(evenNumber(numbers[i]));

}

