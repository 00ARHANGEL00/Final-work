# ***Формулировка задания***

## Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# ***Описание решения***

* ## Задаем длину строк(длина строки будет меньше или равной данной) из которых будет формироваться новый массив;
* ## Объявим и инициализируем массив строк;
* ## Выведем массив строк;
* ## Объявим новый массив строк, в который будет записываться строки меньше или равной заданной длины, затем вызовем метод, который будет принимать массив строк и заданную длину строки, а возвращать заполненый массив;
* ## Создаем метод, внутри через цикл считаем кол-во строк подходящих по размеру, затем объявим и инициализируем массив строк, размером кол-ву подходящих строк, затем через цикл присваиваем созданному массиву, строки из полученного массива определенной длины и возвращаем его.
* ## Выводим получившийся массив строк.