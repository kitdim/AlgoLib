<!DOCTYPE html>
<html lang="ru">
<head>
    <title>Algorithms</title>
    <meta charset='utf-8' />
</head>
<body>
    <?php
        if(!empty($_POST))
        {
            require_once 'Lib.php';

            switch ($_POST['num_algo'])
            {
                case 1:
                    $arr = [1,5,6,6,8,9,8,8,5,2,1,9,-9,5,];
                    $count = count($arr);
                    $searchValue = rand(min($arr), max($arr));

                    echo "<br/>Ищем линейным поиском в неосортированном массиве: $searchValue<br/>";
                    foreach ($arr as $el) echo "$el ";

                    echo SearchLib::LinerSearch($arr, $count - 1, $searchValue);
                    exit();

                case 2:
                    $arr = [1,5,8,6,8,9,8,8,5,2,1,9,-9,5,];
                    $count = count($arr);
                    $searchValue = rand(min($arr), max($arr));
                    $index = 0;

                    echo "<br/>Ищем линейно-рекурсивным поиском в неосортированном массиве: $searchValue<br/>";
                    foreach ($arr as $el) echo "$el ";

                    echo "<br />Индекс: {$index} <br />";
                    echo SearchLib::RecursLinearSearch($arr, $count - 1, $index, $searchValue);
                    exit();

                case 3:
                    $arrBinary = range(1,20);
                    $countBinary = sizeof($arrBinary) - 1;
                    $searchValueBinary = rand(min($arrBinary) - 10, max($arrBinary) + 10);

                    echo "Ищем бинарным поиском в отсортированном массиве: $searchValueBinary<br/>";
                    echo sprintf("Размер массива %d<br/ >", $countBinary + 1);
                    foreach ($arrBinary as $el) echo "$el ";

                    echo SearchLib::BinaryFunction($arrBinary, $countBinary, $searchValueBinary);
                    exit();

                default:
                    echo "Не готово";
                    exit();
            }
        }
    ?>

    <form method='post'>
        <span>Номер алгоритма</span><br />
        <input type='number' name='num_algo'>
        <input type='submit' value='Отправить' />
    </form>
</body>
</html>
