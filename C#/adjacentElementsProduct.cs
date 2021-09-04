//Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
//Input: [3, 6, -2, -5, 7, 3]
//Expected output: 21

int adjacentElementsProduct(int[] inputArray) {
    
if(inputArray.Length < 2){
    return 0;
}

int sum = int.MinValue;

for(int i = 0; i < inputArray.Length - 1; i++){
    if(inputArray[i] * inputArray[i + 1] > sum){
        sum = inputArray[i] * inputArray[i + 1];
    }
}
return sum;
}