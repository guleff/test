function calcSupply(data){

for(index in data){
	var totalFood=((data[index].maxAge-data[index].currentAge)*365)*data[index].dailyFood;
	var output=totalFood+''+'kg of chocolate would be enough until I am '+data[index].maxAge+' years old.'
	console.log(output);
	}
}

var data=[{
currentAge:38,
maxAge:118,
dailyFood:0.5	
},{
currentAge:20,
maxAge:87,
dailyFood:2
},{
currentAge:16,
maxAge:102,
dailyFood:1.1
}];

calcSupply(data);
