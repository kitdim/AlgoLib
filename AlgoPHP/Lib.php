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
}