# Final Project

Программа принимает на вход строки, разделенные пробелом и отправляет на печать те из них, длина которых меньше 4.\
Если на вход не поступило аргументов, программа работает с дефолтным массивом строк. \
Исходный код находится в папке code, блок-схемы - в папке flowcharts. 

## Пример

``dotnet run one two three`` 

## Принцип работы

``class Input``\
``get`` метод проверяет количество аргументов Main и возвращает массив строк, которые ввел пользователь, или дефолтный массив.

``class StringFilter``\
``filter`` метод вызывает Linq метод Where с предикатом Length <= 3 и кофертирует полученный IEnumerable в массив.
