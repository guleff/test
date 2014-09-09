<?php

$val = 4727.7864;

if(gettype($val)=="integer" || gettype($val)=="double"){
    var_dump($val);
}
 else {
  //  var_dump(gettype($val));
    switch (gettype($val)){
    case "string":echo("string");
        break;
    case "array":echo("array");
        break;
    case "object":echo("object");
        break;
    }
}

?>