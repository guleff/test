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
        //$input_test="pesho,,gosho,mosho, lara";
        if($_SERVER['REQUEST_METHOD'] === 'POST') {
        $input=$_POST['txt'];
        $out = preg_split("/[, ]+/", $input);
        for ($index = 0; $index < count($out); $index++) {
        echo($index . " : " . $out[$index] . "<br>");
    }
} 
        ?>
    </body>
</html>
