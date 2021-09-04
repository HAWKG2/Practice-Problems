//Ratiorg got statues of different sizes as a present from CodeMaster for his birthday,
//each statue having an non-negative integer size. Since he likes to make things perfect,
//he wants to arrange them from smallest to largest so that each statue will be bigger than
//the previous one exactly by 1. He may need some additional statues to be able to accomplish
//that. Help him figure out the minimum number of additional statues needed.

//input: [6, 2, 3, 8]
//expected output: 3

//=================================================================================================

int makeArrayConsecutive2(int[] st) {
    Array.Sort(st);
    int totalStatues = 0;
    int tempDiff = 0;
    
    for(int i = st.Length - 1; i > 0; i--){
        tempDiff = 0;
        if(st[i] - st[i - 1] > 1){
            tempDiff = (st[i] - st[i - 1]);
        }
        if(tempDiff > 1){
                    totalStatues+= tempDiff - 1;     
        }
        else{
            totalStatues += tempDiff;
        }
       }
       return totalStatues;
}