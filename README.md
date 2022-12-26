# Итоговый проект
## Задание:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача:** 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []

**Решение:**

Пользователь с клавиатуры задает длину массива (n) и заполняет массив (array) элементами.

Проверяем все элементы массива на выполнение условия: длина элемента <= 3.

Если элемент подходит под данное условие, добавляем его в новый массив (newarray), с использованием счетчика (count) для последовательного заполнения массива.

Выводим новый массив на экран.

**Блок-схема:**

![Здесь должна быть блок-схема алгоритма решения задачи](блок-схема.png)
