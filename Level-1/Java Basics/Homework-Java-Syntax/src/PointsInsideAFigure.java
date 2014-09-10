import java.util.Scanner;

public class PointsInsideAFigure {

	private static double cornerA1 = 12.5;
	private static double cornerA2 = 22.5;
	private static double cornerB1 = 6;
	private static double cornerB2 = 13.5;

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner inputScanner = new Scanner(System.in);

		double x = inputScanner.nextDouble();
		double y = inputScanner.nextDouble();
		isInFigure(x, y);

	}

	private static void isInFigure(double x, double y) {
		// TODO Auto-generated method stub

		if ((x >= cornerA1 && x <= cornerA2)
				&& (y >= cornerB1 && y <= cornerB2)) {

			if ((y <= 8.5)) {

				System.out.println("Inside");
			} else if ((y > 8.5) && (x <= 17.5 || x >= 20)) {
				System.out.println("Inside");
			}

			else {
				System.out.println("Outside");
			}
		} else {
			System.out.println("Outside");
		}

	}

}
