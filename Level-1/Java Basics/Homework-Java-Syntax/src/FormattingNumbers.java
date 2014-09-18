import java.util.Locale;


public class FormattingNumbers {

	public FormattingNumbers(StringBuilder binaryString, Locale root) {
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int a=254;
		float b=11.6f;
		float c=0.5f;
		
		String aaaString="53";
		
		
		String addInSpace=" ";
		String addInZeros="0";
		
		String hex=Integer.toHexString(a).toUpperCase();
		String binary=Integer.toBinaryString(a);
		
		
		
		for (int i = hex.length(); i < 10; i++) {
		
			hex=hex + addInSpace;
			
		}
		for (int i = binary.length(); i < 10; i++) {
			
			binary=addInZeros+binary;
			
		}
		System.out.printf("%.3f",b);
		
		
		
		System.out.print(binary);
		
	}

}
