import java.util.Scanner;

public class TriangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner inpuScanner = new Scanner(System.in);

		double aX = inpuScanner.nextDouble();
		double aY = inpuScanner.nextDouble();
		double bX = inpuScanner.nextDouble();
		double bY = inpuScanner.nextDouble();
		double cX = inpuScanner.nextDouble();
		double cY = inpuScanner.nextDouble();

		double sideA = pointDistance(aX, aY, bX, bY);
		double sideB = pointDistance(bX, bY, cX, cY);
		double sideC = pointDistance(cX, cY, aX, aY);
		double s = (sideA + sideB + sideC) / 2;
		double area = Math.sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

		System.out.println(area);

	}

	private static double pointDistance(double x1, double y1, double x2,
			double y2) {
		// TODO Auto-generated method stub

		double distance = Math.sqrt(Math.pow((x2 - x1), 2)
				+ Math.pow((y2 - y1), 2));

		return distance;
	}

}
