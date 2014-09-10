<!DOCTYPE html>


<html>
    <head>
        <meta charset="UTF-8">
        <title>Print Tags</title>
    </head>
    <body>
        <p>Enter Tags</p><br>
        <form method="post">
            <input type="text" name="txt"/>
            <input type="submit" value="Submit"/>
        </form>
        
        <?php
        $input_test="pesho,,gosho,mosho, lara ,Pesho, homework, homework, exam, course, PHP";
        if($_SERVER['REQUEST_METHOD'] === 'POST') {
        $input=$_POST['txt'];
        $out = preg_split("/[, ]+/", $input);
        for ($index = 0; $index < count($out); $index++) {
        echo($index . " : " . $out[$index] . "<br>");
    }
} 

        $arr=  preg_split("/[, ]+/", $input_test);
        $result=[];
        foreach ($arr as $value) {
            
            if(in_array($value, $result)){
                $result[$value]++;
              //  array_push($result, $value ."=>". $count++ );
            }
            else {
                array_push($result, $value);
                $result[$value]=1;
            }
            
}
$counter=0;
$possition;
foreach ($result as $key => $value) {
     if(is_numeric($value)){
         echo $value . " times" . "<br>";
         if($value>$counter){
             $counter=$value;
             $possition=$result[$key];
         }
     }
 else {
     echo $value . " : ";    
     }
}
echo("<br>Most frequent tag is : " . $result[$possition] . $counter);
//echo(count($result));

//for ($index1 = 0; $index1 < count($result); $index1++) {
//    echo($result[$index1]."<br>");
//}


//$test=$result;
//echo(array_values($test));



        ?>
    </body>