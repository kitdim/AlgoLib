<!DOCTYPE html>
<html lang="ru">
<head>
    <title>Algorithms</title>
    <meta charset='utf-8'/>
</head>
<body>
<?php
if (!empty($_POST)) {
    require_once 'Lib.php';

    switch ($_POST['num_algo']) {
        case 1:
            $arr = [1, 5, 6, 6, 8, 9, 8, 8, 5, 2, 1, 9, -9, 5,];
            $count = count($arr);
            $searchValue = rand(min($arr), max($arr));

            echo "<br/>Ищем линейным поиском в неосортированном массиве: $searchValue<br/>";
            foreach ($arr as $el) echo "$el ";

            echo AlgoritmsLibrary::LinerSearch($arr, $count - 1, $searchValue);
            exit();

        case 2:
            $arr = [1, 5, 8, 6, 8, 9, 8, 8, 5, 2, 1, 9, -9, 5,];
            $count = count($arr);
            $searchValue = rand(min($arr), max($arr));
            $index = 0;

            echo "<br/>Ищем линейно-рекурсивным поиском в неосортированном массиве: $searchValue<br/>";
            foreach ($arr as $el) echo "$el ";

            echo "<br />Индекс:$index <br />";
            echo AlgoritmsLibrary::recurs_linear_search($arr, $count - 1, $index, $searchValue);
            exit();

        case 3:
            $arrBinary = range(1, 20);
            $countBinary = sizeof($arrBinary) - 1;
            $searchValueBinary = rand(min($arrBinary) - 10, max($arrBinary) + 10);

            echo "Ищем бинарным поиском в отсортированном массиве: $searchValueBinary<br/>";
            echo sprintf("Размер массива %d<br/ >", $countBinary + 1);
            foreach ($arrBinary as $el) echo "$el ";

            echo AlgoritmsLibrary::BinaryFunction($arrBinary, $countBinary, $searchValueBinary);
            exit();
        case 4:
            $arrBinaryRec = range(1, 20);
            $countBinaryRec = sizeof($arrBinaryRec) - 1;
            $lowIndexRec = 0;
            $highIndexRec = $countBinaryRec;
            $searchValueBinaryRec = rand(min($arrBinaryRec) - 10, max($arrBinaryRec) + 10);

            echo "Ищем бинарным поиском c использование рекурсии в отсортированном массиве: $searchValueBinaryRec<br/>";
            echo sprintf("Размер массива %d<br/ >", $countBinaryRec + 1);
            foreach ($arrBinaryRec as $el) echo "$el ";

            echo AlgoritmsLibrary::BinaryFunctionRec($arrBinaryRec, $lowIndexRec, $highIndexRec, $searchValueBinaryRec);
            exit();
        case 5:
            $arrSort = [];
            for ($i = 0; $i < 10; $i++)
                $arrSort[$i] = rand(-100, 100);
            echo "Сортировка выбором<br/>";

            echo "До сортировки:<br/>";
            foreach ($arrSort as $el) echo "$el ";

            echo "<br/>После сортировки:<br/>";
            $arrSort = AlgoritmsLibrary::SelectionSort($arrSort);
            foreach ($arrSort as $el) echo "$el ";
            exit();
        case 6:
            for ($i = 0; $i < 10; $i++)
                $arrSort[$i] = rand(-100, 100);
            echo "Сортировка выбором<br/>";

            echo "До сортировки:<br/>";
            foreach ($arrSort as $el) echo "$el ";

            echo "<br/>После сортировки:<br/>";
            $arrSort = AlgoritmsLibrary::InsertSor($arrSort);
            foreach ($arrSort as $el) echo "$el ";
            exit();
        default:
            echo "Не готово";
            exit();
    }
}
?>

<form method='post'>
    <span>Номер алгоритма</span><br/>
    <input type='number' name='num_algo'>
    <input type='submit' value='Отправить'/>
</form>
</body>
</html>
