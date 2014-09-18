import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		getRectangeArea();

	}

	private static void getRectangeArea() {
		// TODO Auto-generated method stub
		Scanner inputScanner = new Scanner(System.in);

		int sideA = inputScanner.nextInt();
		int sideB = inputScanner.nextInt();
		int area = sideA * sideB;
		System.out.printf("%d.0",area);
	}

}
