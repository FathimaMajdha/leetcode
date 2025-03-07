public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        int prevPrime = -1, minDiff = int.MaxValue;
        int[] result = { -1, -1 };

        for (int i = left; i <= right; i++) {
            if (IsPrime(i)) {
                if (prevPrime != -1 && (i - prevPrime) < minDiff) {
                    minDiff = i - prevPrime;
                    result[0] = prevPrime;
                    result[1] = i;
                }
                prevPrime = i;
            }
        }

        return result;
    }

    private bool IsPrime(int num) {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++) {
            if (num % i == 0) return false;
        }
        return true;
    }
}
