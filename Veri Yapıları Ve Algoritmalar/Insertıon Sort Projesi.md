# Insertıon Sort Projesi
# Proje-1
## Answer 1

*[22,27,16,2,18,6] -> Insertion Sort* 

[22,~~27~~,16,2,18,6]->[22,27,~~16~~,2,18,6]->[16,22,27,~~2~~,18,6]->[2,16,22,27,~~18~~,6]->[2,16,18,22,27,~~6~~]->[2,6,16,18,22,27]

`[22,27,16,2,18,6]-> Insertion Sort`

## Answer 2
* Her bir eleman için sağına ve soluna baktığımızdan n*n işleminden big o notation O(n^2) olur.

## Answer 3
* Time Complexity: Average case: Aradığımız sayının ortada olması, Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.

## Answer 4
* 18 sayisi dizinin sonunda olduğundan dolayı aradığımız case: ***Worst Case.***

## Answer 5 
 [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

* 1- [7,~~3~~,5,8,2,9,4,15,6]->[3,7,5,8,2,9,4,15,6]
* 2- [3,7,~~5~~,8,2,9,4,15,6]->[3,5,7,8,2,9,4,15,6]
* 3- [3,5,7,~~8~~,2,9,4,15,6]->[3,5,7,8,2,9,4,15,6]
* 4- [3,5,7,8,~~2~~,9,4,15,6]->[2,3,5,7,8,9,4,15,6]

# Proje-2
               [16,21,11,8,12,22] -> Merge Sort

       [16,21,11]        ---        [8,12,22]
     [16,21] ---[11]            [8,12] --- [22]   
    [16] -- [21]  [11]        [8] -- [12]  [22]
      [16,21] [11]              [8,12] [22]
        [11,16,21]                [8,12,22]
                 [8,11,12,16,21,22]

**[8,11,12,16,21,22]**

* ***Big O Notation Gösterimi O(nLogn)***

# Proje 3

[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

                          [7]
                  [5]      |      [8]
         [1]       |   [6] |       |    [9]
     [0]  | [3]    |       |
             |             | 
         [2] | [4] |       |
                           |