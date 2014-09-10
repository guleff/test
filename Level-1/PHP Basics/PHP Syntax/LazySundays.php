<?php

$date= getdate();
$currentDay=date('d');
$currentMonth=date('m');
$currentYear=date('y');
$dayOfWeek;
$daysInMonth = cal_days_in_month(CAL_GREGORIAN, $currentMonth, $currentYear);
$nextSunday;

foreach ($date as $value) {
    if($value=="Monday" || $value=="Tuesday" || $value=="Wednesday" || $value=="Thursday" || $value=="Friday" || $value=="Saturday" || $value=="Sunday"){
        $dayOfWeek=$value;
    }
    //echo($value . " ");
}
switch ($dayOfWeek) {
    case "Monday":$nextSunday=$currentDay+6;
                break;
    case "Tuesday":$nextSunday=$currentDay+5;
                break;
    case "Wednesday":$nextSunday=$currentDay+4;
                break;
    case "Thursday":$nextSunday=$currentDay+3;
                break;
    case "Friday":$nextSunday=$currentDay+2;
                break;
    case "Saturday":$nextSunday=$currentDay+1;
                break;
    case "Sunday":$nextSunday=$currentDay+7;
                break;
    default:
        break;
}


for ($index = $nextSunday; $index <= $daysInMonth; $index+=7) {
    $dayStr;
    $monthStr;
    $yearStr="20".$currentYear;
    if($index<20){
        if($index===2){
            $dayStr=$index."nd";
        }
       else if($index===3){
            $dayStr=$index."rd";
        }
        else {
            $dayStr=$index."th";
        }
    }
 else {
        if($index%10==1){
            $dayStr=$index."st";
        }
       else if($index%10==2){
            $dayStr=$index."nd";
        }
        else if($index%10==3){
            $dayStr=$index."rd";
        }
        else {
            $dayStr=$index."th";
        }
    }
    switch ($currentMonth){
        case "01";$monthStr="January";
break;
        case "02";$monthStr="February";
break;
        case "03";$monthStr="March";
break;
        case "04";$monthStr="April";
break;
        case "05";$monthStr="May";
break;
        case "06";$monthStr="June";
break;
        case "07";$monthStr="July";
break;
        case "08";$monthStr="August";
break;
        case "09";$monthStr="September";
break;
        case "10";$monthStr="October";
break;
        case "11";$monthStr="November";
break;
        case "12";$monthStr="December";
break;
    }
    
    echo($dayStr . " " . $monthStr . ", " . $yearStr . "<br/>" );
    
}

?>