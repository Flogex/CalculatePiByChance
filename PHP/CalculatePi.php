<?php
function CalculatePi($iterations)
{
    $punkteImKreis = 0;
    for($i = 0; $i <= $iterations; $i++)
    {
        $x = lcg_value();
        $y = lcg_value();
        $distance = sqrt(pow(($x-0.5), 2) + pow(($y-0.5), 2));
        if($distance <= 0.5)
        {
            $punkteImKreis++;
        }
    }
    $pi = (4 * $punkteImKreis) / $iterations;
    return $pi;
}
?>
