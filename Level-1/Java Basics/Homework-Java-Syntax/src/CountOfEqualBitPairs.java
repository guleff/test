import java.util.Scanner;

public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner inputScanner = new Scanner(System.in);

		int n = inputScanner.nextInt();

		System.out.println(getBitPairs(n));

	}

	private static int getBitPairs(int n) {
		// Method counts all bit pairs in the binary representation

		String nBinaryString = Integer.toBinaryString(n);
		char[] nBinaryToCharsArr = new char[nBinaryString.length()];
		nBinaryToCharsArr = nBinaryString.toCharArray();
		int count = 0;

		for (int i = 0; i < nBinaryToCharsArr.length; i++) {

			if (nBinaryToCharsArr[i] == nBinaryToCharsArr[i + 1]) {

				count++;

			}
			if (i == nBinaryToCharsArr.length - 2) {

				break;
			}
		}
		return count;
	}

}
