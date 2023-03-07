<?php
require_once 'Lib.php';

$arr = [1,5,6,6,8,9,8,8,5,2,1,9,-9,5,-5];
$count = count($arr) - 1;
$searchValue = rand(min($arr), max($arr));

foreach ($arr as $item) echo " {$item}";
echo "<br/>Ищем: {$searchValue}";
echo SearchLib::LinerSearch($arr, $count, $searchValue);
