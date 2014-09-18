import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		getRectangeArea();

	}

	private static void getRectangeArea() {
		// TODO Auto-generated method stub
		Scanner inputScanner = new Scanner(System.in);

		double sideA = inputScanner.nextDouble();
		double sideB = inputScanner.nextDouble();
		double area = sideA * sideB;
		System.out.println(area);
	}

}
