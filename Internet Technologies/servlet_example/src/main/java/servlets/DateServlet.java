package servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Date; // Import Date class

import jakarta.servlet.ServletException;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class DateServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;

    public DateServlet() {
        // TODO Auto-generated constructor stub
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        response.setCharacterEncoding("UTF-8");

        PrintWriter out = response.getWriter();

        // HTML content
        String source = 
            "<!DOCTYPE html>" +
            "<html><head><meta charset='UTF-8'></head>"+
            "<body>" + 
            "Current date: " + new Date() +
            "</body>" +
            "</html>";

        out.print(source);
    }
}
