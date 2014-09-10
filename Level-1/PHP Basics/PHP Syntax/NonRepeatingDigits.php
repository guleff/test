<?php

$input=247;

if($input<100){
    echo("No");
    die;
}
 else {
    for ($i=100;$i<=$input;$i++){
        $a;$b;$c;
        $a=$i%10;
        $b=($i/10)%10;
        $c=($i-($i%100))/100;
        if($i>999){
            die;
        }
        if($a!==$b && $a!==$c && $b!==$c){
            echo($i . " ");
        }   
    }
}

?>