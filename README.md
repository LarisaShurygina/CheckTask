# Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм решения:
1. Изначальный массив задаем в начале нашего алгоритма.
2. Проверяем, с нулевой строки начинается массив или нет
3. Цикл начинается когда строка с индексом i < n. n - размер цикла.
4. В цикле проверяем количество символов в элементах. Если их <=3, то этот элемент добавляется в счетчик и выводится на экран.