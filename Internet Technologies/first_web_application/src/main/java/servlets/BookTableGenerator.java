package servlets;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;

import java.nio.charset.StandardCharsets;

import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class BookTableGenerator extends HttpServlet {
    private static final long serialVersionUID = 1L;

    public BookTableGenerator() {
        // TODO Auto-generated constructor stub
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        response.setCharacterEncoding("UTF-8");

        PrintWriter out = response.getWriter();

        String source =
                "<!DOCTYPE html>" +
                        "<html>" +
                        "<body><head><meta charset='UTF-8'></head>" +
                        generateTableFromFile(request) +
                        "</body>" +
                        "</html>";

        out.print(source);
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        // TODO Auto-generated method stub
        doGet(request, response);
    }

    protected String generateTableFromFile(HttpServletRequest request) throws IOException {
        // Creating the table header
        String tableCode =
                "<table border='1'>" +
                        "<tr>" +
                        "<th>Заглавие</th>" +
                        "<th>Автор</th>" +
                        "<th>Страници</th>" +
                        "<th>Година</th>" +
                        "</tr>";

        // Getting the real path to the file
        ServletContext context =
                request.getServletContext();
        String filePath =
                context.getRealPath("/resources/books.txt");

        // Opening the UTF_8 file for reading
        FileReader fr = new FileReader(filePath,
                StandardCharsets.UTF_8);

        // Passing fr to a buffer for easier reading of lines
        BufferedReader br = new BufferedReader(fr);

        // Loop for traversing the file
        while (true) {
            // Reading one book (line) from the file
            String line = br.readLine();

            // Checking for end of file
            if (line == null)
                break;

            // Splitting the line into title, author, pages, and year
            String[] bookData = line.split("\t");

            // Assigning values for better readability
            String title = bookData[0];
            String author = bookData[1];
            String pages = bookData[2];
            String year = bookData[3];

            // Generating a table row with book information
            tableCode += "<tr>";
            tableCode += "<td>" + title + "</td>";
            tableCode += "<td>" + author + "</td>";
            tableCode += "<td>" + pages + "</td>";
            tableCode += "<td>" + year + "</td>";
            tableCode += "</tr>";
        }

        // Closing the file
        br.close();
        fr.close();

        // Closing the table
        tableCode += "</table>";

        // Returning the generated HTML table with book information
        return tableCode;
    }
}
