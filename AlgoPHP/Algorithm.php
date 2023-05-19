<?php

class Algorithm
{
    static function LinerSearch(array $arr, float $countArr, int $searchValue): string
    {
        $last = $arr[$countArr];
        $arr[$countArr] = $searchValue;
        $i = 0;
        $result = "<br />not found";

        while ($arr[$i] != $searchValue) {
            $i++;
        }

        $arr[$countArr] = $last;

        if ($i < $countArr || $arr[$countArr] == $searchValue) {
            $result = "<br />Найдено";
            return $result;
        }
        return $result;
    }

    static function recurs_linear_search(array $arr, float $countArr, int $index, float $searchValue): string
    {
        if ($index > $countArr)
            return "<br />Not found";
        elseif ($index <= $countArr && $arr[$index] == $searchValue)
            return "Found: {$arr[$index]}, by array index {$index}";
        elseif ($index <= $countArr && $arr[$index] != $searchValue)
            return self::recurs_linear_search($arr, $countArr, $index + 1, $searchValue);
        else
            return "<br />Not found";

    }

    static function BinaryFunction(array $arr, float $countArr, float $searchValue): string
    {
        $lowIndex = 0;
        $highIndex = $countArr;

        while ($lowIndex <= $highIndex) {
            $middleIndex = round(($lowIndex + $highIndex) / 2);

            if ($arr[$middleIndex] == $searchValue)
                return "<br/ > Found";
            elseif ($arr[$middleIndex] > $searchValue)
                $highIndex = $middleIndex - 1;
            else $lowIndex = $middleIndex + 1;
        }
        return "<br/>Not found";
    }

    static function BinaryFunctionRec(array $arr, int $lowIndex, int $highIndex, int $searchValue): string
    {
        if ($lowIndex > $highIndex)
            return "<br/>Not found";
        else {
            $middleIndex = round(($lowIndex + $highIndex) / 2);
            if ($arr[$middleIndex] == $searchValue)
                return "<br/ > Found";
            elseif ($arr[$middleIndex] > $searchValue)
                return self::BinaryFunctionRec($arr, $lowIndex, $highIndex - 1, $searchValue);
            else
                return self::BinaryFunctionRec($arr, $lowIndex + 1, $highIndex, $searchValue);
        }
    }

    static function SelectionSort(array $arr): array
    {
        $size = count($arr);
        if ($size <= 1)
            return $arr;
        for ($i = 0; $i < $size - 1; $i++) {
            $smallest = $i;
            for ($j = $i + 1; $j < $size; $j++)
                if ($arr[$j] < $arr[$smallest])
                    $smallest = $j;

            $foo = $arr[$i];
            $arr[$i] = $arr[$smallest];
            $arr[$smallest] = $foo;
            /* Ниже производительность. процессору гораздо удобнее просто начать брать значение из другого места,
            чем терять время на перекладывание значений из одного куска памяти в другой, и обратно.
            $arr[$j] += +$arr[$smallest] - $arr[$smallest] = $arr[$j];
            */
        }

        return $arr;
    }

    static function InsertSor(array $arr): array
    {
        if (count($arr) <= 1)
            return $arr;
        for ($i = 1; $i < count($arr); $i++) {
            $key = $arr[$i];
            $j = $i - 1;
            while (isset($arr[$j]) && $arr[$j] > $key) {
                $arr[$j + 1] = $arr[$j];
                $arr[$j] = $key;
                $j--;
            }

        }
        return $arr;
    }

<<<<<<< HEAD:AlgoPHP/Lib.php
    static function mergeSort(array $array, int $start, int $end): array
    {
        if ($start >= $end)
            return $array;

        $middle = ($start + $end) / 2;
        self::mergeSort($array, $start, $middle);
        self::mergeSort($array, $middle + 1, $end);

        $merge = function (array $array, int $start, int $middle, int $end)
=======
    static function mergeSort(array $array): array
    {
        $count = count($array);
        if($count <= 1)
>>>>>>> 5b0ad055356b5514b293d3a6362bd3f681a89caa:AlgoPHP/Algorithm.php
        {
            return $array;
        }
        $left = @array_slice($array, 0, $count/2);
        $right = @array_slice($array, $count/2);

        $left = self::mergeSort($left);
        $right = self::mergeSort($right);

        $merge = function ($left, $right)
        {
            $ret = [];
            while (count($left) > 0 && count($right) > 0) {
                if ($left[0] < $right[0]) {
                    array_push($ret, array_shift($left));
                } else {
                    array_push($ret, array_shift($right));
                }
            }

            array_splice($ret, count($ret), 0, $left);
            array_splice($ret, count($ret), 0, $right);

            return $ret;
        };

        return  $merge($left, $right);
    }
}