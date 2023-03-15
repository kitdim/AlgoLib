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
            $arr = [1,5,6,6,8,9,8,8,5,2,1,9,-9,5,-5];
            $count = count($arr);
            $searchValue = rand(min($arr), max($arr));

            foreach ($arr as $el) echo "{$el} ";
            echo "<br/>Ищем: {$searchValue}";
            switch ($_POST['num_algo'])
            {
                case 1:
                    echo "<br />Линейный поиск";
                    echo SearchLib::LinerSearch($arr, $count - 1, $searchValue);
                    exit();
                case 2:
                    $index = 0;
                    echo "<br />Индекс: {$index} <br />";
                    echo "<br />Рекурсивно-линейный поиск<br />";
                    echo SearchLib::RecursLinearSearch($arr, $count - 1, $index, $searchValue);
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
