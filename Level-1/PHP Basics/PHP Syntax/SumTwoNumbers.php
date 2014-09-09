<?php

$firstNumber = 1.567808;
$secondNumber = 0.356;
$result = $firstNumber + $secondNumber;
$formatted_result= number_format($result, 2);

$output="$"."firstNumber + " ."$"."secondNumber = ". $firstNumber . " + " . $secondNumber . " = " . $formatted_result;

echo($output);

?>