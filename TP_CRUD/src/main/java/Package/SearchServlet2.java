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

// By Eleson Souza / Lucas Sérgio

@WebServlet("/SearchServlet2")
public class SearchServlet2 extends HttpServlet {
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setContentType("text/html");
		PrintWriter out=response.getWriter();
		
		String sid = request.getParameter("id");
		    int id = Integer.parseInt(sid);
		
		Emp emp = EmpDao.getEmployeeById(id);
		  
		out.print("<h2>Search Employee</h2>");
		
		  if(emp.getName() != null) {
			  out.print("<form action='EditServlet2' method='post'>");
			  out.print("<table>");
			  out.print("<tr><td>Name:</td><td><input type='text' name='name' readonly value='"+ emp.getName() +"'/></td></tr>");
			  out.print("<tr><td>Password:</td><td><input type='password' name='password' readonly value='"+ emp.getPassword() +"'/></td></tr>");
			  out.print("<tr><td>Email:</td><td><input type='email' name='email' readonly value='"+ emp.getEmail() +"'/></td></tr>");
			  out.print("<tr><td>Country:</td><td>");
			  out.print("<select name='country' style='width:150px'>");
			  out.print("<option>India</option>");
			  out.print("<option>USA</option>");
			  out.print("<option>UK</option>");
			  out.print("<option>Other</option>");
			  out.print("</select>");
			  out.print("</td></tr>");
			  out.print("</table>");
			  out.print("</form>");
		  } else {
			  out.print("<br/><h4>Not Found results!</h4>");
		  }
		  
		  out.print("<br/><a href='SearchServlet'>Back to search</a>");
		  
		  out.close();
		
	}
}