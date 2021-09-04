//Ticket numbers usually consist of an even number of digits.
//A ticket number is considered lucky if the sum of the first half of the digits
//is equal to the sum of the second half.

//Given a ticket number n, determine if it's lucky or not.

//input 1: n = 1230
//expected output: true

//input 2: n = 239017
//expected output: false

//======================================================================================

bool isLucky(int n) {
int firstHalf = 0;
int secHalf = 0;


int[] myArray = n.ToString().Select(x=>Convert.ToInt32(x)).ToArray();
int half = (myArray.Length/2);

for(int i = 0; i < myArray.Length; i++){
    if(i >= half){
        secHalf+= myArray[i];
    }
    else{
        firstHalf+= myArray[i];
    }
}

if(firstHalf == secHalf){
    return true;
}
return false;
}