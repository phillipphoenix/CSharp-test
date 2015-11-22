package opg1;

public class FizzBuzz {

	/**
	 * Iterates over all ints in the given array and prints "Fizz" if the number is divisible by 3.
	 * It prints "Buzz" if the number is divisible by 5 and it prints "FizzBuzz" if it is divisible by both.
	 * Each iteration also prints a newline (which means that numbers that don't match any case are just empty lines.
	 * @param numbers The int of numbers to iterate over.
	 */
	public static void DoFizzBuzz(int[] numbers) {
		for (int n : numbers) {
			// If divisible by 3.
			if (IsDivisibleBy(n, 3)) {
				System.out.print("Fizz");
			}
			// If divisible by 5.
			if (IsDivisibleBy(n, 5)) {
				System.out.print("Buzz");
			}
			System.out.println();
		}
	}
	
	/**
	 * Checks if a number can be divided by the given int "dividedBy"
	 * @param number The number to be divided.
	 * @param dividedBy The number to divide by.
	 * @return boolean true/false depending on if the number is divisible or not.
	 */
	private static boolean IsDivisibleBy(int number, int dividedBy) {
		return number % dividedBy == 0;
	}
	
}
