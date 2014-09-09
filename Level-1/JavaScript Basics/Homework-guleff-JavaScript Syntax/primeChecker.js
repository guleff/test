function isPrime(n){

for(i=2;i<n;i++){

if(n%i===0){
	return false;
}
if(i===n-1){
	return true;
		}
	}
}

var nums=[7,254,587];
for(i in nums){
console.log(isPrime(nums[i]));
}