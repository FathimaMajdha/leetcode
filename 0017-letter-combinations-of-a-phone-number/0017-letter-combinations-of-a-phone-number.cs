
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        
        string[] mapping = new string[] {
            "",    
            "",     
            "abc",  
            "def",  
            "ghi",  
            "jkl",  
            "mno",  
            "pqrs", 
            "tuv",  
            "wxyz"  
        };

        
        List<string> combinations = new List<string>() { "" };

        foreach (char digitChar in digits) {
            int digit = digitChar - '0';
            string letters = mapping[digit];
            List<string> newCombinations = new List<string>();

            foreach (string combo in combinations) {
                foreach (char letter in letters) {
                    newCombinations.Add(combo + letter);
                }
            }

          
            combinations = newCombinations;
        }

        return combinations;
    }
}
