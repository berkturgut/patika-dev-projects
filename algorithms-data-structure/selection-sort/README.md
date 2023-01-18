# SELECTION SORT PROJECT

## Question A :

` [22,27,16,2,18,6] ` 

    1. Write the stages of the above given array according to the "Insertion Sort" type.

    2. Write the Big-O notation.

    3. Time Complexity: After sorting the array, which case does the number 18 belong to ?

    - Avarage case: If the number we are looking for is in the middle, this is the case we will use
    - Worst case: This is the case we will use if the number we are looking for is at the end of the array
    - Best case: This is the case we will use if the number we are looking for is at the beginning of the array

## Question B :

`[7,3,5,8,2,9,4,15,6]` 

1. Write the first 4 steps of the array according to the Selection Sort.

---

## Answer A :

1. The stages of the array according to the "Insertion Sort" type is :
```
 [22,27,16,2,18,6]

 [22,27,16,2,18,6]
 
 [16,22,27,2,18,6]

 [2,16,22,27,18,6]

 [2,16,18,22,27,6]

 [2,6,16,18,22,27]
```
2. Insertion sort Big-O notation is :  

- Worst case : O ( $n^2$ )
- Avarage case : O ( $n^2$ )
- Best case : O ( n )

3. Since the number 18 is in the middle of the array, it is included in the **Average Case**.

## Answer B :

1. The first four stages of array according to the selection sort are as follows ;

```
 [2|3,5,8,7,9,4,15,6]

 [2,3|5,8,7,9,4,15,6]
 
 [2,3,4|8,7,9,5,15,6]

 [2,3,4,5|7,9,8,15,6]
```


