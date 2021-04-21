package Package;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.sun.jdi.event.Event;

//By Eleson Souza / Lucas Sérgio

@WebServlet("/SearchServlet")
public class SearchServlet extends HttpServlet {
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
	  response.setContentType("text/html");
	  PrintWriter out=response.getWriter();
	  
	  out.print("<h2>Search Employee</h2>");
	  out.print("<form action='SearchServlet2' method='post'>");
	  out.print("<table>");
	  out.print("<tr><td>ID:</td><td><input name='id'/> <button>Search</button></td></tr>");
	  out.print("</table>");
	  out.print("</form>");
      
      out.close();
		
	}
	
	public String teste(Event id) {
		System.out.print(id);
		return "";
	}
}