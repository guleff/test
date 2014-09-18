import java.util.Scanner;

public class SmallestOfThreeNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		System.out.println("Enter 3 number to get the smallest one:");

		System.out.println(smallestNumber(getUserNumbers()));

	}

	private static double[] getUserNumbers() {
		// TODO Auto-generated method stub
		Scanner inputScanner = new Scanner(System.in);
		double[] userNumbers = new double[3];
		for (int i = 0; i < userNumbers.length; i++) {
			userNumbers[i] = inputScanner.nextDouble();
		}

		smallestNumber(userNumbers);
		return userNumbers;
	}

	private static double smallestNumber(double[] arr) {
		// TODO Auto-generated method stub
		double smallestNum = arr[0];

		for (int i = 0; i < arr.length; i++) {

			if (arr[i] < smallestNum) {
				smallestNum = arr[i];
			}
		}
		return smallestNum;
	}
}
