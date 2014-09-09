import java.util.Scanner;

public class DecimalToHexadecimal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner inScanner = new Scanner(System.in);

		int num = inScanner.nextInt();

		System.out.println(decimaToHex(num));

	}

	private static String decimaToHex(int num) {

		String hexString = Integer.toHexString(num).toUpperCase();

		return hexString;

	}

}
