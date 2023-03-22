"""

Задача 20: 
* В настольной игре Скрабл (Scrabble) каждая буква имеет 
определенную ценность. В случае с английским алфавитом 
очки распределяются так:
A, E, I, O, U, L, N, S, T, R – 1 очко; 
D, G – 2 очка; 
B, C, M, P – 3 очка; 
F, H, V, W, Y – 4 очка; 
K – 5 очков; 
J, X – 8 очков; 
Q, Z – 10 очков. 

А русские буквы оцениваются так: 
А, В, Е, И, Н, О, Р, С, Т – 1 очко; 
Д, К, Л, М, П, У – 2 очка; 
Б, Г, Ё, Ь, Я – 3 очка; 
Й, Ы – 4 очка; 
Ж, З, Х, Ц, Ч – 5 очков; 
Ш, Э, Ю – 8 очков; 
Ф, Щ, Ъ – 10 очков. 

Напишите программу, которая вычисляет стоимость введенного 
пользователем слова. Будем считать, что на вход подается 
только одно слово, которое содержит либо только английские, 
либо только русские буквы.

*Пример:*

ноутбук
    12

"""

## Ввод данных в программу:
text1 = str(input("Введите слово: "))
text = text1.upper()
    

## С английским алфавитом очки распределяются так:
## 1 очко
arrayEng1 = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R'}

## 2 очка
arrayEng2 = {'D', 'G'}

## 3 очка
arrayEng3 = {'B', 'C', 'M', 'P'}

## 4 очка
arrayEng4 = {'F', 'H', 'V', 'W', 'Y'}

## 5 очков
arrayEng5 = {'K'}

## 8 очков
arrayEng6 = {'J', 'X'}

## 10 очков
arrayEng7 = {'Q', 'Z'}


## С русским алфавитом очки распределяются так:
## 1 очко
arrayRus1 = {'А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т'}

## 2 очка
arrayRus2 = {'Д', 'К', 'Л', 'М', 'П', 'У'}

## 3 очка
arrayRus3 = {'Б', 'Г', 'Ё', 'Ь', 'Я'}

## 4 очка
arrayRus4 = {'Й', 'Ы'}

## 5 очков
arrayRus5 = {'Ж', 'З', 'Х', 'Ц', 'Ч'}

## 8 очков
arrayRus6 = {'Ш', 'Э', 'Ю'}

## 10 очков
arrayRus7 = {'Ф', 'Щ', 'Ъ'}



## Подсчитываем стоимость введенного пользователем слова:

size = len(text)
sum = 0

for i in range(size):

    if   arrayRus1.intersection(set(text[i])):
        sum += 1
        
    elif arrayRus2.intersection(set(text[i])):
        sum += 2
        
    elif arrayRus3.intersection(set(text[i])):
        sum += 3
        
    elif arrayRus4.intersection(set(text[i])):
        sum += 4
        
    elif arrayRus5.intersection(set(text[i])):
        sum += 5
        
    elif arrayRus6.intersection(set(text[i])):
        sum += 8
        
    elif arrayRus7.intersection(set(text[i])): 
        sum += 10
        
    elif arrayEng1.intersection(set(text[i])):
        sum += 1
        
    elif arrayEng2.intersection(set(text[i])):
        sum += 2
        
    elif arrayEng3.intersection(set(text[i])):
        sum += 3
        
    elif arrayEng4.intersection(set(text[i])):
        sum += 4
        
    elif arrayEng5.intersection(set(text[i])):
        sum += 5
        
    elif arrayEng6.intersection(set(text[i])):
        sum += 8
        
    elif arrayEng7.intersection(set(text[i])): 
        sum += 10
    else:
        sum += 0
        
print(f"Стоимость введенного пользователем слова = {sum}")
    