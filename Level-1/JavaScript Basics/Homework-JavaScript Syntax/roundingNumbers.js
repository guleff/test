var n = [ '22.7', '12.3', '58.7' ]; 

function roundNumber(numbers){
  for(i in numbers){
    console.log(Math.floor(numbers[i]));
	console.log(Math.round(numbers[i]));
  }
}

roundNumber(n);

