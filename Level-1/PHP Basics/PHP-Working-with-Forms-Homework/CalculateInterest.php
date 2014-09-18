<?php

if($_SERVER['REQUEST_METHOD'] === 'POST') {
    $amount = $_POST['amount'];
    $interest=$_POST['interest'];
    $currency = $_POST['currency'];
    $duration=$_POST['duration'];
    $monthlyInterests=$interest/12;
    $totalAmount=$amount;
    
    for ($index = 0; $index < $duration; $index++) {
        $totalAmount+=($totalAmount*$monthlyInterests)/100;
        if($index==$duration-1){
            switch ($currency){
                case "usd":echo("$ " . round($totalAmount, 2) . "<br>");
                    break;
                default :echo(round($totalAmount, 2) . "<br>");
                    break;
            }
        }
    }
}
?>  
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8"/>
    <title>Get Form Data</title>
    <style>
        input[type="text"], label {
            display: block;
        }
    </style>
</head>
<body>
<form method="post" action="">
    <input type="text" name="amount" placeholder="">
    <label for="usd"><input type="radio" id="usd" name="currency" value="usd">USD</label>
    <label for="eur"><input type="radio" id="eur" name="currency" value="eur">EUR</label>
    <label for="bgn"><input type="radio" id="bgn" name="currency" value="bgn">BGN</label>
    <input type="text" name="interest" placeholder="">
    <select name="duration">
    <option value="6">6 Months</option>
    <option value="12">1 Year</option>
    <option value="24">2 Years</option>
    <option value="60">5 Years</option>
    </select> 
    <input type="submit" value="Sumbit">
</form>
</body>
</html>
