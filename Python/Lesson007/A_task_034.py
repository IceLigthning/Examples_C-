"""

Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. 
Поскольку разобраться в его кричалках не настолько просто, насколько легко 
он их придумывает, Вам стоит написать программу. Винни-Пух считает, что ритм 
есть, если число слогов (т.е. число гласных букв) в каждой фразе стихотворения 
одинаковое. Фраза может состоять из одного слова, если во фразе несколько 
слов, то они разделяются дефисами. Фразы отделяются друг от друга пробелами. 
Стихотворение  Винни-Пух вбивает в программу с клавиатуры. В ответе напишите 
“Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, если с ритмом 
 ьвсе не в порядке

*Пример:*

**Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да    
    **Вывод:** Парам пам-пам  

"""



arr = 'пара-ра-рам рам-пам-папам па-ра-па-да'

arr = arr.upper()

## Разделить список
def dividList(array_1):
    
    list_1 = array_1.split(' ')

    print(list_1)
    
    return list_1
    

## разбить каждый элемент на новый список

def getNewList(array_2):
    
    a = set('А')

    count = 0    
    size_2 = len(array_2)
    number = []
    for i in range(size_2):
        array_3 = list(array_2[i])
        size_3 = len(array_3)
        for j in range(size_3):
            
            if a.intersection(array_3[j]):
                
                count += 1
                
        number.append(count)
        count *= 0
    return number

## 

def equalVal(value):
    
    
    size_4 = len(value)
    
    arg1 = value[0]
    arg2 = value[size_4-1]
    
    summa = 0
    for i in range(size_4):
        
        summa += value[i]
        
    res = summa / size_4
    
    if res == arg1 == arg2:
        return 'Парам пам-пам'
    else: return 'Пам парам'
        

## Вызываем функции

d = dividList(arr)

vowels = getNewList(d)

print(equalVal(vowels))





    
    