import java.io.FileInputStream;

public class test1 {
	public static void main(String args[]){
		String loadFile = "D:/temp/test2.java";
		loadFile(loadFile);
	}
	
	private static void loadFile(String filePath) {
		try {
			String outFile = filePath + "abc";
			FileInputStream fis = new FileInputStream(outFile);
			
			byte[] buff = new byte[1024];
			int length = 0;
			while ((length = fis.read(buff, 0, buff.length)) > -1) {
				System.out.println("pulsed!");
			}
			
			fis.close();
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
}
