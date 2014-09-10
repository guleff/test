import java.util.Scanner;

public class PointsInsideTheHouse {

	private static double cornerA1 = 12.5;
	private static double cornerA2 = 22.5;
	private static double cornerB1 = 3.5;
	private static double cornerB2 = 8.5;

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner inputScanner = new Scanner(System.in);

		double x = inputScanner.nextDouble();
		double y = inputScanner.nextDouble();

		if (isInQuadrat(x, y) == true) {
			System.out.println("Inside");
		} else if (isInHouseRoof(x, y) == true) {
			System.out.println("Inside");
		} else if (isInRectrangle(x, y) == true) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}

	}

	private static boolean isInRectrangle(double x, double y) {
		// TODO Auto-generated method stub

		if ((x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5)) {

			return true;
		} else {
			return false;
		}

	}

	private static boolean isInHouseRoof(double x, double y) {
		// TODO Auto-generated method stub
		if (((x >= cornerA1 && x <= cornerA2) && (y >= cornerB1 && y <= cornerB2))
				&& (x + y >= 21)) {

			if (x <= 17.5 && x + y >= 21) {
				return true;
			} else if (x >= 17.5 && x - y <= 14) {
				return true;
			} else {
				return false;
			}

		} else {
			return false;
		}

	}

	private static boolean isInQuadrat(double x, double y) {
		// TODO Auto-generated method stub

		if ((x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5)) {

			return true;

		} else {
			return false;
		}
	}
}
