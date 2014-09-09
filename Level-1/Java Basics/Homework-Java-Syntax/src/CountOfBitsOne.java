import java.util.Scanner;

public class CountOfBitsOne {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);

		int n = input.nextInt();

		System.out.println(getBytesOne(n));

	}

	private static int getBytesOne(int n) {
		// Method counts all bytes that equals 1

		int count = 0;
		String nBinaryString = Integer.toBinaryString(n);
		char[] nBinaryToChars = new char[nBinaryString.length()];
		nBinaryToChars = nBinaryString.toCharArray();

		for (int i = 0; i < nBinaryToChars.length; i++) {

			if (nBinaryToChars[i] == '1') {

				count++;
			}
		}

		return count;
	}

}
