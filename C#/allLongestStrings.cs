//Given an array of strings, return another array containing all of its longest strings.

//input: ["aba", "aa", "ad", "vcd", "aba"]
//expected output: ["aba", "vcd", "aba"]

//================================================================================================

string[] allLongestStrings(string[] inputArray) {
    if(inputArray.Length == 1){
        return inputArray;
    }
    int tempLength = 0;
    List<string> stringlist = new List<String>();
    
    // Get longest string
    foreach(string s in inputArray){
        if(s.Length > tempLength){
            tempLength = s.Length;
        }
    }
    
    for(int i =0; i < inputArray.Length; i++){
        if(inputArray[i].Length == tempLength){
            stringlist.Add(inputArray[i]);
        }
    }
    return stringlist.ToArray();
}