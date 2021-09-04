//Given a sequence of integers as an array, determine whether it is possible
//to obtain a strictly increasing sequence by removing no more than one element from the array.
//Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0 < a1 < ... < an.
//Sequence containing only one element is also considered to be strictly increasing


//input 1: [1, 3, 2, 1]
//expected output: false

//input 2: [1, 3, 2]
//expected output: true

================================================================================================================================
bool almostIncreasingSequence(int[] sequence) {
    if (sequence.Length == 2) {return true;}
    
    int countOne = 0;
    int countTwo = 0;
    
    for (int i = 0; i < sequence.Length - 1; i++) {
       if (sequence[i] >= sequence[i+1]) {
           countOne++;
       }
       if(i != 0) {
           if (sequence[i - 1] >= sequence[i + 1]) {
               countTwo++;
           }
       }
    }
    
    if (countOne == 1 && countTwo <= 1) {
        return true;
    } else {
        return false;
    }   
}