Сначала пользователя просят ввести строку с элементами через пробел.
Далее создается массив из строк, из строки, которая разделяется пробелами с помощью метода Split, далее в этом массиве выбираются элементы длина у которых меньше 3 с помощью метода Where, и из полученного интерфейса IEnumerable<List> с помощью метода ToArray<string>() создается массив, который и присваивается в array.
Далее элементы полученного array выводятся в консоль.