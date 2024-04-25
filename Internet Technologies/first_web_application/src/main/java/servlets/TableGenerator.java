package servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Random;

import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class TableGenerator extends HttpServlet {
	private static final long serialVersionUID = 1L;
	public static int MAX_ROWS = 20; 
 
    public TableGenerator() {
        // TODO Auto-generated constructor stub
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html");
		response.setCharacterEncoding("UTF-8");
	
		PrintWriter out = response.getWriter();
	
		String source = 
			"<!DOCTYPE html>" +
			"<html>"+
				"<head> <meta charset='UTF-8'></head>" +
				"<body>" + 
					  "<table border='1'>";

		Random rand = new Random();
		int rows = rand.nextInt(MAX_ROWS+1); 
			
		for(int i=0 ; i<rows ; i++)
		{
				source += 
				"<tr>"+
					"<td bgcolor='"+getRandomColor()+"'>test</td>"+
					"<td bgcolor='"+getRandomColor()+"'>test</td>"+
				"</tr>";
		}

	
		source += "</table>" +
				"</body>" +
			"</html>";
			
		out.print(source);

	}


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}
	
	protected String getRandomColor()
	{
			String digits = "0123456789ABCDEF";
			String color = "#";
			
			for(int i=0;i<6;i++)
			{
				int randomPosition = (int)(Math.random()*16);
				color += digits.charAt(randomPosition);
			}
			
			return color;
	}


}
