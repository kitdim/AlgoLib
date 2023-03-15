<?php
class SearchLib
{
    static function LinerSearch(array $arr,float $countArr, int $searchValue): string
    {
        $last = $arr[$countArr];
        $arr[$countArr] = $searchValue;
        $i = 0;
        $result = "<br />not found";

        while ($arr[$i] != $searchValue)
        {
            $i++;
        }

        $arr[$countArr] = $last;

        if ($i<$countArr || $arr[$countArr] == $searchValue){
            $result = "<br />Найдено";
            return $result;
        }
        return $result;
    }
    static function RecursLinearSearch(array $arr, float $countArr, int $index, float $searchValue): string
    {
        if ($index > $countArr)
            return "<br />Not found";
        elseif ($index <= $countArr && $arr[$index] == $searchValue)
            return "Found: {$arr[$index]}, by array index {$index}";
        elseif ($index <= $countArr && $arr[$index] != $searchValue)
            return self::RecursLinearSearch($arr, $countArr, $index + 1, $searchValue);
        else
            return "<br />Not found";

    }
}