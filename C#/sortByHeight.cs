//Some people are standing in a row in a park.
//There are trees between them which cannot be moved.
//Your task is to rearrange the people by their heights
//in a non-descending order without moving the trees (which will be any negative integers in the input arrays)

//input: [-1, 150, 190, 170, -1, -1, 160, 180]
//expected output: [-1, 150, 160, 170, -1, -1, 180, 190]

int[] sortByHeight(int[] a) {
    int temp;

    for(int i = 0; i < a.Length - 1; i++){
        for(int j = i + 1; j < a.Length; j++){
            if(a[i] <= 0){
                continue;
            }
            else{
                if(a[i] >= a[j] && a[j] >= 0){
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
    return a;
}