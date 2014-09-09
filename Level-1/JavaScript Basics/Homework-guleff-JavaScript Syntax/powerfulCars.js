function convertKWtoHP(kw){

var result=(kw*1.34102209);
result=Math.round(result*100)/100 ;
return result;
}

var kw=[75,150,1000];
for(i in kw){
console.log(convertKWtoHP(kw[i]));
}