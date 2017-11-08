package com.codewars;

import java.util.ArrayList;
import java.util.List;

class SumDigPower {

    public static List<Long> sumDigPow(long a, long b) {
        List<Long> numbers = new ArrayList<>();
        for (long i = a; i <= b; i++) {
            String t = Long.toString(i);
            long value = i;
            for(int j = 0; j < t.length(); j++) {
                int base = Integer.parseInt(String.valueOf(t.charAt(j)));
                int power = j+1;
                value -= Math.pow(base, power);
            }
            if (value == 0) {
                numbers.add(i);
            }
        }
        return numbers;
    }

    public static void main(String[] args) {
        sumDigPow(1, 89);
    }
}
