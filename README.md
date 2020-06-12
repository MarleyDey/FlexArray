# FlexArray
This is a lightweight library for a more dynamic supported class for arrays.

## Flex Array Functions

### Fill Array:
This function allows you fill an array with a value of the same
type supported by the array
```csharp
var testArray = new int[10];
testArray.Fill(5);
```
Outputting this array:
```
[5,5,5,5,5,5,5,5,5,5,5]
```

### Replace value in Array:
This function allows you repalce a value in an array with a value 
of the same type supported by the array
```csharp
var testArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
testArray.Replace(4, 12);
```
Outputting this array:
```
[1,2,3,12,5,6,7,8,9,10]
```

### Replace all values in Array:
This funtion allows you to replace all the values in an array with
a value of the same type supported by the array
```csharp
var testArray2 = new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4};
testArray2.ReplaceAll(4, 6);
```
Outputting this array:
```
[1,2,2,3,3,3,6,6,6,6]
```
